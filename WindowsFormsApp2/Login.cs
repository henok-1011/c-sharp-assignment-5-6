using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "admin"&& txt_password.Text == "ADMIN")
            {
                Form1 Home = new Form1(txt_username.Text,this);
                Home.Show();
                this.Hide();
                txt_username.Text = "";
                txt_password.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}
