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
            radioButtonFavorite = new RadioButton();
            labelMessage = new Label();
            labelTime = new Label();
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
            // radioButtonFavorite
            // 
            radioButtonFavorite.CheckAlign = ContentAlignment.MiddleCenter;
            radioButtonFavorite.Location = new Point(44, 4);
            radioButtonFavorite.Name = "radioButtonFavorite";
            radioButtonFavorite.Size = new Size(29, 30);
            radioButtonFavorite.TabIndex = 3;
            radioButtonFavorite.TabStop = true;
            radioButtonFavorite.TextAlign = ContentAlignment.TopCenter;
            radioButtonFavorite.UseVisualStyleBackColor = true;
            // 
            // labelMessage
            // 
            labelMessage.Location = new Point(211, 4);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(351, 30);
            labelMessage.TabIndex = 4;
            labelMessage.Text = "Содержимое сообщения";
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            labelMessage.Click += LabelMessage_Click;
            // 
            // labelTime
            // 
            labelTime.Location = new Point(568, 4);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(60, 30);
            labelTime.TabIndex = 5;
            labelTime.Text = "13 апр.";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LetterItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTime);
            Controls.Add(labelMessage);
            Controls.Add(radioButtonFavorite);
            Controls.Add(labelTheme);
            Controls.Add(checkBoxSelected);
            Name = "LetterItem";
            Size = new Size(628, 40);
            SizeChanged += LetterItem_SizeChanged;
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBoxSelected;
        private Label labelTheme;
        private RadioButton radioButtonFavorite;
        private Label labelMessage;
        private Label labelTime;
    }
}
