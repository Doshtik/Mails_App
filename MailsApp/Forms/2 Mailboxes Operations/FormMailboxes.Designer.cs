namespace MailsApp
{
    partial class FormMailboxes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelActions = new Panel();
            buttonDelete = new Button();
            buttonSelect = new Button();
            panelItems = new Panel();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // panelActions
            // 
            panelActions.Controls.Add(buttonDelete);
            panelActions.Controls.Add(buttonSelect);
            panelActions.Dock = DockStyle.Top;
            panelActions.Location = new Point(0, 0);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(10);
            panelActions.Size = new Size(549, 49);
            panelActions.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(282, 13);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(254, 37);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(12, 12);
            buttonSelect.Margin = new Padding(10);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(257, 37);
            buttonSelect.TabIndex = 0;
            buttonSelect.Text = "Выбрать";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // panelItems
            // 
            panelItems.Dock = DockStyle.Fill;
            panelItems.Location = new Point(0, 49);
            panelItems.Name = "panelItems";
            panelItems.Padding = new Padding(10);
            panelItems.Size = new Size(549, 402);
            panelItems.TabIndex = 1;
            // 
            // FormMailboxes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 451);
            Controls.Add(panelItems);
            Controls.Add(panelActions);
            MinimumSize = new Size(565, 300);
            Name = "FormMailboxes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MailsApp | Почтовые ящики";
            SizeChanged += FormMailboxes_SizeChanged;
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelActions;
        private Panel panelItems;
        private Button buttonSelect;
        private Button buttonDelete;
    }
}
