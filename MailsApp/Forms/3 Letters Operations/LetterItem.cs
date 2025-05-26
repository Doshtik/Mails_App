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
    public partial class LetterItem : UserControl
    {
        public int Id { get; private set; }
        public LetterItem(int id, bool isFavorite, string theme, string message, DateTime time)
        {
            InitializeComponent();
            Id = id;
            checkBoxFavorite.Checked = isFavorite;
            labelTheme.Text = theme;
            labelMessage.Text = message;
            labelTime.Text = time.ToString();
        }

        /*public void LetterItem_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width <= 500)
            {

            }
            else
            {
                labelMessage.Width = this.Width - checkBoxSelected.Width - checkBoxFavorite.Width - labelTheme.Width - labelTime.Width;
            }
        }*/

        private void LabelTheme_Click(object sender, EventArgs e)
        {
            LabelMessage_Click(sender, e);
        }

        private void LabelMessage_Click(object sender, EventArgs e)
        {
            FormReadLetter form = new FormReadLetter(Id);
            form.ShowDialog();
        }
    }
}
