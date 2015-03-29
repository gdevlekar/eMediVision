using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;
using System.Data.OleDb;
using System.Data.SQLite;
using AutocompleteMenuNS;
using eMediVision.Classes;
namespace eMediVision
{
    public partial class frmAddDoctor : Form
    {
        
        //SqlCeConnection conn = new SqlCeConnection(@"Data Source=" + Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "dbMain.sdf"));
        SQLiteConnection conn = SQLHelper.CreateConnection();
        string SQL = "";

        public frmAddDoctor(string AddorUpdate)
        {
            InitializeComponent();

            string add = AddorUpdate.Split(';')[1];
            switch (add)
            {
                case "add":
                    lblAddorupdate.Text = "Add New Doctor's";
                    break;
                case "update":
                    lblAddorupdate.Text = "Update Existing Doctor's";
                    break;
                    
                default:
                    break;
            }


            // autocompleteMenu1.SetAutocompleteMenu(txtProductName, this.autocompleteMenu1);

            //Get Admin Password From database
            // showdata();

        }
        private void showdata()  // To show the data in the DataGridView
        {

            DataSet ds = new DataSet();

            ds = SelectUserDetails();


        }

        private DataSet SelectUserDetails()
        {
            try
            {
                DataSet dataset = new DataSet();

                {
                    lock (conn)
                    {

                        //SqlCeDataAdapter da = new SqlCeDataAdapter();
                        SQLiteDataAdapter da = new SQLiteDataAdapter();
                        //SqlCeCommand cmd = new SqlCeCommand("select UserName,PassWord from Users where UserName<>'admin' ");
                        SQLiteCommand cmd = new SQLiteCommand("select UserName,PassWord from Users where UserName<>'admin' ");
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

                if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("Please Enter UserName");
                    return;
                }
                if (string.IsNullOrEmpty(txtCompanyBarCode.Text))
                {
                    MessageBox.Show("Please Enter Password");
                    return;
                }

                if (txtProductName.Text == "admin" && txtCompanyBarCode.Text == "admin")
                {
                    // if Admin password is equals to entered then user can create  Users

                    var confirmResult = MessageBox.Show("Are you sure to Exit ??",
                       "Confirm Exit!!",
                       MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        //Create User 
                        MessageBox.Show("Created User :" + " Successfully...");
                    }
                }
                else
                {
                    MessageBox.Show("Only Admin Can Create Users...");
                    txtProductName.Text = "";
                    txtCompanyBarCode.Text = "";
                    txtProductName.Focus();

                }

            }


        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            //SqlCeCommand cmd = new SqlCeCommand("insert into tbl", SQLHelper.CreateConnection());
            //cmd.CommandType = CommandType.Text;

            //OleDbConnection conn = new OleDbConnection();
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





    }
}
