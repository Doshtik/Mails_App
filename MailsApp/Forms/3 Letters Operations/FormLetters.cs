using MailsApp.Forms._3_Letters_Operations;
using MailsApp.Models;
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
        public FormLetters(int id)
        {
            InitializeComponent();
            using (MailsAppContext db = new MailsAppContext())
            {
                _mailbox = db.Mailboxes.First(mb => mb.Id == id);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LabelIncoming_Click(this, e);
        }

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

                LetterItem item = new LetterItem(letter.IsFavorite, theme, letter.Message, letter.Date)
                {
                    Location = Location = new Point(10, 10 + itemCount),
                    Width = panelMessages.Width - 20
                };
                itemCount += 50;
                panelMessages.Controls.Add(item);
            }
        }

        private void LabelAllMails_Click(object sender, EventArgs e)
        {
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter[] letters = db.Letters
                    .Where(l => l.IdCopyRecipient == _mailbox.IdUser)
                    .ToArray();
                DrawLetters(letters);
            }
        }

        private void LabelIncoming_Click(object sender, EventArgs e)
        {
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter[] letters = db.Letters
                    .Where(l => l.IdMailboxRecipient == _mailbox.IdUser && l.IdCopyRecipient == _mailbox.IdUser)
                    .ToArray();
                DrawLetters(letters);
            }
        }

        private void LabelSended_Click(object sender, EventArgs e)
        {
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter[] letters = db.Letters
                    .Where(l => l.IdMailboxSender == _mailbox.IdUser && l.IdCopyRecipient == _mailbox.IdUser)
                    .ToArray();
                DrawLetters(letters);
            }
        }

        private void LabelFavorite_Click(object sender, EventArgs e)
        {
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter[] letters = db.Letters
                    .Where(l => l.IsFavorite == true && l.IdCopyRecipient == _mailbox.IdUser)
                    .ToArray();
                DrawLetters(letters);
            }
        }

        private void LabelDraft_Click(object sender, EventArgs e)
        {
            using (MailsAppContext db = new MailsAppContext())
            {
                int statusId = db.Statuses.First(s => s.StatusName == "draft").Id;
                Letter[] letters = db.Letters
                    .Where(l => l.IdStatus == statusId && l.IdCopyRecipient == _mailbox.IdUser)
                    .ToArray();
                DrawLetters(letters);
            }
        }

        private void LabelGarbage_Click(object sender, EventArgs e)
        {
            using (MailsAppContext db = new MailsAppContext())
            {
                int statusId = db.Statuses.First(s => s.StatusName == "deleted").Id;
                Letter[] letters = db.Letters
                    .Where(l => l.IdStatus == statusId && l.IdCopyRecipient == _mailbox.IdUser)
                    .ToArray();
                DrawLetters(letters);
            }
        }

        private void buttonMakeLetter_Click(object sender, EventArgs e)
        {
            FormMakeLetter form = new FormMakeLetter();
            form.ShowDialog();
        }
    }
}
