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
    public partial class AddSessiesForm : Form
    {
        DbConnect dbConnect = new DbConnect();
        public AddSessiesForm()
        {
            InitializeComponent();
        }

        private void addsessies_Click(object sender, EventArgs e)
        {
            if (titlesessie.Text != "" && desc.Text != "" && speaker.Text != "" && dateTimePicker1.Value > DateTime.Now )
            {
                string s = dateTimePicker1.Value.ToString();
                Sessies sessies = new Sessies(titlesessie.Text, speaker.Text, desc.Text,  s);
                dbConnect.AddSessies(sessies);
                MessageBox.Show("Sessie add secssfuly");
                
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Title , description , speaker cant be emphte and date must be in the futcher");
            }
        }
    }
}
