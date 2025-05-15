using MailsApp.Models;

namespace MailsApp.Forms
{
    partial class FormLetters
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
            panelTop = new Panel();
            panelSidebar = new Panel();
            labelGarbage = new Label();
            labelDraft = new Label();
            labelFavorite = new Label();
            labelSended = new Label();
            labelIncoming = new Label();
            labelAllMails = new Label();
            buttonMakeLetter = new Button();
            panelActions = new Panel();
            panelLabels = new Panel();
            panelMessages = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(800, 60);
            panelTop.TabIndex = 0;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.White;
            panelSidebar.BorderStyle = BorderStyle.FixedSingle;
            panelSidebar.Controls.Add(labelGarbage);
            panelSidebar.Controls.Add(labelDraft);
            panelSidebar.Controls.Add(labelFavorite);
            panelSidebar.Controls.Add(labelSended);
            panelSidebar.Controls.Add(labelIncoming);
            panelSidebar.Controls.Add(labelAllMails);
            panelSidebar.Controls.Add(buttonMakeLetter);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 60);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(10);
            panelSidebar.Size = new Size(200, 390);
            panelSidebar.TabIndex = 1;
            // 
            // labelGarbage
            // 
            labelGarbage.BackColor = Color.Silver;
            labelGarbage.Location = new Point(10, 252);
            labelGarbage.Margin = new Padding(10);
            labelGarbage.Name = "labelGarbage";
            labelGarbage.Size = new Size(180, 28);
            labelGarbage.TabIndex = 6;
            labelGarbage.Text = "Корзина";
            labelGarbage.TextAlign = ContentAlignment.MiddleCenter;
            labelGarbage.Click += LabelGarbage_Click;
            // 
            // labelDraft
            // 
            labelDraft.BackColor = Color.Silver;
            labelDraft.Location = new Point(10, 213);
            labelDraft.Margin = new Padding(10);
            labelDraft.Name = "labelDraft";
            labelDraft.Size = new Size(180, 28);
            labelDraft.TabIndex = 5;
            labelDraft.Text = "Черновик";
            labelDraft.TextAlign = ContentAlignment.MiddleCenter;
            labelDraft.Click += LabelDraft_Click;
            // 
            // labelFavorite
            // 
            labelFavorite.BackColor = Color.Silver;
            labelFavorite.Location = new Point(10, 174);
            labelFavorite.Margin = new Padding(10);
            labelFavorite.Name = "labelFavorite";
            labelFavorite.Size = new Size(180, 28);
            labelFavorite.TabIndex = 4;
            labelFavorite.Text = "Избранное";
            labelFavorite.TextAlign = ContentAlignment.MiddleCenter;
            labelFavorite.Click += LabelFavorite_Click;
            // 
            // labelSended
            // 
            labelSended.BackColor = Color.Silver;
            labelSended.Location = new Point(10, 136);
            labelSended.Margin = new Padding(10);
            labelSended.Name = "labelSended";
            labelSended.Size = new Size(180, 28);
            labelSended.TabIndex = 3;
            labelSended.Text = "Отправленные";
            labelSended.TextAlign = ContentAlignment.MiddleCenter;
            labelSended.Click += LabelSended_Click;
            // 
            // labelIncoming
            // 
            labelIncoming.BackColor = Color.Silver;
            labelIncoming.Location = new Point(10, 98);
            labelIncoming.Margin = new Padding(10);
            labelIncoming.Name = "labelIncoming";
            labelIncoming.Size = new Size(180, 28);
            labelIncoming.TabIndex = 2;
            labelIncoming.Text = "Входящие";
            labelIncoming.TextAlign = ContentAlignment.MiddleCenter;
            labelIncoming.Click += LabelIncoming_Click;
            // 
            // labelAllMails
            // 
            labelAllMails.BackColor = Color.Silver;
            labelAllMails.Location = new Point(10, 59);
            labelAllMails.Margin = new Padding(10);
            labelAllMails.Name = "labelAllMails";
            labelAllMails.Size = new Size(180, 28);
            labelAllMails.TabIndex = 1;
            labelAllMails.Text = "Вся почта";
            labelAllMails.TextAlign = ContentAlignment.MiddleCenter;
            labelAllMails.Click += LabelAllMails_Click;
            // 
            // buttonMakeLetter
            // 
            buttonMakeLetter.Dock = DockStyle.Top;
            buttonMakeLetter.Location = new Point(10, 10);
            buttonMakeLetter.Margin = new Padding(0);
            buttonMakeLetter.Name = "buttonMakeLetter";
            buttonMakeLetter.Size = new Size(178, 39);
            buttonMakeLetter.TabIndex = 0;
            buttonMakeLetter.Text = "Написать";
            buttonMakeLetter.UseVisualStyleBackColor = true;
            buttonMakeLetter.Click += buttonMakeLetter_Click;
            // 
            // panelActions
            // 
            panelActions.BackColor = Color.White;
            panelActions.BorderStyle = BorderStyle.FixedSingle;
            panelActions.Dock = DockStyle.Top;
            panelActions.Location = new Point(200, 60);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(600, 49);
            panelActions.TabIndex = 2;
            // 
            // panelLabels
            // 
            panelLabels.BackColor = Color.White;
            panelLabels.BorderStyle = BorderStyle.FixedSingle;
            panelLabels.Dock = DockStyle.Top;
            panelLabels.Location = new Point(200, 109);
            panelLabels.Name = "panelLabels";
            panelLabels.Size = new Size(600, 49);
            panelLabels.TabIndex = 3;
            // 
            // panelMessages
            // 
            panelMessages.BackColor = Color.White;
            panelMessages.BorderStyle = BorderStyle.FixedSingle;
            panelMessages.Dock = DockStyle.Fill;
            panelMessages.Location = new Point(200, 158);
            panelMessages.Name = "panelMessages";
            panelMessages.Padding = new Padding(5);
            panelMessages.Size = new Size(600, 292);
            panelMessages.TabIndex = 4;
            // 
            // FormLetters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMessages);
            Controls.Add(panelLabels);
            Controls.Add(panelActions);
            Controls.Add(panelSidebar);
            Controls.Add(panelTop);
            Name = "FormLetters";
            Text = "FormLetters";
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelSidebar;
        private Panel panelActions;
        private Panel panelLabels;
        private Panel panelMessages;
        private Button buttonMakeLetter;
        private Label labelAllMails;
        private Label labelIncoming;
        private Label labelGarbage;
        private Label labelDraft;
        private Label labelFavorite;
        private Label labelSended;
    }
}