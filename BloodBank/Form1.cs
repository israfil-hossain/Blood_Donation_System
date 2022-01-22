using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(btnHideShow.Text == "Show")
            {
                btnHideShow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnHideShow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }    

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked == true)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "bloodheart" && txtPassword.Text == "pass")
            {
                Dashboard db =new Dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter valid Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
