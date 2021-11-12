using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace News
{
    public partial class AddNewsForm : Form
    {
        DbConnect dbConnect = new DbConnect();
        public AddNewsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(title.Text != "" && desc.Text != "")
            {
                News news = new News(title.Text, desc.Text, DateTime.Now.ToString());
                dbConnect.AddNews(news);
                MessageBox.Show("News add secssfuly");
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Title and description cant be emphte");
            }
            

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
