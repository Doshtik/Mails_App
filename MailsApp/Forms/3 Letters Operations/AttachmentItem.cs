using MailsApp.Models;

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
        public AttachmentItem(Attachment attachment)
        {
            InitializeComponent();
            FileName = attachment.FileName;
            buttonDeleteAttach.Visible = false;
            labelFileName.Enabled = false;
        }

        private void ButtonDeleteAttach_Click(object sender, EventArgs e)
        {
            Deleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
