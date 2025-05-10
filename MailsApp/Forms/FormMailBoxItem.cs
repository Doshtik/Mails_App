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
    public partial class FormMailBoxItem : Form
    {
        public FormMailBoxItem()
        {
            InitializeComponent();
        }

        private void buttonEntrance_Click(object sender, EventArgs e)
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
    }
}
