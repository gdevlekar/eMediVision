using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace eMediVision.Classes
{
    class ColorButton:Button
    {

        public ColorButton()
        {

            this.Enter += new EventHandler(ColorButton_Enter);
            this.Leave += new EventHandler(ColorButton_Leave);
            //this.MouseHover += new EventHandler(ColorButton_MouseHover);
            //this.MouseLeave += new EventHandler(ColorButton_MouseLeave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UseVisualStyleBackColor = false;

                
        }

        void ColorButton_Leave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            Height = Height - 10;
            
        }

        void ColorButton_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
            Height = Height+10;
        }

        //void ColorButton_MouseHover(object sender, EventArgs e)
        //{
        //    this.BackColor = SystemColors.Control;
        //    Height = Height + 10;
        
        //}
        //void ColorButton_MouseLeave(object sender, EventArgs e)
        //{
        //    this.BackColor = SystemColors.Control;
        //    Height = Height - 10;

        //}
    }
}
