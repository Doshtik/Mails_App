using MailsApp.Models;

namespace MailsApp.Forms
{
    partial class UserItem
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
            panelAction = new Panel();
            buttonDelete = new Button();
            buttonEntrance = new Button();
            panelInfo = new Panel();
            labelLastname = new Label();
            labelFirstname = new Label();
            panelAction.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelAction
            // 
            panelAction.Controls.Add(buttonDelete);
            panelAction.Controls.Add(buttonEntrance);
            panelAction.Dock = DockStyle.Fill;
            panelAction.Location = new Point(0, 72);
            panelAction.Name = "panelAction";
            panelAction.Padding = new Padding(5);
            panelAction.Size = new Size(378, 44);
            panelAction.TabIndex = 3;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Left;
            buttonDelete.Font = new Font("Arial", 12F);
            buttonDelete.Location = new Point(195, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(175, 34);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Выйти";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEntrance
            // 
            buttonEntrance.Dock = DockStyle.Left;
            buttonEntrance.Font = new Font("Arial", 12F);
            buttonEntrance.Location = new Point(5, 5);
            buttonEntrance.Name = "buttonEntrance";
            buttonEntrance.Size = new Size(190, 34);
            buttonEntrance.TabIndex = 0;
            buttonEntrance.Text = "Быстрый вход";
            buttonEntrance.UseVisualStyleBackColor = true;
            buttonEntrance.Click += buttonEntrance_Click;
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(labelLastname);
            panelInfo.Controls.Add(labelFirstname);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Padding = new Padding(5);
            panelInfo.Size = new Size(378, 72);
            panelInfo.TabIndex = 2;
            // 
            // labelLastname
            // 
            labelLastname.AutoSize = true;
            labelLastname.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLastname.Location = new Point(14, 41);
            labelLastname.Margin = new Padding(0);
            labelLastname.Name = "labelLastname";
            labelLastname.Size = new Size(87, 22);
            labelLastname.TabIndex = 1;
            labelLastname.Text = "Фамилия";
            // 
            // labelFirstname
            // 
            labelFirstname.AutoSize = true;
            labelFirstname.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFirstname.Location = new Point(14, 14);
            labelFirstname.Margin = new Padding(5);
            labelFirstname.Name = "labelFirstname";
            labelFirstname.Size = new Size(47, 22);
            labelFirstname.TabIndex = 0;
            labelFirstname.Text = "Имя";
            // 
            // UserItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelAction);
            Controls.Add(panelInfo);
            Name = "UserItem";
            Size = new Size(378, 116);
            panelAction.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAction;
        private Button buttonDelete;
        private Button buttonEntrance;
        private Panel panelInfo;
        private Label labelLastname;
        private Label labelFirstname;
    }
}