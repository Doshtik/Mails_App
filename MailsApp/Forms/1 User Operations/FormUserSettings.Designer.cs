namespace MailsApp.Forms._1_User_Operations
{
    partial class FormUserSettings
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
            panelInfo = new Panel();
            buttonSaveChanges = new Button();
            textBoxFirstname = new TextBox();
            textBoxPassword = new TextBox();
            textBoxLastname = new TextBox();
            labelPassword = new Label();
            labelPhoneNumber = new Label();
            labelLastname = new Label();
            labelFirstname = new Label();
            textBoxPhoneNumber = new TextBox();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.BackColor = SystemColors.Control;
            panelInfo.Controls.Add(buttonSaveChanges);
            panelInfo.Controls.Add(textBoxFirstname);
            panelInfo.Controls.Add(textBoxPassword);
            panelInfo.Controls.Add(textBoxLastname);
            panelInfo.Controls.Add(labelPassword);
            panelInfo.Controls.Add(labelPhoneNumber);
            panelInfo.Controls.Add(labelLastname);
            panelInfo.Controls.Add(labelFirstname);
            panelInfo.Controls.Add(textBoxPhoneNumber);
            panelInfo.Dock = DockStyle.Fill;
            panelInfo.Location = new Point(15, 15);
            panelInfo.Name = "panelInfo";
            panelInfo.Padding = new Padding(10);
            panelInfo.Size = new Size(503, 153);
            panelInfo.TabIndex = 0;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Dock = DockStyle.Bottom;
            buttonSaveChanges.Location = new Point(10, 120);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(483, 23);
            buttonSaveChanges.TabIndex = 8;
            buttonSaveChanges.Text = "Сохранить";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Location = new Point(138, 15);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.Size = new Size(203, 23);
            textBoxFirstname.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(138, 91);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(203, 23);
            textBoxPassword.TabIndex = 6;
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(138, 41);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(203, 23);
            textBoxLastname.TabIndex = 5;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(13, 91);
            labelPassword.Name = "labelPassword";
            labelPassword.Padding = new Padding(0, 0, 15, 10);
            labelPassword.Size = new Size(67, 25);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Пароль:";
            labelPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(13, 66);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Padding = new Padding(0, 0, 15, 10);
            labelPhoneNumber.Size = new Size(119, 25);
            labelPhoneNumber.TabIndex = 3;
            labelPhoneNumber.Text = "Номер телефона:";
            labelPhoneNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelLastname
            // 
            labelLastname.AutoSize = true;
            labelLastname.Location = new Point(10, 41);
            labelLastname.Name = "labelLastname";
            labelLastname.Padding = new Padding(0, 0, 15, 10);
            labelLastname.Size = new Size(76, 25);
            labelLastname.TabIndex = 2;
            labelLastname.Text = "Фамилия:";
            labelLastname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelFirstname
            // 
            labelFirstname.AutoSize = true;
            labelFirstname.Location = new Point(13, 10);
            labelFirstname.Name = "labelFirstname";
            labelFirstname.Padding = new Padding(0, 0, 15, 10);
            labelFirstname.Size = new Size(46, 31);
            labelFirstname.TabIndex = 1;
            labelFirstname.Text = "Имя:";
            labelFirstname.TextAlign = ContentAlignment.MiddleLeft;
            labelFirstname.UseCompatibleTextRendering = true;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(138, 66);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(203, 23);
            textBoxPhoneNumber.TabIndex = 0;
            textBoxPhoneNumber.TextChanged += textBoxPhoneNumber_TextChanged;
            // 
            // FormUserSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(533, 183);
            Controls.Add(panelInfo);
            MaximumSize = new Size(549, 222);
            MinimumSize = new Size(455, 222);
            Name = "FormUserSettings";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterParent;
            Text = "MailsApp";
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private TextBox textBoxFirstname;
        private TextBox textBoxPassword;
        private TextBox textBoxLastname;
        private Label labelPassword;
        private Label labelPhoneNumber;
        private Label labelLastname;
        private Label labelFirstname;
        private TextBox textBoxPhoneNumber;
        private Button buttonSaveChanges;
    }
}