using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace eMediVision.Classes
{
    class ColorTextBox :TextBox
    {           
        public ColorTextBox()
        {
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Enter += new System.EventHandler(this.OnEnter_MyColor);
            this.Leave += new System.EventHandler(this.OnLeave_MyColor);
        }

       
        private void OnEnter_MyColor(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
        private void OnLeave_MyColor(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
