namespace MailsApp.Forms
{
    partial class FormMakeMailbox
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
            buttonMakeMailbox = new Button();
            textBoxMailbox = new TextBox();
            labelMakeMailbox = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonMakeMailbox);
            panel1.Controls.Add(textBoxMailbox);
            panel1.Location = new Point(261, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 88);
            panel1.TabIndex = 0;
            // 
            // buttonMakeMailbox
            // 
            buttonMakeMailbox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMakeMailbox.Location = new Point(37, 48);
            buttonMakeMailbox.Name = "buttonMakeMailbox";
            buttonMakeMailbox.Size = new Size(219, 23);
            buttonMakeMailbox.TabIndex = 1;
            buttonMakeMailbox.Text = "Создать";
            buttonMakeMailbox.UseVisualStyleBackColor = true;
            buttonMakeMailbox.Click += buttonMakeMailbox_Click;
            // 
            // textBoxMailbox
            // 
            textBoxMailbox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxMailbox.Location = new Point(37, 19);
            textBoxMailbox.Name = "textBoxMailbox";
            textBoxMailbox.PlaceholderText = "example@mail.com";
            textBoxMailbox.Size = new Size(219, 22);
            textBoxMailbox.TabIndex = 0;
            // 
            // labelMakeMailbox
            // 
            labelMakeMailbox.AutoSize = true;
            labelMakeMailbox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMakeMailbox.Location = new Point(298, 149);
            labelMakeMailbox.Name = "labelMakeMailbox";
            labelMakeMailbox.Size = new Size(219, 22);
            labelMakeMailbox.TabIndex = 1;
            labelMakeMailbox.Text = "Создать почтовый ящик";
            labelMakeMailbox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMakeMailbox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMakeMailbox);
            Controls.Add(panel1);
            Name = "FormMakeMailbox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMakeMailbox";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelMakeMailbox;
        private Button buttonMakeMailbox;
        private TextBox textBoxMailbox;
    }
}