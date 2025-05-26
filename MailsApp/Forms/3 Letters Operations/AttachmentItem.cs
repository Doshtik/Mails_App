using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailsApp.Forms._3_Letters_Operations
{
    public partial class AttachmentItem : UserControl
    {
        public EventHandler Deleted;
        public string FileName 
        { 
            get => labelFileName.Text; 
            private set => labelFileName.Text = value; 
        }
        public AttachmentItem(string fileName)
        {
            InitializeComponent();
            FileName = fileName;
        }

        private void ButtonDeleteAttach_Click(object sender, EventArgs e)
        {
            Deleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
