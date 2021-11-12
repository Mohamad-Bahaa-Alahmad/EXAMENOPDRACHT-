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
    public partial class FirstForm : Form
    {
        public static FirstForm instance;
        DbConnect dbConnect = new DbConnect();
       public Boolean check = false;
        

        public FirstForm()
        {
            InitializeComponent();
            instance = this;
            
        }

        public void FirstForm_Load(object sender, EventArgs e)
        {
            if (check)
            {
                login.Hide();
                register.Hide();
            }
            List<News> list = dbConnect.getAllNews();
            int x = 20;
            int y = 100;
            foreach (News item in list)
            {
                RichTextBox textBox = new RichTextBox();
                Label label = new Label();
                label.Text = item.Title;
                label.Location = new Point(x, y);
                Button button = new Button();
                button.Text = "Delete";
                button.BackColor = Color.Red;
                button.Click += (s, v) => {
                    dbConnect.deleteNews(item.Title , item.dateTime);
                    MessageBox.Show("News deleted successfully ");
                    
                  this.Refresh();
                };
                if (check == false)
                {
                    button.Visible = false;
                }
                
                x = this.Width - 100;

                button.Location = new Point(x, y);
                x = 20;
                y += 30;
                
                textBox.Text = item.Text + "\r\n" + "\r\n" + "published at " + item.dateTime;
                
                textBox.Enabled = false;
                textBox.Width = this.Width - 45;
                textBox.Height = this.Height / 3;
                textBox.Location = new Point(x, y);

                y += 150;
                this.Controls.Add(label);
                this.Controls.Add(textBox);
                this.Controls.Add(button);
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            LoginForm loginForm= new LoginForm();
            
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                check = true;
                logout.Show();
                addnews.Show();
                this.FirstForm_Load(sender,e);
                
            }
            
        }

        private void register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm= new RegisterForm();
            
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                check = true;
                logout.Show();
                addnews.Show();
                this.FirstForm_Load(sender, e);

            }
        }

        private void logout_Click(object sender, EventArgs e)
        {

            FirstForm firstForm = new FirstForm();
            firstForm.MdiParent = this.MdiParent;
            this.Close();
            firstForm.Show();
        }

        private void showsessies_Click(object sender, EventArgs e)
        {
            SessiesForm sessiesForm= new SessiesForm();

            
            this.Hide();
            if (sessiesForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();

            }
            else
            {
                this.Show();
            }

        }

        private void addnews_Click(object sender, EventArgs e)
        {
            AddNewsForm addNewsForm = new AddNewsForm();
            this.Hide();
            if (addNewsForm.ShowDialog() == DialogResult.OK)
            {
                this.FirstForm_Load(sender, e);
                this.Show();

            }
            else
            {
                this.Show();
            }

        }
    }
}
