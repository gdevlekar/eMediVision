using eMediVision.Classes;
namespace eMediVision
{
    partial class frmDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisplay));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAcctsRpts = new ColorButton();
            this.btnVoucherEntry = new ColorButton();
            this.btnDisplay = new ColorButton();
            this.btnPrint = new ColorButton();
            this.btnQuit = new ColorButton();
            this.button1 = new ColorButton();
            this.button2 = new ColorButton();
            this.button3 = new ColorButton();
            this.button4 = new ColorButton();
            this.button5 = new ColorButton();
            this.button6 = new ColorButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHelpText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMessageBig = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAcctsRpts);
            this.flowLayoutPanel2.Controls.Add(this.btnVoucherEntry);
            this.flowLayoutPanel2.Controls.Add(this.btnDisplay);
            this.flowLayoutPanel2.Controls.Add(this.btnPrint);
            this.flowLayoutPanel2.Controls.Add(this.btnQuit);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.button4);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Controls.Add(this.button6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 199);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(282, 466);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnAcctsRpts
            // 
            this.btnAcctsRpts.BackColor = System.Drawing.SystemColors.Control;
            this.btnAcctsRpts.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAcctsRpts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcctsRpts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAcctsRpts.Location = new System.Drawing.Point(23, 13);
            this.btnAcctsRpts.Name = "btnAcctsRpts";
            this.btnAcctsRpts.Size = new System.Drawing.Size(212, 35);
            this.btnAcctsRpts.TabIndex = 0;
            this.btnAcctsRpts.Text = "Accounts Reports";
            this.btnAcctsRpts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcctsRpts.UseVisualStyleBackColor = false;
            this.btnAcctsRpts.Click += new System.EventHandler(this.btnAcctsRpts_Click);
            this.btnAcctsRpts.Enter += new System.EventHandler(this.btnAcctsRpts_Enter);
            this.btnAcctsRpts.Leave += new System.EventHandler(this.btnAcctsRpts_Leave);
            // 
            // btnVoucherEntry
            // 
            this.btnVoucherEntry.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoucherEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVoucherEntry.Location = new System.Drawing.Point(23, 54);
            this.btnVoucherEntry.Name = "btnVoucherEntry";
            this.btnVoucherEntry.Size = new System.Drawing.Size(212, 35);
            this.btnVoucherEntry.TabIndex = 1;
            this.btnVoucherEntry.Text = "OutStandings";
            this.btnVoucherEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoucherEntry.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.Location = new System.Drawing.Point(23, 95);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(212, 35);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Stock Reports";
            this.btnDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(23, 136);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(212, 35);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Product Reports";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnQuit.Location = new System.Drawing.Point(23, 177);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(212, 35);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Tag = "";
            this.btnQuit.Text = "fdg";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(23, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sales Reports";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnQuit_Click);
            this.button1.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.button1.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(23, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Day Book";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnQuit_Click);
            this.button2.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.button2.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(23, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Purchase Orders";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnQuit_Click);
            this.button3.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.button3.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(23, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "List";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnQuit_Click);
            this.button4.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.button4.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(23, 382);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(212, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "Other Reports";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnQuit_Click);
            this.button5.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.button5.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // button6
            // 
            this.button6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(23, 423);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 35);
            this.button6.TabIndex = 10;
            this.button6.Text = "Back";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnQuit_Click);
            this.button6.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.button6.Leave += new System.EventHandler(this.btnQuit_Leave);
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
            this.textBox1.Text = "Display";
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
            // frmDisplay
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmDisplay";
            this.Text = "Form2";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ColorButton btnAcctsRpts;
        private ColorButton btnVoucherEntry;
        private ColorButton btnPrint;
        private ColorButton btnQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblHelpText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMessageBig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ColorButton btnDisplay;
        private ColorButton button1;
        private ColorButton button2;
        private ColorButton button3;
        private ColorButton button4;
        private ColorButton button5;
        private ColorButton button6;


    }
}