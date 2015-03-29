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
    public partial class frmDisplay : Form
    {
        public frmDisplay()
        {
            InitializeComponent();
            btnAcctsRpts.Focus();
        }

        private void btnOutStanding_Click(object sender, EventArgs e)
        {
            //frmVoucherEntry fve = new frmVoucherEntry();
            //fve.Show();
            //this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

            //var confirmResult = MessageBox.Show("Are you sure to Back ??",
            //            "Confirm Exit!!",
            //            MessageBoxButtons.YesNo);
            //if (confirmResult == DialogResult.Yes)
            {

                frmMainScreen fms = new frmMainScreen();
                fms.Show();
                this.Hide(); 
            }

            
            
        }

        private void btnAcctsRpts_Enter(object sender, EventArgs e)
        {
            btnAcctsRpts.BackColor = Color.Aqua;
            lblHelpText.Text = "Master Help Texts......";
            lblMessageBig.Text = btnAcctsRpts.Text;
        }

        private void btnAcctsRpts_Leave(object sender, EventArgs e)
        {
            btnAcctsRpts.BackColor = SystemColors.Control;
        }

        private void btnOutStanding_Enter(object sender, EventArgs e)
        {
            btnVoucherEntry.BackColor = Color.Aqua;
            lblHelpText.Text = "Voucher Entry Help Texts......";
            lblMessageBig.Text = btnVoucherEntry.Text;
        }

        private void btnOutStanding_Leave(object sender, EventArgs e)
        {
            btnVoucherEntry.BackColor = SystemColors.Control;
        }

        private void btnDisplay_Enter(object sender, EventArgs e)
        {
            btnDisplay.BackColor = Color.Aqua;
            lblHelpText.Text = "Display Help Texts......";
            lblMessageBig.Text = btnDisplay.Text;
        }

        private void btnDisplay_Leave(object sender, EventArgs e)
        {
            btnDisplay.BackColor = SystemColors.Control;
        }

        private void btnPrint_Enter(object sender, EventArgs e)
        {
            btnPrint.BackColor = Color.Aqua;
            lblHelpText.Text = "Print Help Texts......";
            lblMessageBig.Text = btnPrint.Text;
        }

        private void btnPrint_Leave(object sender, EventArgs e)
        {
            btnPrint.BackColor = SystemColors.Control;
        }

        private void btnQuit_Leave(object sender, EventArgs e)
        {
            btnQuit.BackColor = SystemColors.Control;
        }

        private void btnQuit_Enter(object sender, EventArgs e)
        {
            btnQuit.BackColor   = Color.Aqua;
            lblHelpText.Text = "Exit From Application. ";
            lblMessageBig.Text = btnQuit.Text;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                
            }
            if (e.KeyCode == Keys.F3)
            {

            }
            if (e.KeyCode == Keys.F4)
            {
                
            }
            if (e.KeyCode == Keys.F5)
            {
                
            }
            if (e.KeyCode == Keys.F6)
            {

            }

            if (e.KeyCode==Keys.Escape)
            {
                btnQuit_Click(sender, e);
            }

        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to LogOff ??",
                       "Confirm LogOff!!",
                       MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                
                frmLogin fmL = new frmLogin();
                fmL.Show();
                this.WindowState = FormWindowState.Minimized;
                //REDIRECT TO LOGIN SCREEN
            }
            
        }

        private void btnAcctsRpts_Click(object sender, EventArgs e)
        {

        }

        

       

         
    }
}
