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
    public partial class frmMaster : Form
    {
        public frmMaster()
        {
            InitializeComponent();
            btnGroups.Focus();

            btnGroups.Enter += new EventHandler(CommonMessage);
            btnLedger.Enter += new EventHandler(CommonMessage);
            btnDebtors.Enter += new EventHandler(CommonMessage);
            btnCreditors.Enter += new EventHandler(CommonMessage);
            btnArea.Enter += new EventHandler(CommonMessage);
            btnProduct.Enter += new EventHandler(CommonMessage);
            btnParallelProducts.Enter += new EventHandler(CommonMessage);
           btnCompany.Enter += new EventHandler(CommonMessage);
           btnCategory.Enter += new EventHandler(CommonMessage);
           btnDruggroups.Enter += new EventHandler(CommonMessage);
            btnPatient.Enter += new EventHandler(CommonMessage);
            btnDoctor.Enter += new EventHandler(CommonMessage);
            btnPrescription.Enter += new EventHandler(CommonMessage);
            btnManufacture.Enter += new EventHandler(CommonMessage);

            btnCreditCard.Enter += new EventHandler(CommonMessage);
            btnSalesMan.Enter += new EventHandler(CommonMessage);
            btnGeneralContacts.Enter += new EventHandler(CommonMessage);

            btnTherapeutic.Enter += new EventHandler(CommonMessage);

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

            //var confirmResult = MessageBox.Show("Are you sure to Exit ??",
            //            "Confirm Exit!!",
            //            MessageBoxButtons.YesNo);
            //if (confirmResult == DialogResult.Yes)
            //{
                 
            //    Application.Exit();
            //}

            frmMainScreen fms = new frmMainScreen();
            fms.Show();
            this.Hide();
            
        }

        //private void btnAcctsRpts_Enter(object sender, EventArgs e)
        //{
        //   // btnGroups.BackColor = Color.Aqua;
        //    lblHelpText.Text = "Add New Groups or Delete Existing Groups...";
        //    lblMessageBig.Text = btnGroups.Text;
        //}

        private void CommonMessage(object sender, EventArgs e)
        {
            Button btn=  sender as Button;
            lblHelpText.Text = "Add New " + btn.Text + " or Delete Existing " + btn.Text + "...";
            lblMessageBig.Text = btn.Text;
        
        }

        private void btnAcctsRpts_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnOutStanding_Enter(object sender, EventArgs e)
        {
            btnLedger.BackColor = Color.Aqua;
            lblHelpText.Text = "Voucher Entry Help Texts......";
            lblMessageBig.Text = btnLedger.Text;
        }

        private void btnOutStanding_Leave(object sender, EventArgs e)
        {
           // btnLedger.BackColor = SystemColors.Control;
        }

        private void btnDisplay_Enter(object sender, EventArgs e)
        {
            btnDebtors.BackColor = Color.Aqua;
            lblHelpText.Text = "Display Help Texts......";
            lblMessageBig.Text = btnDebtors.Text;
        }

        private void btnDisplay_Leave(object sender, EventArgs e)
        {
           // btnDebtors.BackColor = SystemColors.Control;
        }

        private void btnPrint_Enter(object sender, EventArgs e)
        {
            //btnCreditors.BackColor = Color.Aqua;
            lblHelpText.Text = "Print Help Texts......";
            lblMessageBig.Text = btnCreditors.Text;
        }

        private void btnPrint_Leave(object sender, EventArgs e)
        {
           // btnCreditors.BackColor = SystemColors.Control;
        }

        private void btnQuit_Leave(object sender, EventArgs e)
        {
            //btnQuit.BackColor = SystemColors.Control;
        }

        private void btnQuit_Enter(object sender, EventArgs e)
        {
           // btnQuit.BackColor   = Color.Aqua;
            lblHelpText.Text = "Exit From Application. ";
           // lblMessageBig.Text = btnQuit.Text;
        }



        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Up)
        //    {
        //        //MessageBox.Show(keyData.ToString());
        //        switch (btnArea.BackColor.ToKnownColor())
        //        {
        //            case KnownColor.Aqua:
                        
                        
        //                break;

        //            default:
        //                break;
        //        }
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

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
                frmMainScreen fm = new frmMainScreen();
                this.Hide();
                fm.Show();
                
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

        private void btnProduct_Click(object sender, EventArgs e)
        {
            PopUp frmPop = new PopUp("AddProducts");
            frmPop.Show();
            this.Hide();

            //frmAddProducts frmProduct = new frmAddProducts();
            //frmProduct.Show();
            //this.Hide();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            PopUp frmPop = new PopUp("AddDoctor");
            frmPop.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            PopUp frmPop = new PopUp("AddCategory");
            frmPop.Show();
            this.Hide();
            

        }

        

       

         
    }
}

