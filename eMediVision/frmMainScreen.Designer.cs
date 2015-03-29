using eMediVision.Classes;
namespace eMediVision
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMaster = new eMediVision.Classes.ColorButton();
            this.btnVoucherEntry = new eMediVision.Classes.ColorButton();
            this.btnDisplay = new eMediVision.Classes.ColorButton();
            this.btnPrint = new eMediVision.Classes.ColorButton();
            this.btnQuit = new eMediVision.Classes.ColorButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new eMediVision.Classes.ColorButton();
            this.button2 = new eMediVision.Classes.ColorButton();
            this.button3 = new eMediVision.Classes.ColorButton();
            this.btnLogOff = new eMediVision.Classes.ColorButton();
            this.button5 = new eMediVision.Classes.ColorButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHelpText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMessageBig = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnMaster);
            this.flowLayoutPanel2.Controls.Add(this.btnVoucherEntry);
            this.flowLayoutPanel2.Controls.Add(this.btnDisplay);
            this.flowLayoutPanel2.Controls.Add(this.btnPrint);
            this.flowLayoutPanel2.Controls.Add(this.btnQuit);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 199);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(282, 261);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnMaster
            // 
            this.btnMaster.BackColor = System.Drawing.SystemColors.Control;
            this.btnMaster.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMaster.Location = new System.Drawing.Point(23, 13);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(212, 41);
            this.btnMaster.TabIndex = 0;
            this.btnMaster.Text = "Masters";
            this.btnMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaster.UseVisualStyleBackColor = false;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            this.btnMaster.Enter += new System.EventHandler(this.btnMaster_Enter);
            this.btnMaster.Leave += new System.EventHandler(this.btnMaster_Leave);
            // 
            // btnVoucherEntry
            // 
            this.btnVoucherEntry.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoucherEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVoucherEntry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoucherEntry.Location = new System.Drawing.Point(23, 60);
            this.btnVoucherEntry.Name = "btnVoucherEntry";
            this.btnVoucherEntry.Size = new System.Drawing.Size(212, 42);
            this.btnVoucherEntry.TabIndex = 1;
            this.btnVoucherEntry.Text = "Voucher Entry";
            this.btnVoucherEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoucherEntry.UseVisualStyleBackColor = true;
            this.btnVoucherEntry.Click += new System.EventHandler(this.btnVoucherEntry_Click);
            this.btnVoucherEntry.Enter += new System.EventHandler(this.btnVoucherEntry_Enter);
            this.btnVoucherEntry.Leave += new System.EventHandler(this.btnVoucherEntry_Leave);
            // 
            // btnDisplay
            // 
            this.btnDisplay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDisplay.Location = new System.Drawing.Point(23, 108);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(212, 37);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            this.btnDisplay.Enter += new System.EventHandler(this.btnDisplay_Enter);
            this.btnDisplay.Leave += new System.EventHandler(this.btnDisplay_Leave);
            // 
            // btnPrint
            // 
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrint.Location = new System.Drawing.Point(23, 151);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(212, 36);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.Enter += new System.EventHandler(this.btnPrint_Enter);
            this.btnPrint.Leave += new System.EventHandler(this.btnPrint_Leave);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuit.Location = new System.Drawing.Point(23, 193);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(212, 37);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnQuit.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button1);
            this.flowLayoutPanel3.Controls.Add(this.button2);
            this.flowLayoutPanel3.Controls.Add(this.button3);
            this.flowLayoutPanel3.Controls.Add(this.btnLogOff);
            this.flowLayoutPanel3.Controls.Add(this.button5);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 466);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(282, 214);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(23, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "F2 :  Yearly Maintainance";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(23, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "F3 :  Controls";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(23, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "F4 :  Utilities";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnLogOff
            // 
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogOff.Location = new System.Drawing.Point(23, 118);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(197, 29);
            this.btnLogOff.TabIndex = 3;
            this.btnLogOff.Text = "F5 :  Log Off";
            this.btnLogOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(23, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "F6 :  About";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 23);
            this.label1.TabIndex = 56;
            this.label1.Text = "Shanu Medical and General Stores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(651, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "For Date : 2014-15 ";
            // 
            // lblHelpText
            // 
            this.lblHelpText.AllowDrop = true;
            this.lblHelpText.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblHelpText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblHelpText.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpText.HideSelection = false;
            this.lblHelpText.Location = new System.Drawing.Point(352, 276);
            this.lblHelpText.Multiline = true;
            this.lblHelpText.Name = "lblHelpText";
            this.lblHelpText.ReadOnly = true;
            this.lblHelpText.Size = new System.Drawing.Size(362, 92);
            this.lblHelpText.TabIndex = 59;
            this.lblHelpText.TabStop = false;
            this.lblHelpText.Text = "This Will Display Help Text";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(86, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 59;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Main Menu";
            // 
            // lblMessageBig
            // 
            this.lblMessageBig.AutoSize = true;
            this.lblMessageBig.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBig.Location = new System.Drawing.Point(348, 199);
            this.lblMessageBig.Name = "lblMessageBig";
            this.lblMessageBig.Size = new System.Drawing.Size(168, 31);
            this.lblMessageBig.TabIndex = 57;
            this.lblMessageBig.Text = "lblMessageBig";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 130);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(786, 677);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHelpText);
            this.Controls.Add(this.lblMessageBig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ColorButton btnMaster;
        private ColorButton btnVoucherEntry;
        private ColorButton btnPrint;
        private ColorButton btnQuit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private ColorButton button5;
        private ColorButton btnLogOff;
        private ColorButton button3;
        private ColorButton button2;
        private ColorButton button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblHelpText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMessageBig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ColorButton btnDisplay;


    }
}