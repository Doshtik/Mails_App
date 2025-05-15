using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailsApp.Forms
{
    public partial class MailboxItem : UserControl
    {
        public event EventHandler ItemSelected;
        public int Id { get; private set; }
        public string MailboxName
        {
            get => labelMailboxName.Text;
            private set => labelMailboxName.Text = value;
        }

        public MailboxItem(int id, string mailboxName)
        {
            InitializeComponent();
            Id = id;
            MailboxName = mailboxName;
        }

        private void LabelMailboxName_Click(object sender, EventArgs e)
        {
            ItemSelected?.Invoke(this, EventArgs.Empty);
        }

        private void MailBoxItem_Click(object sender, EventArgs e)
        {
            ItemSelected?.Invoke(this, EventArgs.Empty);
        }
    }
}
