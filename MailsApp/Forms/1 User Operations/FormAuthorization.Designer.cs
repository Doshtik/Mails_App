using MailsApp.Models;

namespace MailsApp.Forms
{
    partial class FormAuthorization
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
            labelAutorization = new Label();
            phoneNumberTB = new TextBox();
            buttonConfirm = new Button();
            passwordTB = new TextBox();
            linkRegistration = new LinkLabel();
            labelNoAccount = new Label();
            panelAuthorization = new Panel();
            panelUserItems = new Panel();
            panelAuthorization.SuspendLayout();
            SuspendLayout();
            // 
            // labelAutorization
            // 
            labelAutorization.AutoSize = true;
            labelAutorization.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAutorization.Location = new Point(87, 42);
            labelAutorization.Margin = new Padding(4, 0, 4, 0);
            labelAutorization.Name = "labelAutorization";
            labelAutorization.Size = new Size(178, 36);
            labelAutorization.TabIndex = 0;
            labelAutorization.Text = "Авторизация";
            labelAutorization.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneNumberTB
            // 
            phoneNumberTB.Location = new Point(49, 81);
            phoneNumberTB.Name = "phoneNumberTB";
            phoneNumberTB.PlaceholderText = "Номер телефона";
            phoneNumberTB.Size = new Size(250, 31);
            phoneNumberTB.TabIndex = 1;
            phoneNumberTB.Click += phoneNumberTB_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(49, 155);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(250, 34);
            buttonConfirm.TabIndex = 3;
            buttonConfirm.Text = "Подтвердить";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(49, 118);
            passwordTB.Name = "passwordTB";
            passwordTB.PlaceholderText = "Пароль";
            passwordTB.Size = new Size(250, 31);
            passwordTB.TabIndex = 2;
            // 
            // linkRegistration
            // 
            linkRegistration.AutoSize = true;
            linkRegistration.Location = new Point(577, 430);
            linkRegistration.Name = "linkRegistration";
            linkRegistration.Size = new Size(130, 23);
            linkRegistration.TabIndex = 3;
            linkRegistration.TabStop = true;
            linkRegistration.Text = "Создать новый";
            linkRegistration.LinkClicked += LinkRegistration_LinkClicked;
            // 
            // labelNoAccount
            // 
            labelNoAccount.AutoSize = true;
            labelNoAccount.Location = new Point(457, 430);
            labelNoAccount.Name = "labelNoAccount";
            labelNoAccount.Size = new Size(122, 23);
            labelNoAccount.TabIndex = 4;
            labelNoAccount.Text = "Нет аккаунта?";
            // 
            // panelAuthorization
            // 
            panelAuthorization.BackColor = SystemColors.Control;
            panelAuthorization.BorderStyle = BorderStyle.FixedSingle;
            panelAuthorization.Controls.Add(buttonConfirm);
            panelAuthorization.Controls.Add(passwordTB);
            panelAuthorization.Controls.Add(labelAutorization);
            panelAuthorization.Controls.Add(phoneNumberTB);
            panelAuthorization.Location = new Point(394, 206);
            panelAuthorization.Name = "panelAuthorization";
            panelAuthorization.Size = new Size(378, 221);
            panelAuthorization.TabIndex = 2;
            // 
            // panelUserItems
            // 
            panelUserItems.BackColor = SystemColors.Control;
            panelUserItems.BorderStyle = BorderStyle.FixedSingle;
            panelUserItems.Location = new Point(394, 84);
            panelUserItems.Name = "panelUserItems";
            panelUserItems.Size = new Size(378, 116);
            panelUserItems.TabIndex = 5;
            panelUserItems.Visible = false;
            // 
            // FormAuthorization
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1142, 690);
            Controls.Add(panelUserItems);
            Controls.Add(labelNoAccount);
            Controls.Add(linkRegistration);
            Controls.Add(panelAuthorization);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAuthorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MailsApp | Авторизация";
            panelAuthorization.ResumeLayout(false);
            panelAuthorization.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAutorization;
        private TextBox phoneNumberTB;
        private Button buttonConfirm;
        private TextBox passwordTB;
        private LinkLabel linkRegistration;
        private Label labelNoAccount;
        private Panel panelAuthorization;
        private Panel panelUserItems;
    }
}