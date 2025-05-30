using MailsApp.Models;

namespace MailsApp.Forms._3_Letters_Operations
{
    partial class LetterItem
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
            labelTheme = new Label();
            labelMessage = new Label();
            labelTime = new Label();
            checkBoxFavorite = new CheckBox();
            SuspendLayout();
            // 
            // labelTheme
            // 
            labelTheme.BorderStyle = BorderStyle.FixedSingle;
            labelTheme.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTheme.Location = new Point(46, 0);
            labelTheme.Margin = new Padding(0);
            labelTheme.Name = "labelTheme";
            labelTheme.Size = new Size(159, 40);
            labelTheme.TabIndex = 1;
            labelTheme.Text = "Тема сообщения";
            labelTheme.TextAlign = ContentAlignment.MiddleLeft;
            labelTheme.Click += LabelTheme_Click;
            // 
            // labelMessage
            // 
            labelMessage.BorderStyle = BorderStyle.FixedSingle;
            labelMessage.Location = new Point(205, 0);
            labelMessage.Margin = new Padding(0);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(292, 40);
            labelMessage.TabIndex = 4;
            labelMessage.Text = "Содержимое сообщения";
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            labelMessage.Click += LabelMessage_Click;
            // 
            // labelTime
            // 
            labelTime.BorderStyle = BorderStyle.FixedSingle;
            labelTime.Location = new Point(497, 0);
            labelTime.Margin = new Padding(0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(81, 40);
            labelTime.TabIndex = 5;
            labelTime.Text = "13 апр.";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxFavorite
            // 
            checkBoxFavorite.CheckAlign = ContentAlignment.MiddleCenter;
            checkBoxFavorite.Location = new Point(0, 0);
            checkBoxFavorite.Name = "checkBoxFavorite";
            checkBoxFavorite.Size = new Size(43, 40);
            checkBoxFavorite.TabIndex = 6;
            checkBoxFavorite.UseVisualStyleBackColor = true;
            checkBoxFavorite.CheckedChanged += checkBoxFavorite_CheckedChanged;
            // 
            // LetterItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.Control;
            Controls.Add(checkBoxFavorite);
            Controls.Add(labelTime);
            Controls.Add(labelMessage);
            Controls.Add(labelTheme);
            Margin = new Padding(0);
            Name = "LetterItem";
            Size = new Size(578, 40);
            ResumeLayout(false);
        }

        #endregion
        private Label labelTheme;
        private Label labelMessage;
        private Label labelTime;
        private CheckBox checkBoxFavorite;
    }
}
