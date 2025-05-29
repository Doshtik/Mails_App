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
    public partial class FormReadLetter : Form
    {
        private int _letterId;
        private Models.User _user;
        public FormReadLetter(int letterId)
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

            }
        }
    }
}
