using MailsApp.Forms;
using MailsApp.Models;

namespace MailsApp
{
    public partial class FormMailboxes : Form
    {
        private User _user;
        public MailboxItem? _selectedItem;

        public FormMailboxes(int userId)
        {
            InitializeComponent();
            using (MailsAppContext db = new MailsAppContext())
            {
                _user = db.Users.First(u => u.Id == userId);
                this.Text = $"MailsApp | {_user.Firstname} {_user.Lastname} | �������� �����";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadMailboxes();
        }

        //����� ������������ �������� ����� � ��������� �� �� panelItems.
        //� � ����� ��������� ������ �������� ��������� �����
        private void LoadMailboxes()
        {
            panelItems.Controls.Clear();
            int itemCount = 0;

            using (MailsAppContext db = new MailsAppContext())
            {
                Mailbox[] mailboxes = db.Mailboxes.Where(u => u.IdUser == _user.Id).ToArray();

                foreach (var mailbox in mailboxes)
                {
                    MailboxItem item = new MailboxItem(mailbox.Id, mailbox.MailName)
                    {
                        Location = new Point(10, 10 + itemCount),
                        Width = panelItems.Width - 20
                    };
                    itemCount += 55;

                    item.ItemSelected += (sender, e) =>
                    {
                        if (_selectedItem != null)
                        {
                            _selectedItem.BackColor = Color.White;
                        }

                        _selectedItem = item;
                        _selectedItem.BackColor = SystemColors.ActiveCaption;
                    };

                    panelItems.Controls.Add(item);
                }
            }

            Button buttonCreateMailbox = new Button()
            {
                Text = "������� ����� �������� ����",
                Location = new Point(10, 10 + itemCount),
                Height = 45,
                Width = panelItems.Width - 20
            };

            buttonCreateMailbox.Click += (sender, e) =>
            {
                FormMakeMailbox form = new FormMakeMailbox(_user.Id);
                form.ShowDialog();
                LoadMailboxes();
            };

            panelItems.Controls.Add(buttonCreateMailbox);
        }

        #region ������ ���������
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (_selectedItem != null)
            {
                FormLetters form = new FormLetters(_selectedItem.Id);
                this.Visible = false;
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("�� �� ������� �������� ����");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_selectedItem != null)
            {
                DialogResult result = MessageBox.Show
                (
                    "�� �������, ��� ������ ������� �������� ����?",
                    "�������������",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes)
                {
                    using (MailsAppContext db = new MailsAppContext())
                    {
                        Mailbox mailbox = db.Mailboxes.First(mb => mb.Id == _selectedItem.Id);
                        db.Mailboxes.Remove(mailbox);
                        db.SaveChanges();
                    }
                    LoadMailboxes();
                }
            }
            else
            {
                MessageBox.Show("�� �� ������� �������� ����");
            }
        }
#endregion

        //��������� ��������� �������� ������ �������������
        private void FormMailboxes_SizeChanged(object sender, EventArgs e)
        {
            foreach (var control in panelItems.Controls)
            {
                if (control is MailboxItem item)
                {
                    item.Width = panelItems.Width - 20;
                }
            }
        }
    }
}
