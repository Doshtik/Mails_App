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

namespace MailsApp.Forms._3_Letters_Operations
{
    public partial class LetterUserItem : UserControl
    {
        private int _letterId;
        private Letter _letter;
        public LetterUserItem(int letterId)
        {
            InitializeComponent();
            _letterId = letterId;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter letter = db.Letters.First(l => l.Id == _letterId);

                Mailbox mailboxSender = db.Mailboxes.First(mb => mb.Id == letter.IdMailboxSender);
                Mailbox mailboxRecipiemt = db.Mailboxes.First(mb => mb.Id == letter.IdMailboxRecipient);

                Models.User userSender = db.Users.First(u => u.Id == mailboxSender.IdUser);

                labelSenderName.Text = userSender.Firstname + " " + userSender.Lastname;
                labelSenderMailbox.Text = $"<{mailboxSender.MailName}>";
                labelRecipientMailbox.Text = $"Кому: <{mailboxRecipiemt.MailName}>";
                labelDateTime.Text = letter.Date.ToString();
            }
        }

        private void checkBoxIsFavorite_CheckedChanged(object sender, EventArgs e)
        {
            using (MailsAppContext db = new MailsAppContext())
            {
                Letter letter = db.Letters.First(l => l.Id == _letterId);
                letter.IsFavorite = checkBoxIsFavorite.Checked;
                db.SaveChanges();
            }
        }
    }
}
