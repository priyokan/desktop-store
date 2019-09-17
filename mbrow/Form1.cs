using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mbrow
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        bool err1 = true, err2 = true;

        private void Txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtusername.Text == "Username...")
            {
                txtusername.Text = "";                
            }
            panelUsername.BackColor = SystemColors.Highlight;
            txtusername.ForeColor = panelUsername.BackColor;
        }

        private void Txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "Username...";
                panelUsername.BackColor = panel4.BackColor;
                txtusername.ForeColor = panelUsername.BackColor;
            }
            else
            {
                panelUsername.BackColor = SystemColors.GrayText;
                txtusername.ForeColor = panelUsername.BackColor;
            }
        }

        private void Txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtpassword.Text == "Password...")
            {
                txtpassword.Text = "";
            }
            txtpassword.PasswordChar = '*';
            panelpassword.BackColor = SystemColors.Highlight;
            txtpassword.ForeColor = panelpassword.BackColor;
        }

        private void Txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.PasswordChar = char.Parse("\0");
                txtpassword.Text = "Password...";
                panelpassword.BackColor = panel4.BackColor;
                txtpassword.ForeColor = panelpassword.BackColor;
            }
            else
            {
                panelpassword.BackColor = SystemColors.GrayText;
                txtpassword.ForeColor = panelpassword.BackColor;
            }
        }

        private void Close_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Btnmasuk_Click(object sender, EventArgs e)
        {
            if(err1 == false && err2 == false)
            {

            }
        }
    }
}
