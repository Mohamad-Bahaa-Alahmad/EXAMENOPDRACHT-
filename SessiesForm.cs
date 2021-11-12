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
    public partial class SessiesForm : Form
    {
        DbConnect dbConnect = new DbConnect();
        
        public SessiesForm()
        {
            InitializeComponent();
            
        }

        private void home_Click(object sender, EventArgs e)
        {
            

        }

        private void addsessies_Click(object sender, EventArgs e)
        {
            AddSessiesForm addSessiesForm= new AddSessiesForm();
            this.Hide();
            if(addSessiesForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                this.SessiesForm_Load(sender, e);
            }
            else
            {
                this.Show();
            }
        }

        private void SessiesForm_Load(object sender, EventArgs e)
        {
            Boolean check = FirstForm.instance.check;
            if (check )
            {
                addsessies.Visible = true;
            }
            List<Sessies> list = dbConnect.getAllSessies();
            int x = 20;
            int y = 100;
            foreach (Sessies item in list)
            {
                Button button = new Button();
                button.Text = "Delete";
                button.BackColor = Color.Red;
                button.Click += (s, v) => {
                    dbConnect.deleteSessies(item.Title, item.date);
                    MessageBox.Show("Sessie deleted successfully");
                    this.Close();
                    
                };
                if(check == false)
                {
                    button.Visible = false;
                }
                Label label = new Label();
                label.Text = item.Title;
                label.Location = new Point(x, y);
                x = this.Width - 100;

                button.Location = new Point(x, y);
                x = 20;
                y += 30;
                Label label1 = new Label();
                label1.Text = item.Speaker;
                label1.Location = new Point(x, y);

                y += 30;
                RichTextBox textBox = new RichTextBox();
                textBox.Text = item.Description + "\r\n" + "\r\n" + "Starts at " + item.date;

                textBox.Enabled = false;
                textBox.Width = this.Width - 60;
                textBox.AutoSize = true;
                textBox.Height = this.Height / 6;


                //textBox.Width = this.Width - 60;

                textBox.Location = new Point(x, y);

                y += 150;
                this.Controls.Add(label);
                this.Controls.Add(label1);
                this.Controls.Add(textBox);
                this.Controls.Add(button);


            }
        }
        
    }
}
