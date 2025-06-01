using MailsApp.Forms._1_User_Operations;
using MailsApp.Forms._3_Letters_Operations;
using MailsApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailsApp.Forms
{
    public partial class FormLetters : Form
    {
        private Mailbox _mailbox;
        private Label _selectedLabel;

        private EventHandler _promoHandler;
        private EventHandler _notificationHandler;
        private EventHandler _workHandler;

        private const string _deletedStatusName = "deleted";
        private const string _labelPromo = "promotion";
        private const string _labelNotification = "notification";
        private const string _labelWork = "work";

        private int _idLabelPromo;
        private int _idLabelNotification;
        private int _idLabelWork;
        private int _idDeletedStatus;

        public FormLetters(int idMailbox)
        {
            InitializeComponent();
            using (MailsAppContext db = new MailsAppContext())
            {
                _mailbox = db.Mailboxes.First(mb => mb.Id == idMailbox);
                _idLabelPromo = db.MailLabels.First(ml => ml.LabelName == _labelPromo).Id;
                _idLabelNotification = db.MailLabels.First(ml => ml.LabelName == _labelNotification).Id;
                _idLabelWork = db.MailLabels.First(ml => ml.LabelName == _labelWork).Id;
                _idDeletedStatus = db.Statuses.First(s => s.StatusName == _deletedStatusName).Id;
            }
        }

        //При загрузке по-умолчанию открываются только входящие собщения
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (MailsAppContext db = new MailsAppContext())
            {
                Models.User user = db.Users.First(u => u.Id == _mailbox.IdUser);
                this.Text = $"MailsApp | {user.Firstname} {user.Lastname} | {_mailbox.MailName} | Письма";
                labelUser.Text = $"{user.Firstname} {user.Lastname}";
            }
            LabelIncoming_Click(labelIncoming, e);
        }

        //Метод отрисовывает сообщения и размещает их на panelMassages
        public void DrawLetters(Letter[] letters)
        {
            panelMessages.Controls.Clear();
            int itemCount = 0;

            foreach (Letter letter in letters)
            {
                string theme;
                if (letter.Theme != null)
                    theme = letter.Theme;
                else
                    theme = "Без темы";

                LetterItem item = new LetterItem(letter.Id, letter.IsFavorite, theme, letter.Message, letter.Date)
                {
                    Location = Location = new Point(10, 10 + itemCount),
                    Width = panelMessages.Width - 30
                };
                item.LetterChanged += (sender, e) => {
                    RefreshList();
                };
                itemCount += 50;

                panelMessages.Controls.Add(item);
                this.CenterToScreen();
            }
        }
        private void ChangeLabelColor(Label label)
        {
            if (_selectedLabel != null)
            {
                _selectedLabel.BackColor = Color.Silver;
            }

            _selectedLabel = label;
            _selectedLabel.BackColor = SystemColors.ActiveCaption;
        }

        #region Методы для кнопок
        private void HandleLabelClickAllMails(int labelId)
        {
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter[] letters = db.Letters
                    .Where(l => l.IdCopyRecipient == _mailbox.Id &&
                        l.IdStatus != _idDeletedStatus &&
                        l.IdLabel == labelId)
                    .OrderByDescending(l => l.Date)
                    .ToArray();
                DrawLetters(letters);
            }
        }
        private void HandleLabelClickIncoming(int labelId)
        {
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter[] letters = db.Letters
                    .Where(l => l.IdMailboxRecipient == _mailbox.Id &&
                        l.IdCopyRecipient == _mailbox.Id &&
                        l.IdStatus != _idDeletedStatus &&
                        l.IdLabel == labelId)
                    .OrderByDescending(l => l.Date)
                    .ToArray();
                DrawLetters(letters);
            }
        }
        private void HandleLabelClickSended(int labelId)
        {
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter[] letters = db.Letters
                    .Where(l => l.IdMailboxSender == _mailbox.Id &&
                        l.IdCopyRecipient == _mailbox.Id &&
                        l.IdStatus != _idDeletedStatus &&
                        l.IdLabel == labelId)
                    .OrderByDescending(l => l.Date)
                    .ToArray();
                DrawLetters(letters);
            }
        }
        private void HandleLabelClickFavorite(int labelId)
        {
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter[] letters = db.Letters
                    .Where(l => l.IdCopyRecipient == _mailbox.Id &&
                        l.IsFavorite == true &&
                        l.IdStatus != _idDeletedStatus &&
                        l.IdLabel == labelId)
                    .OrderByDescending(l => l.Date)
                    .ToArray();
                DrawLetters(letters);
            }
        }
        #endregion

        #region Кнопки panelSidebar
        private void LabelAllMails_Click(object sender, EventArgs e)
        {
            panelLabels.Visible = true;
            ChangeLabelColor(sender as Label);
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter[] letters = db.Letters
                    .Where(l => l.IdCopyRecipient == _mailbox.Id && 
                        l.IdStatus != _idDeletedStatus)
                    .OrderByDescending(l => l.Date)
                    .ToArray();
                DrawLetters(letters);

                if (_promoHandler != null) buttonLabelPromo.Click -= _promoHandler;
                if (_notificationHandler != null) buttonLabelNotification.Click -= _notificationHandler;
                if (_workHandler != null) buttonLabelWork.Click -= _workHandler;

                _promoHandler = (sender, e) => HandleLabelClickAllMails(_idLabelPromo);
                _notificationHandler = (sender, e) => HandleLabelClickAllMails(_idLabelNotification);
                _workHandler = (sender, e) => HandleLabelClickAllMails(_idLabelWork);

                buttonLabelPromo.Click += _promoHandler;
                buttonLabelNotification.Click += _notificationHandler;
                buttonLabelWork.Click += _workHandler;

                Models.User user = db.Users.First(u => u.Id == _mailbox.IdUser);
                this.Text = $"MailsApp | {user.Firstname} {user.Lastname} | {_mailbox.MailName} | Письма | Вся почта";
            }
        }
        private void LabelIncoming_Click(object sender, EventArgs e)
        {
            panelLabels.Visible = true;
            ChangeLabelColor(sender as Label);
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter[] letters = db.Letters
                    .Where(l => l.IdMailboxRecipient == _mailbox.Id && 
                        l.IdCopyRecipient == _mailbox.Id && 
                        l.IdStatus != _idDeletedStatus)
                    .OrderByDescending(l => l.Date)
                    .ToArray();
                DrawLetters(letters);

                if (_promoHandler != null) buttonLabelPromo.Click -= _promoHandler;
                if (_notificationHandler != null) buttonLabelNotification.Click -= _notificationHandler;
                if (_workHandler != null) buttonLabelWork.Click -= _workHandler;

                _promoHandler = (sender, e) => HandleLabelClickIncoming(_idLabelPromo);
                _notificationHandler = (sender, e) => HandleLabelClickIncoming(_idLabelNotification);
                _workHandler = (sender, e) => HandleLabelClickIncoming(_idLabelWork);

                buttonLabelPromo.Click += _promoHandler;
                buttonLabelNotification.Click += _notificationHandler;
                buttonLabelWork.Click += _workHandler;

                Models.User user = db.Users.First(u => u.Id == _mailbox.IdUser);
                this.Text = $"MailsApp | {user.Firstname} {user.Lastname} | {_mailbox.MailName} | Письма | Входящие";
            }
        }
        private void LabelSended_Click(object sender, EventArgs e)
        {
            panelLabels.Visible = true;
            ChangeLabelColor(sender as Label);
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter[] letters = db.Letters
                    .Where(l => l.IdMailboxSender == _mailbox.Id && 
                        l.IdCopyRecipient == _mailbox.Id && 
                        l.IdStatus != _idDeletedStatus)
                    .OrderByDescending(l => l.Date)
                    .ToArray();
                DrawLetters(letters);

                if (_promoHandler != null) buttonLabelPromo.Click -= _promoHandler;
                if (_notificationHandler != null) buttonLabelNotification.Click -= _notificationHandler;
                if (_workHandler != null) buttonLabelWork.Click -= _workHandler;

                _promoHandler = (sender, e) => HandleLabelClickSended(_idLabelPromo);
                _notificationHandler = (sender, e) => HandleLabelClickSended(_idLabelNotification);
                _workHandler = (sender, e) => HandleLabelClickSended(_idLabelWork);

                buttonLabelPromo.Click += _promoHandler;
                buttonLabelNotification.Click += _notificationHandler;
                buttonLabelWork.Click += _workHandler;

                Models.User user = db.Users.First(u => u.Id == _mailbox.IdUser);
                this.Text = $"MailsApp | {user.Firstname} {user.Lastname} | {_mailbox.MailName} | Письма | Отправленные";
            }
        }
        private void LabelFavorite_Click(object sender, EventArgs e)
        {
            panelLabels.Visible = true;
            ChangeLabelColor(sender as Label);
            using (MailsAppContext db = new MailsAppContext())
            { 
                Letter[] letters = db.Letters
                    .Where(l => l.IdCopyRecipient == _mailbox.Id && 
                        l.IsFavorite == true && 
                        l.IdStatus != _idDeletedStatus)
                    .OrderByDescending(l => l.Date)
                    .ToArray();
                DrawLetters(letters);

                if (_promoHandler != null) buttonLabelPromo.Click -= _promoHandler;
                if (_notificationHandler != null) buttonLabelNotification.Click -= _notificationHandler;
                if (_workHandler != null) buttonLabelWork.Click -= _workHandler;

                _promoHandler = (sender, e) => HandleLabelClickFavorite(_idLabelPromo);
                _notificationHandler = (sender, e) => HandleLabelClickFavorite(_idLabelNotification);
                _workHandler = (sender, e) => HandleLabelClickFavorite(_idLabelWork);

                buttonLabelPromo.Click += _promoHandler;
                buttonLabelNotification.Click += _notificationHandler;
                buttonLabelWork.Click += _workHandler;

                Models.User user = db.Users.First(u => u.Id == _mailbox.IdUser);
                this.Text = $"MailsApp | {user.Firstname} {user.Lastname} | {_mailbox.MailName} | Письма | Избранные";
            }
        }
        private void LabelDraft_Click(object sender, EventArgs e)
        {
            panelLabels.Visible = true;
            ChangeLabelColor(sender as Label);
            using (MailsAppContext db = new MailsAppContext())
            {
                int statusId = db.Statuses.First(s => s.StatusName == "draft").Id;
                Letter[] letters = db.Letters
                    .Where(l => l.IdCopyRecipient == _mailbox.Id && 
                        l.IdStatus == statusId)
                    .OrderByDescending(l => l.Date)
                    .ToArray();
                DrawLetters(letters);

                panelLabels.Visible = false;

                Models.User user = db.Users.First(u => u.Id == _mailbox.IdUser);
                this.Text = $"MailsApp | {user.Firstname} {user.Lastname} | {_mailbox.MailName} | Письма | Черновик";
            }
        }
        private void LabelGarbage_Click(object sender, EventArgs e)
        {
            panelLabels.Visible = false; //Подсматривая на Gmail заметил, что эта панель там отсутствует
            ChangeLabelColor(sender as Label);
            using (MailsAppContext db = new MailsAppContext())
            {
                int idDeletedStatus = db.Statuses.First(s => s.StatusName == _deletedStatusName).Id;
                Letter[] letters = db.Letters
                    .Where(l => l.IdCopyRecipient == _mailbox.Id && 
                        l.IdStatus == _idDeletedStatus)
                    .OrderByDescending(l => l.Date)
                    .ToArray();
                DrawLetters(letters);

                panelLabels.Visible = false;

                Models.User user = db.Users.First(u => u.Id == _mailbox.IdUser);
                this.Text = $"MailsApp | {user.Firstname} {user.Lastname} | {_mailbox.MailName} | Письма | Корзина";
            }
        }
        #endregion

        #region ToolStripMenu events
        private void ChangeMailboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMailboxes form = new FormMailboxes(_mailbox.IdUser);
            this.Visible = false;
            form.ShowDialog();
            this.Close();
        }
        private void LeaveAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuthorization form = new FormAuthorization();
            this.Visible = false;
            form.ShowDialog();
            this.Close();
        }
        private void ChangeUserSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserSettings form = new FormUserSettings(_mailbox.IdUser);
            form.ShowDialog();
            using (MailsAppContext db = new MailsAppContext())
            {
                Models.User user = db.Users.First(u => u.Id == _mailbox.IdUser);
                labelUser.Text = $"{user.Firstname} {user.Lastname}";
            }

        }
        #endregion

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string pattern = textBoxSearch.Text.Trim();
            if (pattern == string.Empty)
                return;

            using (MailsAppContext db = new MailsAppContext())
            {
                string regPattern = $"%{pattern}%";
                Letter[] letters = db.Letters
                    .Where(l => (EF.Functions.ILike(l.Theme, regPattern) && l.IdCopyRecipient == _mailbox.Id) ||
                               (EF.Functions.ILike(l.Message, regPattern) && l.IdCopyRecipient == _mailbox.Id))
                    .OrderByDescending(l => l.Id)
                    .ToArray();
                DrawLetters(letters);
            }
        }
        private void buttonMakeLetter_Click(object sender, EventArgs e)
        {
            FormMakeLetter form = new FormMakeLetter(_mailbox.Id);
            form.ShowDialog();
        }
        private void RefreshList()
        {
            switch (_selectedLabel.Name) //Обновляем информацию
            {
                case "LabelAllMails":
                    LabelAllMails_Click(labelAllMails, EventArgs.Empty);
                    break;
                case "LabelIncoming":
                    LabelIncoming_Click(labelIncoming, EventArgs.Empty);
                    break;
                case "LabelSended":
                    LabelSended_Click(labelSended, EventArgs.Empty);
                    break;
                case "LabelFavorite":
                    LabelFavorite_Click(labelFavorite, EventArgs.Empty);
                    break;
                case "LabelDraft":
                    LabelDraft_Click(labelDraft, EventArgs.Empty);
                    break;
                case "LabelGarbage":
                    LabelGarbage_Click(labelGarbage, EventArgs.Empty);
                    break;
                default:
                    LabelIncoming_Click(labelIncoming, EventArgs.Empty);
                    break;
            }
        }
    }
}
