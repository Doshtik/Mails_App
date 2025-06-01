using MailsApp.Forms._3_Letters_Operations;
using MailsApp.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace MailsApp.Forms
{
    public partial class FormMakeLetter : Form
    {
        private int _idMailboxSender;
        private string[] _filePathes;
        private string _attachmentsDir;
        private int? _idLetterResponce;

        private const string _draftStatusName = "draft";
        private const string _sentStatusName = "sent";

        //Глобальная переменная для хранения позиции Y для копий письма
        private int _y;
        private List<TextBox> listRecipientCopy;

        private bool _saveToDrafts = true;

        public FormMakeLetter(int idMailboxSender)
        {
            InitializeComponent();
            //Получаем Id отправителя
            _idMailboxSender = idMailboxSender;
            listRecipientCopy = new List<TextBox>();
            this.Text = "Новое сообщение";
        }
        public FormMakeLetter(int idMailboxSender, int idLetterResponce)
        {
            InitializeComponent();
            //Получаем Id отправителя
            _idMailboxSender = idMailboxSender;
            listRecipientCopy = new List<TextBox>();
            _idLetterResponce = idLetterResponce;
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter letter = db.Letters.First(l => l.Id == idLetterResponce);
                textBoxRecipient.Text = db.Mailboxes.First(mb => mb.Id == letter.IdMailboxSender).MailName;
                textBoxRecipient.ReadOnly = true;
            }
            this.Text = "Новое сообщение | Ответ другое сообщение";
        }
        public FormMakeLetter(int idMailboxSender, Letter letter)
        {
            InitializeComponent();
            _idMailboxSender = idMailboxSender;
            
        }

        protected override void OnLoad(EventArgs e)
        {
            _y = textBoxRecipient.Location.Y + textBoxRecipient.Size.Height + 20;

            //Если папки для хранения вложенных файлов не было, то создаем ее
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _attachmentsDir = Path.Combine(appDataPath, "MailsApp", "Attachments");

            using (MailsAppContext db = new MailsAppContext())
            {
                List<MailLabel> labels = db.MailLabels
                    .OrderBy(l => l.Id)
                    .ToList();

                comboBoxLabels.DisplayMember = "LabelName";
                comboBoxLabels.ValueMember = "Id";
                comboBoxLabels.DataSource = labels;

                comboBoxLabels.SelectedIndex = -1;             
            }

            if (!Directory.Exists(_attachmentsDir))
            {
                Directory.CreateDirectory(_attachmentsDir);
            }
            base.OnLoad(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            if (!_saveToDrafts)
                return;

            DialogResult dr = MessageBox.Show("Вы хотите сохранить сообщение в черновик?", 
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (MailsAppContext db = new MailsAppContext())
                {
                    int draftStatusId = db.Statuses.First(s => s.StatusName == _draftStatusName).Id;
                    MailLabel selectedLabel = comboBoxLabels.SelectedItem as MailLabel;
                    int? idLabel = selectedLabel?.Id;

                    Letter letterSender = new Letter()
                    {
                        IdStatus = draftStatusId,
                        IdMailboxSender = _idMailboxSender,
                        IdCopyRecipient = _idMailboxSender,
                        Theme = textBoxTheme.Text.Trim(),
                        Message = textBoxTheme.Text.Trim(),
                        Date = DateTime.Now,
                        IdLabel = idLabel,
                        IsFavorite = false,
                        IsRead = false,
                    };

                    Mailbox? mailboxRecipient = db.Mailboxes.FirstOrDefault(mb => mb.MailName == textBoxRecipient.Text.Trim());
                    if (mailboxRecipient != null) 
                        letterSender.IdMailboxRecipient = mailboxRecipient.Id;
                    else 
                        letterSender.IdMailboxRecipient = null;
                    db.SaveChanges();
                }
            }
            base.OnClosed(e);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            //Размер трех textbox-ов с отступами ~110
            if (panelRecipient.Height < 110)
            {
                TextBox textBoxCopy = new TextBox();
                textBoxCopy.Name = "textBoxCopy" + listRecipientCopy.Count;
                textBoxCopy.PlaceholderText = "Копия:";
                textBoxCopy.Size = textBoxRecipient.Size;
                textBoxCopy.Location = new Point(textBoxRecipient.Location.X, _y);
                
                _y += textBoxCopy.Height + 20;
                panelRecipient.Height += textBoxCopy.Height + 20;
                panelRecipient.Controls.Add(textBoxCopy);
                listRecipientCopy.Add(textBoxCopy);
            }
        }

        private void buttonAttach_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // Проверяем, что выбрано не более 3 файлов
            int amountFiles = openFileDialog1.FileNames.Length;
            if (amountFiles > 3)
            {
                MessageBox.Show("Можно прикрепить не более 3 файлов", 
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Создаем массив для хранения путей файлов
            _filePathes = new string[amountFiles];

            for (int i = 0; i < amountFiles; i++)
            {
                //Добавляем путь файла в массив
                string fileName = Path.GetFileName(openFileDialog1.FileNames[i]);
                _filePathes[i] = openFileDialog1.FileNames[i];

                //Создаем и добавляем элемент вложения на форму
                AttachmentItem item = new AttachmentItem(fileName);
                flowPanelAttachments.Controls.Add(item);

                // Сохраняем ссылку на item в локальную переменную для использования в лямбда-выражении
                AttachmentItem currentItem = item;
                currentItem.Deleted += (s, e) =>
                {
                    for (int j = 0; j < _filePathes.Length; j++)
                    {
                        if (_filePathes[j] != null && 
                        _filePathes[j].EndsWith(currentItem.FileName))
                        {
                            _filePathes[j] = null;
                            currentItem.Deleted = null;
                        }
                    }
                    flowPanelAttachments.Controls.Remove(currentItem);
                    currentItem = null;
                };
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //Проверяем поле на null
            if (textBoxRecipient.Text == String.Empty)
            {
                MessageBox.Show("Получатель не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (MailsAppContext db = new MailsAppContext())
            {
                //Находим получателя
                Mailbox mailboxRecipient = db.Mailboxes.First(mb => mb.MailName == textBoxRecipient.Text);
                if (mailboxRecipient == null)
                {
                    MessageBox.Show($"Получатель {textBoxRecipient.Text} не найден или указан неверно",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Получаем список получателей, указанных в копии
                List<Mailbox> mailboxesRecipientCopy = new List<Mailbox>();
                if (listRecipientCopy.Count != 0)
                {
                    foreach (TextBox tb in listRecipientCopy)
                    {
                        Mailbox mb = db.Mailboxes.First(m => m.MailName.Equals(tb.Text));

                        if (mb == null)
                        {
                            MessageBox.Show($"Получатель {tb.Text} не найден или указан неверно",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        MessageBox.Show($"{mb.MailName} - найден", "Информация", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mailboxesRecipientCopy.Add(mb);
                    }
                }

                //Если пользователь не указал ни тему ни тело сообщения делаем подтверждение отправки
                if (textBoxMassage.Text == String.Empty && textBoxTheme.Text == String.Empty)
                {
                    if (MessageBox.Show("Вы действительно хотите отправить сообщение без темы и сообщения?",
                        "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                }

                int idSended = db.Statuses.First(s => s.StatusName.Equals(_sentStatusName)).Id;
                MailLabel selectedLabel = comboBoxLabels.SelectedItem as MailLabel;
                int? idLabel = selectedLabel?.Id;

                //Создаем письма
                Letter letterSender = new Letter(idSended, _idMailboxSender, mailboxRecipient.Id,
                    _idMailboxSender, textBoxMassage.Text, DateTime.UtcNow, textBoxTheme.Text, _idLetterResponce);
                letterSender.IdLabel = idLabel;
                db.Letters.Add(letterSender);

                Letter letterRecipient = new Letter();
                if (_idMailboxSender != mailboxRecipient.Id)
                {
                    letterRecipient = new Letter(idSended, _idMailboxSender, mailboxRecipient.Id,
                        mailboxRecipient.Id, textBoxMassage.Text, DateTime.UtcNow, textBoxTheme.Text, _idLetterResponce);
                    letterRecipient.IdLabel = idLabel;
                    db.Letters.Add(letterRecipient);
                }

                //Добавляем письма в БД
                db.SaveChanges();

                //Проверяем наличие вложений
                if (_filePathes != null)
                {
                    foreach (string file in _filePathes)
                    {
                        if (file != null)
                        {
                            //Получаеам файл и копируем в папку AppData
                            //(В реальном проекте пришлось бы загружать на сервер)
                            string fileName = Path.GetFileName(file);
                            fileName = CopyFile(file, fileName);

                            //Создаем записи вложений для БД
                            Attachment attachSender = new Attachment()
                            {
                                IdLetter = letterSender.Id,
                                FileName = fileName
                            };
                            db.Attachments.Add(attachSender);

                            if (_idMailboxSender != mailboxRecipient.Id)
                            {
                                Attachment attachRecipient = new Attachment()
                                {
                                    IdLetter = letterRecipient.Id,
                                    FileName = fileName
                                };
                                db.Attachments.Add(attachRecipient);
                            }

                            //Добавляем записи вложений в БД
                            db.SaveChanges();
                        }
                    }
                }

                foreach (Mailbox mailboxRecipientCopy in mailboxesRecipientCopy)
                {
                    Letter letterRecipientCopy = new Letter(idSended, _idMailboxSender, mailboxRecipient.Id,
                    mailboxRecipientCopy.Id, textBoxMassage.Text, DateTime.UtcNow, textBoxTheme.Text, _idLetterResponce);
                    letterRecipientCopy.IdLabel = idLabel;

                    db.Letters.Add(letterRecipientCopy);
                    db.SaveChanges();

                    if (_filePathes == null)
                        break;

                    foreach (string file in _filePathes)
                    {
                        if (file == null)
                            continue;

                        string fileName = Path.GetFileName(file);
                        if (_idMailboxSender != mailboxRecipient.Id)
                        {
                            Attachment attachRecipientCopy = new Attachment()
                            {
                                IdLetter = letterRecipientCopy.Id,
                                FileName = fileName
                            };

                            db.Attachments.Add(attachRecipientCopy);
                            db.SaveChanges();
                        }
                    }
                }
                MessageBox.Show("Письмо успешно отправлено",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _saveToDrafts = false;
                this.Close();
            }

        }

        private string CopyFile(string file, string fileName)
        {
            string filePath = Path.Combine(_attachmentsDir, fileName);
            try
            {
                File.Copy(file, filePath);
            }
            catch
            {
                fileName = Path.GetFileNameWithoutExtension(fileName);
                string ext = Path.GetExtension(file);
                fileName = fileName + "_copy" + ext;

                CopyFile(file, fileName);
            }
            return fileName;
        }
    }
}
