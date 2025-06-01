namespace MailsApp.Forms._3_Letters_Operations
{
    partial class FormReadLetter
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
            buttonResponce = new Button();
            buttonDelete = new Button();
            panelTheme = new Panel();
            labelTheme = new Label();
            panelUser = new Panel();
            panelMessage = new Panel();
            textBoxMessage = new TextBox();
            flowPanelAttachments = new FlowLayoutPanel();
            panelAction.SuspendLayout();
            panelTheme.SuspendLayout();
            panelMessage.SuspendLayout();
            SuspendLayout();
            // 
            // panelAction
            // 
            panelAction.BackColor = Color.White;
            panelAction.BorderStyle = BorderStyle.FixedSingle;
            panelAction.Controls.Add(flowPanelAttachments);
            panelAction.Controls.Add(buttonResponce);
            panelAction.Controls.Add(buttonDelete);
            panelAction.Dock = DockStyle.Top;
            panelAction.Location = new Point(0, 0);
            panelAction.Name = "panelAction";
            panelAction.Size = new Size(800, 47);
            panelAction.TabIndex = 0;
            // 
            // buttonResponce
            // 
            buttonResponce.Font = new Font("Arial", 9.75F);
            buttonResponce.Location = new Point(93, 12);
            buttonResponce.Name = "buttonResponce";
            buttonResponce.Size = new Size(75, 23);
            buttonResponce.TabIndex = 2;
            buttonResponce.Text = "Ответить";
            buttonResponce.UseVisualStyleBackColor = true;
            buttonResponce.Click += buttonResponce_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Arial", 9.75F);
            buttonDelete.Location = new Point(12, 12);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panelTheme
            // 
            panelTheme.BorderStyle = BorderStyle.FixedSingle;
            panelTheme.Controls.Add(labelTheme);
            panelTheme.Dock = DockStyle.Top;
            panelTheme.Location = new Point(0, 47);
            panelTheme.Name = "panelTheme";
            panelTheme.Padding = new Padding(10);
            panelTheme.Size = new Size(800, 47);
            panelTheme.TabIndex = 1;
            // 
            // labelTheme
            // 
            labelTheme.Dock = DockStyle.Fill;
            labelTheme.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTheme.Location = new Point(10, 10);
            labelTheme.Name = "labelTheme";
            labelTheme.Size = new Size(778, 25);
            labelTheme.TabIndex = 0;
            labelTheme.Text = "Тема письма";
            labelTheme.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelUser
            // 
            panelUser.BorderStyle = BorderStyle.FixedSingle;
            panelUser.Dock = DockStyle.Top;
            panelUser.Location = new Point(0, 94);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(800, 50);
            panelUser.TabIndex = 2;
            // 
            // panelMessage
            // 
            panelMessage.BorderStyle = BorderStyle.FixedSingle;
            panelMessage.Controls.Add(textBoxMessage);
            panelMessage.Dock = DockStyle.Fill;
            panelMessage.Location = new Point(0, 144);
            panelMessage.Name = "panelMessage";
            panelMessage.Padding = new Padding(10);
            panelMessage.Size = new Size(800, 306);
            panelMessage.TabIndex = 3;
            // 
            // textBoxMessage
            // 
            textBoxMessage.BorderStyle = BorderStyle.None;
            textBoxMessage.Dock = DockStyle.Fill;
            textBoxMessage.Location = new Point(10, 10);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(778, 284);
            textBoxMessage.TabIndex = 0;
            // 
            // flowPanelAttachments
            // 
            flowPanelAttachments.Location = new Point(174, 3);
            flowPanelAttachments.Name = "flowPanelAttachments";
            flowPanelAttachments.Size = new Size(555, 40);
            flowPanelAttachments.TabIndex = 3;
            flowPanelAttachments.WrapContents = false;
            // 
            // FormReadLetter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMessage);
            Controls.Add(panelUser);
            Controls.Add(panelTheme);
            Controls.Add(panelAction);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormReadLetter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReadLetter";
            panelAction.ResumeLayout(false);
            panelTheme.ResumeLayout(false);
            panelMessage.ResumeLayout(false);
            panelMessage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAction;
        private Panel panelTheme;
        private Panel panelUser;
        private Panel panelMessage;
        private Button buttonResponce;
        private Button buttonDelete;
        private Label labelTheme;
        private TextBox textBoxMessage;
        private FlowLayoutPanel flowPanelAttachments;
    }
}