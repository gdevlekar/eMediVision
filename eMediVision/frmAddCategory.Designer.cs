using eMediVision.Classes;
namespace eMediVision
{
    partial class frmAddCategory
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
            this.dbMainDataSet = new eMediVision.dbMainDataSet();
            this.dbMainDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbNoDiscSale = new System.Windows.Forms.ComboBox();
            this.cmbExpiry = new System.Windows.Forms.ComboBox();
            this.cmbBatchNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddorupdate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.grdCategory = new System.Windows.Forms.DataGridView();
            this.btnSave = new eMediVision.Classes.ColorButton();
            this.txtCategoryName = new eMediVision.Classes.ColorTextBox();
            this.txtSerachText = new eMediVision.Classes.ColorTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbMainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMainDataSetBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            this.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(84, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 445);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbNoDiscSale);
            this.tabPage1.Controls.Add(this.cmbExpiry);
            this.tabPage1.Controls.Add(this.cmbBatchNo);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtCategoryName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblAddorupdate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbNoDiscSale
            // 
            this.cmbNoDiscSale.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.cmbNoDiscSale.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNoDiscSale.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNoDiscSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoDiscSale.FormattingEnabled = true;
            this.cmbNoDiscSale.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbNoDiscSale.Location = new System.Drawing.Point(320, 240);
            this.cmbNoDiscSale.Name = "cmbNoDiscSale";
            this.cmbNoDiscSale.Size = new System.Drawing.Size(61, 21);
            this.cmbNoDiscSale.TabIndex = 3;
            // 
            // cmbExpiry
            // 
            this.cmbExpiry.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.cmbExpiry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbExpiry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbExpiry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpiry.FormattingEnabled = true;
            this.cmbExpiry.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbExpiry.Location = new System.Drawing.Point(320, 170);
            this.cmbExpiry.Name = "cmbExpiry";
            this.cmbExpiry.Size = new System.Drawing.Size(61, 21);
            this.cmbExpiry.TabIndex = 2;
            // 
            // cmbBatchNo
            // 
            this.cmbBatchNo.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.cmbBatchNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBatchNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBatchNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatchNo.FormattingEnabled = true;
            this.cmbBatchNo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbBatchNo.Location = new System.Drawing.Point(320, 138);
            this.cmbBatchNo.Name = "cmbBatchNo";
            this.cmbBatchNo.Size = new System.Drawing.Size(61, 21);
            this.cmbBatchNo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(107, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "No Disc In Sale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(107, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Accept Expiry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(107, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Accept Batch No";
            // 
            // lblAddorupdate
            // 
            this.lblAddorupdate.AutoSize = true;
            this.lblAddorupdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddorupdate.Location = new System.Drawing.Point(244, 54);
            this.lblAddorupdate.Name = "lblAddorupdate";
            this.lblAddorupdate.Size = new System.Drawing.Size(70, 19);
            this.lblAddorupdate.TabIndex = 8;
            this.lblAddorupdate.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Category\'s Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtSerachText);
            this.tabPage2.Controls.Add(this.grdCategory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category Name:";
            // 
            // grdCategory
            // 
            this.grdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategory.Location = new System.Drawing.Point(42, 127);
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.Size = new System.Drawing.Size(508, 210);
            this.grdCategory.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(248, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCategoryName
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtCategoryName, null);
            this.txtCategoryName.BackColor = System.Drawing.Color.White;
            this.txtCategoryName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtCategoryName.Location = new System.Drawing.Point(320, 100);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(148, 27);
            this.txtCategoryName.TabIndex = 0;
            // 
            // txtSerachText
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtSerachText, null);
            this.txtSerachText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtSerachText.Location = new System.Drawing.Point(164, 48);
            this.txtSerachText.Name = "txtSerachText";
            this.txtSerachText.Size = new System.Drawing.Size(123, 27);
            this.txtSerachText.TabIndex = 1;
            this.txtSerachText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSerachText_KeyUp);
            // 
            // frmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(691, 515);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmAddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Doctors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddProducts_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dbMainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMainDataSetBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dbMainDataSetBindingSource;
        private dbMainDataSet dbMainDataSet;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbNoDiscSale;
        private System.Windows.Forms.ComboBox cmbExpiry;
        private System.Windows.Forms.ComboBox cmbBatchNo;
        private ColorButton btnSave;
        private ColorTextBox txtCategoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAddorupdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdCategory;
        private ColorTextBox txtSerachText;
        private System.Windows.Forms.Label label3;

        
    }
}