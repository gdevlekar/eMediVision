using eMediVision.Classes;
namespace eMediVision
{
    partial class frmAddDoctor
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dbMainDataSet = new eMediVision.dbMainDataSet();
            this.dbMainDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.lblAddorupdate = new System.Windows.Forms.Label();
            this.btnSave = new eMediVision.Classes.ColorButton();
            this.txtOtherInfo = new eMediVision.Classes.ColorTextBox();
            this.txtUnitMeasure = new eMediVision.Classes.ColorTextBox();
            this.txtCategory = new eMediVision.Classes.ColorTextBox();
            this.txtManufacturer = new eMediVision.Classes.ColorTextBox();
            this.txtCompanyBarCode = new eMediVision.Classes.ColorTextBox();
            this.txtProductName = new eMediVision.Classes.ColorTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbMainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMainDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctor\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(36, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alias";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtOtherInfo);
            this.panel1.Controls.Add(this.txtUnitMeasure);
            this.panel1.Controls.Add(this.txtCategory);
            this.panel1.Controls.Add(this.txtManufacturer);
            this.panel1.Controls.Add(this.txtCompanyBarCode);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAddorupdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 380);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(36, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Specialization";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(36, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Timings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(36, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(36, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address";
            // 
            // dbMainDataSet
            // 
            this.dbMainDataSet.DataSetName = "dbMainDataSet";
            this.dbMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbMainDataSetBindingSource
            // 
            this.dbMainDataSetBindingSource.DataSource = this.dbMainDataSet;
            this.dbMainDataSetBindingSource.Position = 0;
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[0];
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // lblAddorupdate
            // 
            this.lblAddorupdate.AutoSize = true;
            this.lblAddorupdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddorupdate.Location = new System.Drawing.Point(173, 19);
            this.lblAddorupdate.Name = "lblAddorupdate";
            this.lblAddorupdate.Size = new System.Drawing.Size(66, 19);
            this.lblAddorupdate.TabIndex = 1;
            this.lblAddorupdate.Text = " Doctors";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(249, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOtherInfo
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtOtherInfo, null);
            this.txtOtherInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtOtherInfo.Location = new System.Drawing.Point(249, 134);
            this.txtOtherInfo.Multiline = true;
            this.txtOtherInfo.Name = "txtOtherInfo";
            this.txtOtherInfo.Size = new System.Drawing.Size(234, 48);
            this.txtOtherInfo.TabIndex = 2;
            // 
            // txtUnitMeasure
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtUnitMeasure, null);
            this.txtUnitMeasure.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtUnitMeasure.Location = new System.Drawing.Point(249, 262);
            this.txtUnitMeasure.Name = "txtUnitMeasure";
            this.txtUnitMeasure.Size = new System.Drawing.Size(148, 27);
            this.txtUnitMeasure.TabIndex = 5;
            // 
            // txtCategory
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtCategory, null);
            this.txtCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtCategory.Location = new System.Drawing.Point(249, 232);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(148, 27);
            this.txtCategory.TabIndex = 4;
            // 
            // txtManufacturer
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtManufacturer, null);
            this.txtManufacturer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtManufacturer.Location = new System.Drawing.Point(249, 201);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(148, 27);
            this.txtManufacturer.TabIndex = 3;
            // 
            // txtCompanyBarCode
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtCompanyBarCode, null);
            this.txtCompanyBarCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtCompanyBarCode.Location = new System.Drawing.Point(249, 98);
            this.txtCompanyBarCode.Name = "txtCompanyBarCode";
            this.txtCompanyBarCode.Size = new System.Drawing.Size(148, 27);
            this.txtCompanyBarCode.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtProductName, null);
            this.txtProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtProductName.Location = new System.Drawing.Point(249, 65);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(148, 27);
            this.txtProductName.TabIndex = 0;
            // 
            // frmAddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(689, 452);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmAddDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Doctors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddProducts_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbMainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMainDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ColorTextBox txtProductName;
        private ColorTextBox txtCompanyBarCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource dbMainDataSetBindingSource;
        private dbMainDataSet dbMainDataSet;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private ColorTextBox txtCategory;
        private ColorTextBox txtManufacturer;
        private ColorTextBox txtUnitMeasure;
        private ColorButton btnSave;
        private ColorTextBox txtOtherInfo;
        private System.Windows.Forms.Label lblAddorupdate;

        
    }
}