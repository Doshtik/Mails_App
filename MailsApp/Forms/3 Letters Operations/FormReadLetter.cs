using MailsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailsApp.Forms._3_Letters_Operations
{
    public partial class FormReadLetter : Form
    {
        private int _letterId;
        private Models.User _user;
        private string _attachmentsDir;

        public FormReadLetter(int letterId)
        {
            InitializeComponent();
            _letterId = letterId;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _attachmentsDir = Path.Combine(appDataPath, "MailsApp", "Attachments");

            using (MailsAppContext db = new MailsAppContext())
            {
                Letter letter = db.Letters.First(l => l.Id == _letterId);
                Attachment[] attachments = db.Attachments.Where(l => l.IdLetter == _letterId).ToArray();
                foreach (Attachment attachment in attachments)
                {
                    string path = Path.Combine(_attachmentsDir, attachment.FileName);
                    AttachmentItem item = new AttachmentItem(attachment);
                    item.Click += (s, e) =>
                    {
                        if (File.Exists(path))
                        {
                            try
                            {
                                Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Не удалось открыть файл: {ex.Message}", "Ошибка", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Файл не найден!", "Ошибка", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };
                    flowPanelAttachments.Controls.Add(item);
                }
                _user = db.Users.First(u => u.Id == letter.IdMailboxSender);

                labelTheme.Text = letter.Theme;
                panelUser.Controls.Add(new LetterUserItem(letter.Id));
                textBoxMessage.Text = letter.Message;
            }
        }

        private void buttonResponce_Click(object sender, EventArgs e)
        {
            FormMakeLetter form = new FormMakeLetter(_user.Id, _letterId);
            form.ShowDialog();
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить это сообщение?", 
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {

                using (MailsAppContext db = new MailsAppContext())
                {
                    int statusId = db.Statuses.First(s => s.StatusName == "deleted").Id;
                    Letter letter = db.Letters.First(letter => letter.Id == _letterId);

                    if (letter.IdStatus == statusId)
                    {
                        Attachment[] attachments = db.Attachments.Where(a => a.IdLetter == letter.Id).ToArray();
                        db.RemoveRange(attachments);
                        db.Remove(letter);
                    }
                    else
                    {
                        letter.IdStatus = statusId;
                    }
                    
                    db.SaveChanges();
                }
                MessageBox.Show("Сообщение успешно удалено", "Успех", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
