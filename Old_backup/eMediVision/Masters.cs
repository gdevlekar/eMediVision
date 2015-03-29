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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnMaster.Focus();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {

        }

        private void btnVoucherEntry_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

        }

        private void btnMaster_Enter(object sender, EventArgs e)
        {
            btnMaster.BackColor = Color.Aqua;
        }

        private void btnMaster_Leave(object sender, EventArgs e)
        {
            btnMaster.BackColor = SystemColors.Control;
        }

        private void btnVoucherEntry_Enter(object sender, EventArgs e)
        {
            btnVoucherEntry.BackColor = Color.Aqua;
        }

        private void btnVoucherEntry_Leave(object sender, EventArgs e)
        {
            btnVoucherEntry.BackColor = SystemColors.Control;
        }

        private void btnPrint_Enter(object sender, EventArgs e)
        {
            btnPrint.BackColor = Color.Aqua;
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
        }
    }
}
