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

        public FormLetters(int idMailbox)
        {
            InitializeComponent();
            using (MailsAppContext db = new MailsAppContext())
            {
                _mailbox = db.Mailboxes.First(mb => mb.Id == idMailbox);
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

        #region Кнопки panelSidebar
        private void buttonMakeLetter_Click(object sender, EventArgs e)
        {
            FormMakeLetter form = new FormMakeLetter(_mailbox.Id);
            form.ShowDialog();

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

        private void LabelAllMails_Click(object sender, EventArgs e)
        {
            panelLabels.Visible = true;
            ChangeLabelColor(sender as Label);
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter[] letters = db.Letters
                    .Where(l => l.IdCopyRecipient == _mailbox.Id)
                    .ToArray();
                DrawLetters(letters);

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
                    .Where(l => l.IdMailboxRecipient == _mailbox.Id && l.IdCopyRecipient == _mailbox.Id)
                    .ToArray();
                DrawLetters(letters);

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
                    .Where(l => l.IdMailboxSender == _mailbox.Id && l.IdCopyRecipient == _mailbox.Id)
                    .ToArray();
                DrawLetters(letters);

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
                    .Where(l => l.IdCopyRecipient == _mailbox.Id && l.IsFavorite == true)
                    .ToArray();
                DrawLetters(letters);

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
                    .Where(l => l.IdCopyRecipient == _mailbox.Id && l.IdStatus == statusId)
                    .ToArray();
                DrawLetters(letters);

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
                int statusId = db.Statuses.First(s => s.StatusName == "deleted").Id;
                Letter[] letters = db.Letters
                    .Where(l => l.IdCopyRecipient == _mailbox.Id && l.IdStatus == statusId)
                    .ToArray();
                DrawLetters(letters);

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

        private void FormLetters_SizeChanged(object sender, EventArgs e)
        {
            if (panelMessages == null)
                return;

            foreach (Control control in panelMessages.Controls)
            {
                if (control is LetterItem)
                {
                    LetterItem item = (LetterItem)control;
                    item.LetterItem_SizeChanged(sender, e);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string pattern = textBoxSearch.Text.Trim();
            if (pattern == string.Empty)
                return;

            using (MailsAppContext db = new MailsAppContext())
            {
                string regPattern = $"%{pattern}%";
                Letter[] letters = db.Letters
                    .Where(l => EF.Functions.ILike(l.Theme, regPattern) ||
                               EF.Functions.ILike(l.Message, regPattern))
                    .ToArray();
                DrawLetters(letters);
            }
        }
    }
}
