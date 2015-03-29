using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Data.OleDb;
using AutocompleteMenuNS;
using System.Data.SqlClient;
namespace eMediVision
{
    public partial class frmAddCategory : Form
    {

        
        string SQL = "";

        public frmAddCategory(string AddorUpdate)
        {
            InitializeComponent();
             
            string add = AddorUpdate.Split(';')[1];
            switch (add)
            {
                case "add":
                    lblAddorupdate.Text = "Add New Category";


                    break;
                case "update":
                    lblAddorupdate.Text = "Update Existing Category";

                    break;

                default:
                    break;
            }
            LoadData();

            // autocompleteMenu1.SetAutocompleteMenu(txtProductName, this.autocompleteMenu1);

            //Get Admin Password From database
            // showdata();

        }
        private void LoadData()
        {
            SqlConnection conn = SQLHelper.CreateConnection();
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();
            SqlDataAdapter DB;
            SqlCommand sql_cmd;
            sql_cmd = conn.CreateCommand();
            string CommandText = @"select ID,CategoryName,
                        case when BatchNo='Yes' then 'Yes' else 'No' end as BatchNo,
                        case when Expiry='Yes' then 'Yes' else 'No' end as Expiry,
                        case when InSale='Yes' then 'Yes' else 'No' end as InSale  from mst_category";

            //string CommandText = @"select ID,CategoryName,case when BatchNo='Yes' then 'Yes' else 'No' end as BatchNo from mst_category";
            DB = new SqlDataAdapter(CommandText, conn);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            grdCategory.DataSource = DT;
            conn.Dispose();
            
        }
        private void showdata()  // To show the data in the DataGridView
        {

            DataSet ds = new DataSet();

            ds = SelectUserDetails();


        }

        private void SearchData(string Keyword)
        {
            SqlConnection conn = SQLHelper.CreateConnection();
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();
            SqlDataAdapter DB;
            SqlCommand sql_cmd;
            sql_cmd = conn.CreateCommand();
            string CommandText = @"select ID,CategoryName,
                        case when BatchNo='Yes' then 'Yes' else 'No' end as BatchNo,
                        case when Expiry='Yes' then 'Yes' else 'No' end as Expiry,
                        case when InSale='Yes' then 'Yes' else 'No' end as InSale  
                    from mst_category where CategoryName LIKE '" + Keyword + "%'";

            //string CommandText = @"select ID,CategoryName,case when BatchNo='Yes' then 'Yes' else 'No' end as BatchNo from mst_category";
            DB = new SqlDataAdapter(CommandText, conn);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            grdCategory.DataSource = DT;
            conn.Dispose();

        }
        //protected override void WndProc(ref Message m)
        //{
        //    // Hide tabs by trapping the TCM_ADJUSTRECT message
        //    if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
        //    else base.WndProc(ref m);
        //}
        private DataSet SelectUserDetails()
        {
            SqlConnection conn = SQLHelper.CreateConnection();
            try
            {
                DataSet dataset = new DataSet();

                {
                   
                    lock (conn)
                    {

                        SqlDataAdapter da = new SqlDataAdapter();
                        SqlCommand cmd = new SqlCommand("select UserName,PassWord from Users where UserName<>'admin' ");
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        da.SelectCommand = cmd;

                        cmd.ExecuteNonQuery();
                        da.Fill(dataset);

                        var filePaths = dataset.Tables[0]
                            .AsEnumerable()
                            .Select(row => row.Field<string>("UserName"))
                            .ToArray();

                        autocompleteMenu1.SetAutocompleteItems(filePaths);
                        return dataset;

                    }
                }
            }
            catch (Exception ex)
            {
                conn.Dispose();
                MessageBox.Show(ex.Message);
                return null;
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

            else if (e.KeyCode == Keys.Enter)
            {
                // Validate User here



            }


        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLHelper.CreateConnection();

            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Please Enter CategoryName");
                return;
            }
            //            SqlCommand insertSQL = new SqlCommand(@"
            //        INSERT INTO
            //        mst_Category ( CategoryName,BatchNo,Expiry,InSale) 
            //        VALUES ('" + txtCategoryName.Text + "'," + cmbBatchNo.Text=="1" ?"true" : "false" + ",,?)", conn);

            SqlTransaction trans;
            string SQL = @" INSERT INTO mst_Category  ( CategoryName,BatchNo,Expiry,InSale) ";
            SQL += "VALUES (@CategoryName, @BatchNo, @Expiry, @NoDiscSale)";


            SqlCommand cmd = new SqlCommand(SQL);
            cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
            cmd.Parameters.AddWithValue("@BatchNo", this.cmbBatchNo.Text);
            cmd.Parameters.AddWithValue("@Expiry", this.cmbExpiry.Text);
            cmd.Parameters.AddWithValue("@NoDiscSale", this.cmbNoDiscSale.Text);
            cmd.Connection = conn;
            trans = conn.BeginTransaction();

            int retval = 0;
            try
            {
                retval = cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved!");
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                  trans.Commit();
                cmd.Dispose();
                conn.Dispose();

            }
        }

        private void frmAddProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var confirmResult = MessageBox.Show("Are you sure...Go To Main Menu ??",
                      "Confirm MainScreen!!",
                      MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    frmMaster fms = new frmMaster();
                    fms.Show();
                    this.Hide();

                }
                //esc
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

         

        private void txtSerachText_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSerachText.Text.Trim()))
            {
                SearchData(txtSerachText.Text.Trim());
            }
        }





    }
}
