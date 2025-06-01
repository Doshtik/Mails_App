namespace MailsApp.Forms._3_Letters_Operations
{
    partial class AttachmentItem
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDeleteAttach = new Button();
            labelFileName = new Label();
            SuspendLayout();
            // 
            // buttonDeleteAttach
            // 
            buttonDeleteAttach.Location = new Point(94, 3);
            buttonDeleteAttach.Name = "buttonDeleteAttach";
            buttonDeleteAttach.Size = new Size(25, 25);
            buttonDeleteAttach.TabIndex = 0;
            buttonDeleteAttach.Text = "x";
            buttonDeleteAttach.UseVisualStyleBackColor = true;
            buttonDeleteAttach.Click += ButtonDeleteAttach_Click;
            // 
            // labelFileName
            // 
            labelFileName.BackColor = Color.Transparent;
            labelFileName.ForeColor = Color.Black;
            labelFileName.Location = new Point(3, 3);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(85, 25);
            labelFileName.TabIndex = 1;
            labelFileName.Text = "Coffee.jpg";
            labelFileName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AttachmentItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelFileName);
            Controls.Add(buttonDeleteAttach);
            Name = "AttachmentItem";
            Size = new Size(118, 35);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDeleteAttach;
        private Label labelFileName;
    }
}
