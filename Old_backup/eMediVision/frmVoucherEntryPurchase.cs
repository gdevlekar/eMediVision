using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

using System.Data.SqlServerCe;
using System.Text.RegularExpressions;
using System.Threading;

namespace eMediVision
{
    public partial class frmVoucherEntryPurchase : Form
    {
        AutoCompleteStringCollection str = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autoCollection = new AutoCompleteStringCollection();
        List<string> strList = null;
        SqlCeConnection conn = new SqlCeConnection(@"Data Source=" + Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "dbMain.sdf"));
        string SQL = "";
        ListBox sugBox = null;

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
        UIntPtr dwExtraInfo);
        private int xPos = 0;

        string mytext = @"The designer for this control interacts with the design environment to provide a custom design-time experience. With the custom designer, you can assemble a custom MarqueeControl implementation with animated lights and flashing text in many combinations.You can use the assembled control on a form like any other Windows Forms control. ";
        public frmVoucherEntryPurchase()
        {
            InitializeComponent();

            DateTime dt = DateTime.Now;
            lblDate.Text = (dt.ToString("dd-MMM-yyyy", CultureInfo.InvariantCulture));
            lblDay.Text = (dt.ToString("dddd", CultureInfo.InvariantCulture));
            lblEnterDate.Text = (dt.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
            lblMerquee.Text = "";

            ////-------------open connection-------------
            conn.Open();
            ////-------------


            ////-------------align heders-----------
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name == "Amount" || col.Name == "MRP" || col.Name == "Qty")
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomRight;
                }
                if (col.Name == "Exp")
                {
                    col.DefaultCellStyle.Format = "dd-MMM-yyyy";
                }
            }


            ////-------------capslock on-----------
            //if (!Control.IsKeyLocked(Keys.CapsLock)) // Checks Capslock is on
            //{
            //    const int KEYEVENTF_EXTENDEDKEY = 0x1;
            //    const int KEYEVENTF_KEYUP = 0x2;
            //    keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            //    keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP,
            //    (UIntPtr)0);
            //}
        }






        private void timer1_Tick(object sender, EventArgs e)
        {
            // TO display Time
            lblTime.Text = string.Format(DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture));


            //COde for Merquee
            if (xPos >= mytext.Length - 200)
            {
                xPos = 0;
            }
            else
            {

                lblMerquee.Text = mytext.Substring(xPos, 200);
                xPos++;

            }

        }

        private void frmVoucherEntry_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                MessageBox.Show("Contra");
                //contra
            }
            if (e.KeyCode == Keys.F5)
            {
                MessageBox.Show("Payment");
                //payment
            }
            if (e.KeyCode == Keys.F6)
            {
                MessageBox.Show("Receipt");
                //receipt
            }


            if (e.KeyCode == Keys.F7)
            {
                MessageBox.Show("Journal");
                //Journal
            }
            if (e.KeyCode == Keys.F8)
            {
                MessageBox.Show("Sale");
                //Sale
            }

            if (e.KeyCode == Keys.F9)
            {
                MessageBox.Show("Purchase");
                //Purchase
            }
            if (e.KeyCode == Keys.F10)
            {
                MessageBox.Show("MISC");
                //MISC
            }
            if (e.KeyCode == Keys.Escape)
            {
                var confirmResult = MessageBox.Show("Are you sure...Go To Main Menu ??",
                      "Confirm MainScreen!!",
                      MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    frmMainScreen fms = new frmMainScreen();
                    fms.Show();
                    this.Hide();

                }
                //esc
            }

        }

        private void btnContra_Enter(object sender, EventArgs e)
        {
            btnContra.BackColor = Color.Aqua;
        }

        private void btnContra_Leave(object sender, EventArgs e)
        {
            btnContra.BackColor = SystemColors.Control;
        }

        private void btnPayment_Enter(object sender, EventArgs e)
        {
            btnPayment.BackColor = Color.Aqua;
        }

        private void btnPayment_Leave(object sender, EventArgs e)
        {
            btnPayment.BackColor = SystemColors.Control;
        }

        private void btnReceipt_Enter(object sender, EventArgs e)
        {
            btnReceipt.BackColor = Color.Aqua;
        }

        private void btnReceipt_Leave(object sender, EventArgs e)
        {
            btnReceipt.BackColor = SystemColors.Control;
        }

        private void btnJournal_Enter(object sender, EventArgs e)
        {
            btnJournal.BackColor = Color.Aqua;
        }

        private void btnJournal_Leave(object sender, EventArgs e)
        {
            btnJournal.BackColor = SystemColors.Control;
        }

        private void btnSale_Enter(object sender, EventArgs e)
        {
            //  btnSale.BackColor = Color.Aqua;
        }

        private void btnSale_Leave(object sender, EventArgs e)
        {
            //btnSale.BackColor = SystemColors.Control;
            //btnSale.FlatStyle = FlatStyle.Popup;
        }

        private void btnPurchase_Enter(object sender, EventArgs e)
        {
            btnPurchase.BackColor = Color.Aqua;
        }

        private void btnPurchase_Leave(object sender, EventArgs e)
        {
            btnPurchase.BackColor = SystemColors.Control;
        }

        private void btnMisc_Enter(object sender, EventArgs e)
        {
            btnMisc.BackColor = Color.Aqua;
        }

        private void btnMisc_Leave(object sender, EventArgs e)
        {
            btnMisc.BackColor = SystemColors.Control;

        }
        private Control editControl;
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            editControl = e.Control;

           // if (editControl != null)
            {
                try
                {



                    //if (!string.IsNullOrEmpty(editControl.Text.Trim()))
                    {

                        if (dataGridView1.CurrentCell.ColumnIndex == 0) //Note: You may need change the ColumnIndex for your case.
                        {

                            editControl.KeyDown -= new KeyEventHandler(cellTb_KeyDown);
                            editControl.KeyDown += new KeyEventHandler(cellTb_KeyDown);

                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            
            }
            

        }


        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            int v;
            DataTable dtResult = new DataTable();

            DataGridView col = sender as DataGridView;
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value==null)
            {
                return;
            }

            string textFound = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();




            if (selectedRow.Cells[0].Value != null)
                if (Int32.TryParse(selectedRow.Cells[0].Value.ToString(), out v))
                {

                    // after entering ID

                    SQL = "select   DrugName,Packing,Comp,Shelf,BatchNo,Exp,MRP,Qty,Amount from products where ID =" + selectedRow.Cells[0].Value;

                    SqlCeDataAdapter sda = new SqlCeDataAdapter(SQL, conn);
                    sda.Fill(dtResult);

                }

                else
                {
                    // after selecting name

                    SQL = "select   DrugName,Packing,Comp,Shelf,BatchNo,Exp,MRP,Qty,Amount from products where DrugName ='" + selectedRow.Cells[0].Value + "'";

                    SqlCeDataAdapter sda = new SqlCeDataAdapter(SQL, conn);
                    sda.Fill(dtResult);
                }





            if (dtResult != null)
            {
                if (dtResult.Rows.Count > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        selectedRow.Cells[0].Value = dtResult.Rows[0][0].ToString();
                        selectedRow.Cells[1].Value = dtResult.Rows[0][1].ToString();
                        selectedRow.Cells[2].Value = dtResult.Rows[0][2].ToString();
                        selectedRow.Cells[3].Value = dtResult.Rows[0][3].ToString();
                        selectedRow.Cells[4].Value = dtResult.Rows[0][4].ToString();
                        selectedRow.Cells[5].Value = dtResult.Rows[0][5].ToString();
                        selectedRow.Cells[6].Value = dtResult.Rows[0][6].ToString();
                        selectedRow.Cells[7].Value = dtResult.Rows[0][7].ToString();
                        selectedRow.Cells[8].Value = dtResult.Rows[0][8].ToString();
                    }
                }
                else
                {
                    selectedRow.Cells[0].Value = "";
                    selectedRow.Cells[1].Value = "";
                    selectedRow.Cells[2].Value = "";
                    selectedRow.Cells[3].Value = "";
                    selectedRow.Cells[4].Value = "";
                    selectedRow.Cells[5].Value = "";
                    selectedRow.Cells[6].Value = "";
                    selectedRow.Cells[7].Value = "";
                    selectedRow.Cells[8].Value = "";
                }
            }
            else
            {

                selectedRow.Cells[0].Value = "";
                selectedRow.Cells[1].Value = "";
                selectedRow.Cells[2].Value = "";
                selectedRow.Cells[3].Value = "";
                selectedRow.Cells[4].Value = "";
                selectedRow.Cells[5].Value = "";
                selectedRow.Cells[6].Value = "";
                selectedRow.Cells[7].Value = "";
                selectedRow.Cells[8].Value = "";
            }

        }

        protected void cellTb_KeyDown(object sender, KeyEventArgs e)
        {
            editControl = sender as TextBox;
           
            {
                try
                {

                    this.autocompleteMenu1.SetAutocompleteMenu(editControl, null);
                    {
                        lock (conn)
                        {
                            strList = new List<string>();

                            SqlCeDataReader dReader;

                            SqlCeCommand cmd = new SqlCeCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "select DrugName from products where DrugName like '" + editControl.Text + "%'";

                            dReader = cmd.ExecuteReader();

                            while (dReader.Read())
                            {
                                // str.Add(dReader["DrugName"].ToString());
                                strList.Add(dReader["DrugName"].ToString());
                            }



                            dReader.Close();


                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                this.autocompleteMenu1.SetAutocompleteMenu(editControl, this.autocompleteMenu1);
                autocompleteMenu1.SetAutocompleteItems(strList);
            }


        }






        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Up)
        //    {
        //        //MessageBox.Show(keyData.ToString());
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                int currentIndex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow rd = dataGridView1.Rows[currentIndex];
                if (!rd.IsNewRow)
                {
                    dataGridView1.Rows.RemoveAt(currentIndex);
                }

            }
        }






        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            autocompleteMenu1.TargetControlWrapper = null;
            autocompleteMenu1.SetAutocompleteMenu(editControl, null);
        }

        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            editControl = e.Control;
            //autocompleteMenu1.SetAutocompleteMenu(e.Control, autocompleteMenu1);

            //TextBox cellTb = (TextBox)e.Control;

            // if (dgv.CurrentCell.ColumnIndex == 0) //Note: You may need change the ColumnIndex for your case.
            {





                //editControl.KeyDown -= new KeyEventHandler(cellTb_KeyDown);
                //editControl.KeyDown += new KeyEventHandler(cellTb_KeyDown);


                //=======================================================

                try
                {


                    {
                        lock (conn)
                        {
                            strList = new List<string>();

                            SqlCeDataReader dReader;

                            SqlCeCommand cmd = new SqlCeCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "select top (10) DrugName from products where DrugName like '" + editControl.Text + "%'";

                            dReader = cmd.ExecuteReader();

                            while (dReader.Read())
                            {
                                // str.Add(dReader["DrugName"].ToString());
                                strList.Add(dReader["DrugName"].ToString());
                            }



                            dReader.Close();


                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                this.autocompleteMenu1.SetAutocompleteMenu(editControl, this.autocompleteMenu1);
                autocompleteMenu1.SetAutocompleteItems(strList);
                //=======================================================




            }
        }




        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Exp")
            {
                ShortFormDateFormat(e);
            }
        }

        private static void ShortFormDateFormat(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    DateTime theDate = DateTime.Parse(formatting.Value.ToString());
                    String dateString = theDate.ToString("dd-MMM-yyyy");
                    formatting.Value = dateString;
                    formatting.FormattingApplied = true;
                }
                catch (FormatException)
                {
                    // Set to false in case there are other handlers interested trying to
                    // format this DataGridViewCellFormattingEventArgs instance.
                    formatting.FormattingApplied = false;
                }
            }
        }

        private void frmVoucherEntry_Load(object sender, EventArgs e)
        {

        }






    }
}
