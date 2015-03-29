using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using AutocompleteMenuNS;
using System.Data.SqlClient;
namespace eMediVision
{
    public partial class frmUsers : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=" + Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "dbMain.sdf"));
        string SQL = "";

        public frmUsers()
        {
            InitializeComponent();


            autocompleteMenu1.SetAutocompleteMenu(txtUsername, this.autocompleteMenu1);

            //Get Admin Password From database
            showdata();

        }
        private void showdata()  // To show the data in the DataGridView
        {

            DataSet ds = new DataSet();

            ds = SelectUserDetails();

            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private DataSet SelectUserDetails()
        {
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

                MessageBox.Show(ex.Message);
                return null;
            }
        }
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
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

            else if (e.KeyCode == Keys.Enter)
            {
                // Validate User here

                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Please Enter UserName");
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please Enter Password");
                    return;
                }

                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
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
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();

                }

            }


        }


    }
}
