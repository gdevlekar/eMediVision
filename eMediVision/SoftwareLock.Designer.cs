using eMediVision.Classes;
namespace eMediVision
{
    partial class SoftwareLock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorTextBox4 = new eMediVision.Classes.ColorTextBox();
            this.colorTextBox3 = new eMediVision.Classes.ColorTextBox();
            this.colorTextBox2 = new eMediVision.Classes.ColorTextBox();
            this.colorTextBox1 = new eMediVision.Classes.ColorTextBox();
            this.txtProductName = new eMediVision.Classes.ColorTextBox();
            this.labelNormal2 = new eMediVision.Classes.LabelNormal();
            this.labelNormal3 = new eMediVision.Classes.LabelNormal();
            this.labelNormal1 = new eMediVision.Classes.LabelNormal();
            this.label1 = new eMediVision.Classes.LabelNormal();
            this.SuspendLayout();
            // 
            // colorTextBox4
            // 
            this.colorTextBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.colorTextBox4.Location = new System.Drawing.Point(375, 210);
            this.colorTextBox4.Name = "colorTextBox4";
            this.colorTextBox4.Size = new System.Drawing.Size(68, 27);
            this.colorTextBox4.TabIndex = 4;
            // 
            // colorTextBox3
            // 
            this.colorTextBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.colorTextBox3.Location = new System.Drawing.Point(291, 210);
            this.colorTextBox3.Name = "colorTextBox3";
            this.colorTextBox3.Size = new System.Drawing.Size(68, 27);
            this.colorTextBox3.TabIndex = 3;
            // 
            // colorTextBox2
            // 
            this.colorTextBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.colorTextBox2.Location = new System.Drawing.Point(211, 210);
            this.colorTextBox2.Name = "colorTextBox2";
            this.colorTextBox2.Size = new System.Drawing.Size(68, 27);
            this.colorTextBox2.TabIndex = 2;
            // 
            // colorTextBox1
            // 
            this.colorTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.colorTextBox1.Location = new System.Drawing.Point(132, 210);
            this.colorTextBox1.Name = "colorTextBox1";
            this.colorTextBox1.Size = new System.Drawing.Size(68, 27);
            this.colorTextBox1.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtProductName.Location = new System.Drawing.Point(52, 210);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(68, 27);
            this.txtProductName.TabIndex = 0;
            // 
            // labelNormal2
            // 
            this.labelNormal2.AutoSize = true;
            this.labelNormal2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNormal2.ForeColor = System.Drawing.Color.Red;
            this.labelNormal2.Location = new System.Drawing.Point(221, 111);
            this.labelNormal2.Name = "labelNormal2";
            this.labelNormal2.Size = new System.Drawing.Size(176, 19);
            this.labelNormal2.TabIndex = 0;
            this.labelNormal2.Text = "this is my machine code";
            // 
            // labelNormal3
            // 
            this.labelNormal3.AutoSize = true;
            this.labelNormal3.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNormal3.Location = new System.Drawing.Point(48, 177);
            this.labelNormal3.Name = "labelNormal3";
            this.labelNormal3.Size = new System.Drawing.Size(213, 19);
            this.labelNormal3.TabIndex = 0;
            this.labelNormal3.Text = "Enter Your Lock Code Below :";
            // 
            // labelNormal1
            // 
            this.labelNormal1.AutoSize = true;
            this.labelNormal1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNormal1.Location = new System.Drawing.Point(62, 111);
            this.labelNormal1.Name = "labelNormal1";
            this.labelNormal1.Size = new System.Drawing.Size(152, 19);
            this.labelNormal1.TabIndex = 0;
            this.labelNormal1.Text = "Your Machine Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(67, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Software Has been Locked";
            // 
            // SoftwareLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(513, 294);
            this.ControlBox = false;
            this.Controls.Add(this.colorTextBox4);
            this.Controls.Add(this.colorTextBox3);
            this.Controls.Add(this.colorTextBox2);
            this.Controls.Add(this.colorTextBox1);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.labelNormal2);
            this.Controls.Add(this.labelNormal3);
            this.Controls.Add(this.labelNormal1);
            this.Controls.Add(this.label1);
            this.Name = "SoftwareLock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Locked";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelNormal label1;
        private LabelNormal labelNormal1;
        private LabelNormal labelNormal2;
        private ColorTextBox txtProductName;
        private ColorTextBox colorTextBox1;
        private ColorTextBox colorTextBox2;
        private ColorTextBox colorTextBox3;
        private ColorTextBox colorTextBox4;
        private LabelNormal labelNormal3;
    }
}