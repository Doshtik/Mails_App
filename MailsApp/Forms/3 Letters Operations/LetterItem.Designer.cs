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
            checkBoxSelected = new CheckBox();
            labelTheme = new Label();
            labelMessage = new Label();
            labelTime = new Label();
            checkBoxFavorite = new CheckBox();
            SuspendLayout();
            // 
            // checkBoxSelected
            // 
            checkBoxSelected.CheckAlign = ContentAlignment.MiddleCenter;
            checkBoxSelected.Location = new Point(0, 4);
            checkBoxSelected.Name = "checkBoxSelected";
            checkBoxSelected.Size = new Size(41, 30);
            checkBoxSelected.TabIndex = 0;
            checkBoxSelected.UseVisualStyleBackColor = true;
            // 
            // labelTheme
            // 
            labelTheme.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTheme.Location = new Point(79, 4);
            labelTheme.Name = "labelTheme";
            labelTheme.Size = new Size(126, 30);
            labelTheme.TabIndex = 1;
            labelTheme.Text = "Тема сообщения";
            labelTheme.TextAlign = ContentAlignment.MiddleLeft;
            labelTheme.Click += LabelTheme_Click;
            // 
            // labelMessage
            // 
            labelMessage.Location = new Point(211, 4);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(282, 30);
            labelMessage.TabIndex = 4;
            labelMessage.Text = "Содержимое сообщения";
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            labelMessage.Click += LabelMessage_Click;
            // 
            // labelTime
            // 
            labelTime.Location = new Point(499, 4);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(73, 30);
            labelTime.TabIndex = 5;
            labelTime.Text = "13 апр.";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxFavorite
            // 
            checkBoxFavorite.CheckAlign = ContentAlignment.MiddleCenter;
            checkBoxFavorite.Location = new Point(39, 4);
            checkBoxFavorite.Name = "checkBoxFavorite";
            checkBoxFavorite.Size = new Size(34, 30);
            checkBoxFavorite.TabIndex = 6;
            checkBoxFavorite.UseVisualStyleBackColor = true;
            // 
            // LetterItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Silver;
            Controls.Add(checkBoxFavorite);
            Controls.Add(labelTime);
            Controls.Add(labelMessage);
            Controls.Add(labelTheme);
            Controls.Add(checkBoxSelected);
            Name = "LetterItem";
            Size = new Size(578, 40);
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBoxSelected;
        private Label labelTheme;
        private Label labelMessage;
        private Label labelTime;
        private CheckBox checkBoxFavorite;
    }
}
