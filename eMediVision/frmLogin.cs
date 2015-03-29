using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediVision
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                var confirmResult = MessageBox.Show("Are you sure to Exit ??",
                        "Confirm Exit!!",
                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                 
                Application.Exit();
            }
            
            }

            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var confirmResult = MessageBox.Show("Are you sure to Exit ??",
                        "Confirm Exit!!",
                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    Application.Exit();
                }

            }
            if (e.KeyCode == Keys.Enter)
            {
                textBox2_KeyDown(sender, e);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var confirmResult = MessageBox.Show("Are you sure to Exit ??",
                        "Confirm Exit!!",
                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    Application.Exit();
                }

            }

            else if (e.KeyCode==Keys.Enter)
            {
                // Validate User here

                if (string.IsNullOrEmpty(txtUsername.Text) )
                {
                    MessageBox.Show("Please Enter UserName");
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please Enter Password");
                    return;
                }

                if (txtUsername.Text=="admin" && txtPassword.Text=="admin" )
                {
                    //MessageBox.Show("Login Authenticated.....");
                    frmMainScreen fms = new frmMainScreen();
                    fms.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Incorrect Login Details...");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                    
                }

            }

            
        }
    }
}
