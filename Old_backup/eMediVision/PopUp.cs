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
    public partial class PopUp : Form
    {
        string MaptoForm = "";
        public PopUp(string AddorUpdate)
        {
            MaptoForm = AddorUpdate;
            this.Text = AddorUpdate;
            InitializeComponent();
        }

        private void PopUp_KeyDown(object sender, KeyEventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            switch (MaptoForm)
            {
                case "AddProducts":
                    frmAddProducts fAddprd = new frmAddProducts(MaptoForm+";"+"add");
                    fAddprd.Show();
                    this.Hide();
                    break;

                case "AddDoctor":
                    frmAddDoctor fAddDoct = new frmAddDoctor(MaptoForm + ";" + "add");
                    fAddDoct.Show();
                    this.Hide();
                    break;

                case "AddCategory":
                    frmAddCategory fAddCate = new frmAddCategory(MaptoForm + ";" + "add");
                    fAddCate.Show();
                    this.Hide();
                    break;


                default:
                    break;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (MaptoForm)
            {
                case "AddProducts":
                    frmAddProducts fAddprd = new frmAddProducts(MaptoForm + ";" + "update");
                    fAddprd.Show();
                    this.Hide();
                    break;

                case "AddDoctor":
                    frmAddDoctor fAddDoct = new frmAddDoctor(MaptoForm + ";" + "update");
                    fAddDoct.Show();
                    this.Hide();
                    break;



                default:
                    break;
            }
        }
    }
}
