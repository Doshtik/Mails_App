namespace MailsApp.Forms
{
    partial class FormMailBoxItem
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
            panelAction = new Panel();
            labelFirstname = new Label();
            labelLastname = new Label();
            buttonEntrance = new Button();
            buttonDelete = new Button();
            panelInfo.SuspendLayout();
            panelAction.SuspendLayout();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(labelLastname);
            panelInfo.Controls.Add(labelFirstname);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Padding = new Padding(5);
            panelInfo.Size = new Size(378, 68);
            panelInfo.TabIndex = 0;
            // 
            // panelAction
            // 
            panelAction.Controls.Add(buttonDelete);
            panelAction.Controls.Add(buttonEntrance);
            panelAction.Dock = DockStyle.Fill;
            panelAction.Location = new Point(0, 68);
            panelAction.Name = "panelAction";
            panelAction.Padding = new Padding(5);
            panelAction.Size = new Size(378, 41);
            panelAction.TabIndex = 1;
            // 
            // labelFirstname
            // 
            labelFirstname.AutoSize = true;
            labelFirstname.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFirstname.Location = new Point(12, 9);
            labelFirstname.Margin = new Padding(5);
            labelFirstname.Name = "labelFirstname";
            labelFirstname.Size = new Size(47, 22);
            labelFirstname.TabIndex = 0;
            labelFirstname.Text = "Имя";
            // 
            // labelLastname
            // 
            labelLastname.AutoSize = true;
            labelLastname.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLastname.Location = new Point(12, 36);
            labelLastname.Margin = new Padding(0);
            labelLastname.Name = "labelLastname";
            labelLastname.Size = new Size(87, 22);
            labelLastname.TabIndex = 1;
            labelLastname.Text = "Фамилия";
            // 
            // buttonEntrance
            // 
            buttonEntrance.Dock = DockStyle.Left;
            buttonEntrance.Font = new Font("Arial", 12F);
            buttonEntrance.Location = new Point(5, 5);
            buttonEntrance.Name = "buttonEntrance";
            buttonEntrance.Size = new Size(190, 31);
            buttonEntrance.TabIndex = 0;
            buttonEntrance.Text = "Быстрый вход";
            buttonEntrance.UseVisualStyleBackColor = true;
            buttonEntrance.Click += buttonEntrance_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Left;
            buttonDelete.Font = new Font("Arial", 12F);
            buttonDelete.Location = new Point(195, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(175, 31);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Выйти";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // FormMailBoxItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 109);
            Controls.Add(panelAction);
            Controls.Add(panelInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMailBoxItem";
            Text = "FormMailBoxItem";
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelAction.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private Panel panelAction;
        private Label labelLastname;
        private Label labelFirstname;
        private Button buttonDelete;
        private Button buttonEntrance;
    }
}