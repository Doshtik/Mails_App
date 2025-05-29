namespace MailsApp.Forms._3_Letters_Operations
{
    partial class LetterUserItem
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
            labelSenderName = new Label();
            labelSenderMailbox = new Label();
            labelRecipientMailbox = new Label();
            checkBoxIsFavorite = new CheckBox();
            labelDateTime = new Label();
            SuspendLayout();
            // 
            // labelSenderName
            // 
            labelSenderName.AutoSize = true;
            labelSenderName.Dock = DockStyle.Left;
            labelSenderName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSenderName.Location = new Point(10, 10);
            labelSenderName.Name = "labelSenderName";
            labelSenderName.Size = new Size(106, 18);
            labelSenderName.TabIndex = 0;
            labelSenderName.Text = "Иван Иванов";
            // 
            // labelSenderMailbox
            // 
            labelSenderMailbox.AutoSize = true;
            labelSenderMailbox.Dock = DockStyle.Left;
            labelSenderMailbox.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSenderMailbox.Location = new Point(116, 10);
            labelSenderMailbox.Name = "labelSenderMailbox";
            labelSenderMailbox.Size = new Size(126, 14);
            labelSenderMailbox.TabIndex = 1;
            labelSenderMailbox.Text = "<ivan.ivanov@mail.com>";
            // 
            // labelRecipientMailbox
            // 
            labelRecipientMailbox.AutoSize = true;
            labelRecipientMailbox.Location = new Point(13, 28);
            labelRecipientMailbox.Name = "labelRecipientMailbox";
            labelRecipientMailbox.Size = new Size(187, 15);
            labelRecipientMailbox.TabIndex = 2;
            labelRecipientMailbox.Text = "Кому: <oleg.mongol@mail.com>";
            // 
            // checkBoxIsFavorite
            // 
            checkBoxIsFavorite.AutoSize = true;
            checkBoxIsFavorite.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxIsFavorite.Dock = DockStyle.Right;
            checkBoxIsFavorite.Location = new Point(695, 10);
            checkBoxIsFavorite.Name = "checkBoxIsFavorite";
            checkBoxIsFavorite.Size = new Size(95, 30);
            checkBoxIsFavorite.TabIndex = 3;
            checkBoxIsFavorite.Text = "В избранное";
            checkBoxIsFavorite.UseVisualStyleBackColor = true;
            // 
            // labelDateTime
            // 
            labelDateTime.Dock = DockStyle.Right;
            labelDateTime.Location = new Point(574, 10);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(121, 30);
            labelDateTime.TabIndex = 4;
            labelDateTime.Text = "01.01.2005 15:35";
            labelDateTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LetterUserItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelDateTime);
            Controls.Add(checkBoxIsFavorite);
            Controls.Add(labelRecipientMailbox);
            Controls.Add(labelSenderMailbox);
            Controls.Add(labelSenderName);
            Name = "LetterUserItem";
            Padding = new Padding(10);
            Size = new Size(800, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSenderName;
        private Label labelSenderMailbox;
        private Label labelRecipientMailbox;
        private CheckBox checkBoxIsFavorite;
        private Label labelDateTime;
    }
}
