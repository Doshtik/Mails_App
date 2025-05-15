using MailsApp.Models;

namespace MailsApp.Forms
{
    partial class MailboxItem
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
            labelMailboxName = new Label();
            SuspendLayout();
            // 
            // labelMailboxName
            // 
            labelMailboxName.BackColor = Color.Transparent;
            labelMailboxName.Dock = DockStyle.Fill;
            labelMailboxName.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMailboxName.Location = new Point(0, 0);
            labelMailboxName.Margin = new Padding(5);
            labelMailboxName.Name = "labelMailboxName";
            labelMailboxName.Size = new Size(600, 45);
            labelMailboxName.TabIndex = 0;
            labelMailboxName.Text = "Почтовый адрес";
            labelMailboxName.TextAlign = ContentAlignment.MiddleLeft;
            labelMailboxName.Click += LabelMailboxName_Click;
            // 
            // MailboxItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelMailboxName);
            Margin = new Padding(0);
            Name = "MailboxItem";
            Size = new Size(600, 45);
            Click += MailBoxItem_Click;
            ResumeLayout(false);
        }

        #endregion
        private Label labelLastname;
        private Label labelMailboxName;
    }
}