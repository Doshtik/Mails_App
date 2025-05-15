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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string phoneNumber = phoneNumberTB.Text.Trim();
            if (phoneNumber.Length != 12)
            {
                MessageBox.Show("Номер телефона указан неверно");
            }
            else
            {
                using (MailsAppContext db = new MailsAppContext())
                {
                    User? user = db.Users
                            .Where(u => u.PhoneNumber.Equals(phoneNumber))
                            .FirstOrDefault();
                    if (user != null)
                    {
                        MessageBox.Show
                        (
                            "Пользлватель с данным номером уже зарегестрирован." +
                            "\nПовторите попытку входа или используйте другой номер.",
                            "Внимание",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                    else
                    {
                        int id = db.Users.OrderByDescending(u => u.Id).Select(u => u.Id).FirstOrDefault() + 1;
                        User newUser = new User();
                        newUser.Id = id;
                        newUser.IdRole = 1;
                        newUser.Firstname = firstnameTB.Text.Trim();
                        newUser.Lastname = lastnameTB.Text.Trim();
                        newUser.PhoneNumber = phoneNumber;
                        newUser.Password = passwordTB.Text.Trim();
                        db.Users.Add(newUser);
                        db.SaveChanges();
                        Program.SetValueToConfigFile<string>("phone_number", newUser.PhoneNumber);
                        Program.SetValueToConfigFile<string>("password", newUser.Password);
                        MessageBox.Show("Пользователь успешно зарегестрирован. Вы можете закрыть окно и войти в свою учетную запись");
                    }
                }
            }
        }
                

        private void PhoneNumberTB_Click(object sender, EventArgs e)
        {
            if (phoneNumberTB.Text.Trim().Length == 0)
            {
                phoneNumberTB.Text = "+7";
                phoneNumberTB.SelectionStart = 3;
            }
        }
    }
}
