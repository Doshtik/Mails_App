using MailsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailsApp.Forms
{
    public partial class FormMakeMailbox : Form
    {
        private int _userId;
        public FormMakeMailbox(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void buttonMakeMailbox_Click(object sender, EventArgs e)
        {
            string regstr = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(regstr);
            string mbName = textBoxMailbox.Text.Trim();

            if (!regex.Match(mbName).Success)
            {
                MessageBox.Show("Введённый почтовый ящик не подходит",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MailsAppContext db = new MailsAppContext())
            {
                Mailbox mailbox = db.Mailboxes.First(mb => mb.MailName.Equals(mbName));
                if (mailbox == null)
                {
                    MessageBox.Show("Данный почтовый ящик уже существует. Придумайте другое название",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                mailbox = new Mailbox()
                {
                    IdUser = _userId,
                    MailName = mbName
                };
                db.Mailboxes.Add(mailbox);
                db.SaveChanges();

                MessageBox.Show("Почтовый ящик успешно создан", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
