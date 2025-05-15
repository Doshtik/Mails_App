using Microsoft.VisualBasic;
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
    public partial class UserItem : UserControl
    {
        public event EventHandler OnEntrancePressed;
        public event EventHandler OnClearPressed;

        private string _phoneNumber;
        private string _password;

        public UserItem(string firstName, string lastName, string phoneNumber, string password)
        {
            InitializeComponent();

            labelFirstname.Text = firstName;
            labelLastname.Text = lastName;

            _phoneNumber = phoneNumber;
            _password = password;
        }

        private void buttonEntrance_Click(object sender, EventArgs e)
        {
            string? password = Interaction.InputBox("Введите пароль для подтверждения", "Подтверждение");
            if (password.Length > 0)
            {
                if (password.Trim().Equals(_password))
                    OnEntrancePressed?.Invoke(this, EventArgs.Empty);
                else
                    MessageBox.Show("Неверное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
            (
                "Вы уверены что хотите убрать пользователя из быстрого входа?" +
                "\nПользователь не будет удалён", 
                "Подтверждение", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                OnClearPressed?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
