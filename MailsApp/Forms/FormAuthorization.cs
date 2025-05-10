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

namespace MailsApp.Forms
{
    public partial class FormAuthorization : Form
    {
        private User _user;

        public FormAuthorization()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!File.Exists("config.txt"))
            {
                Program.CreateConfigFile();
            }
            else
            {
                string password = Program.GetValueFromConfigFile<string>("password");
                string phoneNumber = Program.GetValueFromConfigFile<string>("phone_number");
                using (Models.AppContext db = new Models.AppContext())
                {
                    User? user = db.Users
                        .Where(u => u.PhoneNumber.Equals(phoneNumber) && u.Password.Equals(password))
                        .FirstOrDefault();
                    if (user != null)
                    {
                        _user = user;
                        MakeAccountCard();
                    }
                }
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string password = passwordTB.Text.Trim();
            string phoneNumber = phoneNumberTB.Text.Trim();
            if (password.Length == 0 || phoneNumber.Length == 0)
            {
                MessageBox.Show(
                    "Вы оставили поле не заполненным",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                using (Models.AppContext db = new Models.AppContext())
                {
                    User? user = db.Users
                        .Where(u => u.PhoneNumber.Equals(phoneNumber) && u.Password.Equals(password))
                        .FirstOrDefault();
                    if (user != null)
                    {
                        Program.SetValueToConfigFile<string>("phone_number", user.PhoneNumber);
                        Program.SetValueToConfigFile<string>("password", user.Password);
                        NextTo();
                    }
                }
            }
        }
        private void NextTo()
        {
            FormMailboxes form = new FormMailboxes(_user);
            this.Visible = false;
            form.ShowDialog();
            this.Close();
        }

        private void MakeAccountCard()
        {
            Panel panelAccount = new Panel();
            Label labelFastEntrance = new Label();
            Label labelAccountName = new Label();
            Button buttonEntrance = new Button();

            labelFastEntrance.Location = new Point(408, 111);
            labelFastEntrance.Name = "labelFastEntrance";
            labelFastEntrance.Size = new Size(350, 23);
            labelFastEntrance.TabIndex = 5;
            labelFastEntrance.Text = "Быстрый вход";
            labelFastEntrance.TextAlign = ContentAlignment.MiddleCenter;

            labelAccountName.Font = new Font("Calibri", 16F);
            labelAccountName.Location = new Point(3, 3);
            labelAccountName.Name = "labelAccountName";
            labelAccountName.Size = new Size(214, 57);
            labelAccountName.TabIndex = 6;
            labelAccountName.Text = $"{_user.Lastname} {_user.Firstname}";
            labelAccountName.TextAlign = ContentAlignment.MiddleLeft;

            buttonEntrance.Font = new Font("Calibri", 20F);
            buttonEntrance.Location = new Point(223, 3);
            buttonEntrance.Name = "buttonEntrance";
            buttonEntrance.Size = new Size(124, 57);
            buttonEntrance.TabIndex = 7;
            buttonEntrance.Text = "Войти";
            buttonEntrance.UseVisualStyleBackColor = true;
            buttonEntrance.Click += ButtonEntrance_Click;

            panelAccount.BackColor = Color.White;
            panelAccount.Controls.Add(labelAccountName);
            panelAccount.Controls.Add(buttonEntrance);
            panelAccount.Location = new Point(408, 137);
            panelAccount.Name = "panelAccount";
            panelAccount.Size = new Size(350, 63);
            panelAccount.TabIndex = 8;

            panelAccount.Controls.Add(buttonEntrance);
            panelAccount.Controls.Add(buttonEntrance);

            this.Controls.Add(panelAccount);
            this.Controls.Add(labelFastEntrance);
        }

        private void ButtonEntrance_Click(object? sender, EventArgs e)
        {
            string? password = Interaction.InputBox("Введите пароль для подтверждения", "Подтверждение");
            if (password.Length > 0)
            {
                if (password.Trim() == _user.Password)
                    NextTo();
                else
                    MessageBox.Show("Неверное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LinkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistration form = new FormRegistration();
            this.Visible = false;
            form.ShowDialog();
            this.OnLoad(new EventArgs());
            this.Visible = true;
        }
    }
}
