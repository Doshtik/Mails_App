using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailsApp.Forms._1_User_Operations
{
    public partial class FormUserSettings : Form
    {
        private Models.User _user;
        public FormUserSettings(int userId)
        {
            InitializeComponent();
            using (MailsAppContext db = new MailsAppContext())
            {
                _user = db.Users.First(u => u.Id == userId);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Text = $"MailsApp | {_user.Firstname} {_user.Lastname} | Настройки учётной записи";
            textBoxFirstname.Text = _user.Firstname;
            textBoxLastname.Text = _user.Lastname;
            textBoxPhoneNumber.Text = _user.PhoneNumber;
            textBoxPassword.Text = _user.Password;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text.Trim();
            string phoneNumber = textBoxPhoneNumber.Text.Trim();
            if (phoneNumber.Length == 0)
            {
                MessageBox.Show("Номер телефона не может быть пустым", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length == 0)
            {
                MessageBox.Show("Пароль не может быть пустым", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MailsAppContext db = new MailsAppContext())
            {
                Models.User? user = db.Users.FirstOrDefault(u => u.PhoneNumber.Equals(phoneNumber));

                if (user != null && user.Id != _user.Id) 
                {
                    MessageBox.Show("Номер телефона не может использоваться, " +
                        "поскольку уже зарегестрирован на другом аккаунте", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Models.User userToUpdate = db.Users.FirstOrDefault(u => u.Id == _user.Id);
                userToUpdate.Firstname = textBoxFirstname.Text.Trim();
                userToUpdate.Lastname = textBoxLastname.Text.Trim();
                userToUpdate.PhoneNumber = phoneNumber;
                userToUpdate.Password = password;
                db.SaveChanges();

                MessageBox.Show("Данные об учётной записи успешно обновленны", 
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Program.SetValueToConfigFile<string>("phone_number", phoneNumber);
                Program.SetValueToConfigFile<string>("password", password);
            }
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPhoneNumber.Text.Trim().Length == 0)
            {
                textBoxPhoneNumber.Text = "+7";
                textBoxPhoneNumber.SelectionStart = 3;
            }
        }
    }
}
