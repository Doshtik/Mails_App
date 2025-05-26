namespace MailsApp.Forms
{
    partial class FormMakeLetter
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
            panelRecipient = new Panel();
            textBoxRecipient = new TextBox();
            buttonCopy = new Button();
            panelAction = new Panel();
            buttonAttach = new Button();
            buttonSend = new Button();
            panelTheme = new Panel();
            textBoxTheme = new TextBox();
            panelMassage = new Panel();
            textBoxMassage = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            flowPanelAttachments = new FlowLayoutPanel();
            panelRecipient.SuspendLayout();
            panelAction.SuspendLayout();
            panelTheme.SuspendLayout();
            panelMassage.SuspendLayout();
            SuspendLayout();
            // 
            // panelRecipient
            // 
            panelRecipient.BackColor = Color.White;
            panelRecipient.BorderStyle = BorderStyle.FixedSingle;
            panelRecipient.Controls.Add(textBoxRecipient);
            panelRecipient.Controls.Add(buttonCopy);
            panelRecipient.Dock = DockStyle.Top;
            panelRecipient.Location = new Point(0, 0);
            panelRecipient.Name = "panelRecipient";
            panelRecipient.Size = new Size(800, 50);
            panelRecipient.TabIndex = 0;
            // 
            // textBoxRecipient
            // 
            textBoxRecipient.Location = new Point(3, 15);
            textBoxRecipient.Name = "textBoxRecipient";
            textBoxRecipient.PlaceholderText = "Кому:";
            textBoxRecipient.Size = new Size(703, 23);
            textBoxRecipient.TabIndex = 3;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(712, 14);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(75, 23);
            buttonCopy.TabIndex = 1;
            buttonCopy.Text = "Копия";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // panelAction
            // 
            panelAction.BackColor = Color.White;
            panelAction.BorderStyle = BorderStyle.FixedSingle;
            panelAction.Controls.Add(flowPanelAttachments);
            panelAction.Controls.Add(buttonAttach);
            panelAction.Controls.Add(buttonSend);
            panelAction.Dock = DockStyle.Bottom;
            panelAction.Location = new Point(0, 400);
            panelAction.Name = "panelAction";
            panelAction.Size = new Size(800, 50);
            panelAction.TabIndex = 1;
            // 
            // buttonAttach
            // 
            buttonAttach.Location = new Point(125, 5);
            buttonAttach.Name = "buttonAttach";
            buttonAttach.Size = new Size(101, 40);
            buttonAttach.TabIndex = 1;
            buttonAttach.Text = "Прикрепить";
            buttonAttach.UseVisualStyleBackColor = true;
            buttonAttach.Click += buttonAttach_Click;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(11, 5);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(108, 40);
            buttonSend.TabIndex = 0;
            buttonSend.Text = "Отправить";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // panelTheme
            // 
            panelTheme.BackColor = Color.White;
            panelTheme.BorderStyle = BorderStyle.FixedSingle;
            panelTheme.Controls.Add(textBoxTheme);
            panelTheme.Dock = DockStyle.Top;
            panelTheme.Location = new Point(0, 50);
            panelTheme.Name = "panelTheme";
            panelTheme.Size = new Size(800, 50);
            panelTheme.TabIndex = 2;
            // 
            // textBoxTheme
            // 
            textBoxTheme.Location = new Point(3, 14);
            textBoxTheme.Name = "textBoxTheme";
            textBoxTheme.PlaceholderText = "Тема:";
            textBoxTheme.Size = new Size(588, 23);
            textBoxTheme.TabIndex = 4;
            // 
            // panelMassage
            // 
            panelMassage.BorderStyle = BorderStyle.FixedSingle;
            panelMassage.Controls.Add(textBoxMassage);
            panelMassage.Dock = DockStyle.Fill;
            panelMassage.Location = new Point(0, 100);
            panelMassage.Name = "panelMassage";
            panelMassage.Size = new Size(800, 300);
            panelMassage.TabIndex = 3;
            // 
            // textBoxMassage
            // 
            textBoxMassage.BackColor = Color.White;
            textBoxMassage.Dock = DockStyle.Fill;
            textBoxMassage.Location = new Point(0, 0);
            textBoxMassage.Multiline = true;
            textBoxMassage.Name = "textBoxMassage";
            textBoxMassage.PlaceholderText = "Сообщение:";
            textBoxMassage.Size = new Size(798, 298);
            textBoxMassage.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            // 
            // flowPanelAttachments
            // 
            flowPanelAttachments.Location = new Point(232, 5);
            flowPanelAttachments.Name = "flowPanelAttachments";
            flowPanelAttachments.Size = new Size(555, 40);
            flowPanelAttachments.TabIndex = 2;
            flowPanelAttachments.WrapContents = false;
            // 
            // FormMakeLetter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMassage);
            Controls.Add(panelTheme);
            Controls.Add(panelAction);
            Controls.Add(panelRecipient);
            Name = "FormMakeLetter";
            Text = "FormMakeLetter";
            panelRecipient.ResumeLayout(false);
            panelRecipient.PerformLayout();
            panelAction.ResumeLayout(false);
            panelTheme.ResumeLayout(false);
            panelTheme.PerformLayout();
            panelMassage.ResumeLayout(false);
            panelMassage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRecipient;
        private Panel panelAction;
        private Panel panelTheme;
        private Panel panelMassage;
        private Button buttonSend;
        private Button buttonAttach;
        private Button buttonCopy;
        private TextBox textBoxMassage;
        private TextBox textBoxRecipient;
        private TextBox textBoxTheme;
        private OpenFileDialog openFileDialog1;
        private FlowLayoutPanel flowPanelAttachments;
    }
}