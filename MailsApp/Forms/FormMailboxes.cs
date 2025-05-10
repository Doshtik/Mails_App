using MailsApp.Models;

namespace MailsApp
{
    public partial class FormMailboxes : Form
    {
        private User _user;

        public FormMailboxes(User user)
        {
            InitializeComponent();
            _user = user;
            this.Text = $"MailsApp | {_user.Firstname} {_user.Lastname} | Почтовые ящики";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            using (Models.AppContext db = new Models.AppContext())
            {
                Mailbox[] mailboxes = db.Mailboxes.Where(u => u.IdUser == _user.Id).ToArray();
                //MessageBox.Show($"{mailboxes.Length}");
                if (mailboxes.Length > 0)
                {
                    foreach (var mailbox in mailboxes)
                    {

                    }
                }
                else
                {

                }
            }
        }
    }
}
