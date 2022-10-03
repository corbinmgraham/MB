using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /* main ss = new main();
            ss.Show();
            this.Hide(); */
            //Account ac = new Account();
            if (Account.checkAccount(username.Text, password.Text) == false) MessageBox.Show("Incorrect Username/Password", "Login");
            else if (Account.checkAccount(username.Text, password.Text) == true) MessageBox.Show("Success", "Login");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            main ss = new main();
            ss.Show();
            this.Hide();
        }
    }
}
