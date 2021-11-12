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
    public partial class LoginForm : Form
    {
        DbConnect dbConnect = new DbConnect();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Boolean check = dbConnect.LogInConnect(email.Text, pass.Text);
            if (check == false)
            {
                
                MessageBox.Show("email or password not correct");
                DialogResult = DialogResult.None;



            }
            
            
            
            
            
        }
    }
}
