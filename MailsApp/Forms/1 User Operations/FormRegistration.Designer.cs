using MailsApp.Models;

namespace MailsApp.Forms
{
    partial class FormRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lastnameTB = new TextBox();
            firstnameTB = new TextBox();
            buttonConfirm = new Button();
            passwordTB = new TextBox();
            labelRegistration = new Label();
            phoneNumberTB = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lastnameTB);
            panel1.Controls.Add(firstnameTB);
            panel1.Controls.Add(buttonConfirm);
            panel1.Controls.Add(passwordTB);
            panel1.Controls.Add(labelRegistration);
            panel1.Controls.Add(phoneNumberTB);
            panel1.Location = new Point(396, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 292);
            panel1.TabIndex = 3;
            // 
            // lastnameTB
            // 
            lastnameTB.Location = new Point(66, 122);
            lastnameTB.Name = "lastnameTB";
            lastnameTB.PlaceholderText = "Фамилия";
            lastnameTB.Size = new Size(250, 31);
            lastnameTB.TabIndex = 2;
            // 
            // firstnameTB
            // 
            firstnameTB.Location = new Point(66, 85);
            firstnameTB.Name = "firstnameTB";
            firstnameTB.PlaceholderText = "Имя";
            firstnameTB.Size = new Size(250, 31);
            firstnameTB.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(66, 233);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(250, 34);
            buttonConfirm.TabIndex = 5;
            buttonConfirm.Text = "Подтвердить";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(66, 196);
            passwordTB.Name = "passwordTB";
            passwordTB.PlaceholderText = "Пароль";
            passwordTB.Size = new Size(250, 31);
            passwordTB.TabIndex = 4;
            // 
            // labelRegistration
            // 
            labelRegistration.AutoSize = true;
            labelRegistration.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRegistration.Location = new Point(104, 46);
            labelRegistration.Margin = new Padding(4, 0, 4, 0);
            labelRegistration.Name = "labelRegistration";
            labelRegistration.Size = new Size(170, 36);
            labelRegistration.TabIndex = 0;
            labelRegistration.Text = "Регистрация";
            labelRegistration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneNumberTB
            // 
            phoneNumberTB.Location = new Point(66, 159);
            phoneNumberTB.Name = "phoneNumberTB";
            phoneNumberTB.PlaceholderText = "Номер телефона";
            phoneNumberTB.Size = new Size(250, 31);
            phoneNumberTB.TabIndex = 3;
            phoneNumberTB.Click += PhoneNumberTB_Click;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 690);
            Controls.Add(panel1);
            Font = new Font("Calibri", 14.25F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MailsApp | Регистрация";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox lastnameTB;
        private TextBox firstnameTB;
        private Button buttonConfirm;
        private TextBox passwordTB;
        private Label labelRegistration;
        private TextBox phoneNumberTB;
    }
}