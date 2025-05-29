using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailsApp.Models;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;

namespace MailsApp.Forms
{
    public partial class FormAuthorization : Form
    {
        private Models.User _user;

        public FormAuthorization()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!File.Exists("config.txt"))
            {
                Program.CreateConfigFile();
                return;
            }

            string password = Program.GetValueFromConfigFile<string>("password");
            string phoneNumber = Program.GetValueFromConfigFile<string>("phone_number");

            using (MailsAppContext db = new MailsAppContext())
            {
                Models.User? user = db.Users
                    .Where(u => u.PhoneNumber.Equals(phoneNumber) && u.Password.Equals(password))
                    .FirstOrDefault();
                if (user != null)
                {
                    _user = user;
                    UserItem userItem = new UserItem(user.Firstname, user.Lastname, phoneNumber, password);
                    userItem.OnEntrancePressed += (sender, e) => NextTo();
                    userItem.OnClearPressed += (sender, e) =>
                    {
                        Program.SetValueToConfigFile<string>("phone_number", "");
                        Program.SetValueToConfigFile<string>("password", "");
                        panelUserItems.Controls.Clear();
                        panelUserItems.Visible = false;
                    };
                    panelUserItems.Controls.Add(userItem);
                    panelUserItems.Visible = true;
                }
            }

            base.OnLoad(e);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string password = passwordTB.Text.Trim();
            string phoneNumber = phoneNumberTB.Text.Trim();

            if (password.Length == 0 || phoneNumber.Length == 0)
            {
                MessageBox.Show( "Вы оставили поле не заполненным",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MailsAppContext db = new MailsAppContext())
            {
                Models.User? user = db.Users
                    .Where(u => u.PhoneNumber.Equals(phoneNumber) && u.Password.Equals(password))
                    .FirstOrDefault();

                if (user != null)
                {
                    _user = user;
                    Program.SetValueToConfigFile<string>("phone_number", user.PhoneNumber);
                    Program.SetValueToConfigFile<string>("password", user.Password);
                    NextTo();
                }
            }
        }

        private void NextTo()
        {
            FormMailboxes form = new FormMailboxes(_user.Id);
            this.Visible = false;
            form.ShowDialog();
            this.Close();
        }

        private void LinkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistration form = new FormRegistration();
            this.Visible = false;
            form.ShowDialog();
            this.OnLoad(new EventArgs());
            this.Visible = true;
        }

        private void phoneNumberTB_Click(object sender, EventArgs e)
        {
            if (phoneNumberTB.Text.Trim().Length == 0)
            {
                phoneNumberTB.Text = "+7";
                phoneNumberTB.SelectionStart = 3;
            }
        }
    }
}
