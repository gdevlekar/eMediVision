using eMediVision.Classes;
namespace eMediVision
{
    partial class frmAddArea
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
            this.txtPackDesc = new eMediVision.Classes.ColorTextBox();
            this.txtPurchasePack = new eMediVision.Classes.ColorTextBox();
            this.txtUnitMeasure = new eMediVision.Classes.ColorTextBox();
            this.txtCategory = new eMediVision.Classes.ColorTextBox();
            this.txtManufacturer = new eMediVision.Classes.ColorTextBox();
            this.txtCompany = new eMediVision.Classes.ColorTextBox();
            this.txtCompanyBarCode = new eMediVision.Classes.ColorTextBox();
            this.txtProductName = new eMediVision.Classes.ColorTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dbMainDataSet = new eMediVision.dbMainDataSet();
            this.dbMainDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.txtICCode = new eMediVision.Classes.ColorTextBox();
            this.txtShelfNo = new eMediVision.Classes.ColorTextBox();
            this.txtOtherInfo = new eMediVision.Classes.ColorTextBox();
            this.txtTheraputicCategory = new eMediVision.Classes.ColorTextBox();
            this.txtMarginInPercent = new eMediVision.Classes.ColorTextBox();
            this.txtMaxLevel = new eMediVision.Classes.ColorTextBox();
            this.txtLBT = new eMediVision.Classes.ColorTextBox();
            this.txtMinLevel = new eMediVision.Classes.ColorTextBox();
            this.txtCST = new eMediVision.Classes.ColorTextBox();
            this.txtVAT_Octroi = new eMediVision.Classes.ColorTextBox();
            this.txtVatPercent = new eMediVision.Classes.ColorTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbDPCOProduct = new System.Windows.Forms.ComboBox();
            this.cmbHide = new System.Windows.Forms.ComboBox();
            this.cmbScheduledDrug = new System.Windows.Forms.ComboBox();
            this.cmbPrintLables = new System.Windows.Forms.ComboBox();
            this.btnSave = new eMediVision.Classes.ColorButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbMainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMainDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Bar Code";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPackDesc);
            this.panel1.Controls.Add(this.txtPurchasePack);
            this.panel1.Controls.Add(this.txtUnitMeasure);
            this.panel1.Controls.Add(this.txtCategory);
            this.panel1.Controls.Add(this.txtManufacturer);
            this.panel1.Controls.Add(this.txtCompany);
            this.panel1.Controls.Add(this.txtCompanyBarCode);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 284);
            this.panel1.TabIndex = 0;
            // 
            // txtPackDesc
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtPackDesc, null);
            this.txtPackDesc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtPackDesc.Location = new System.Drawing.Point(243, 246);
            this.txtPackDesc.Name = "txtPackDesc";
            this.txtPackDesc.Size = new System.Drawing.Size(148, 27);
            this.txtPackDesc.TabIndex = 7;
            // 
            // txtPurchasePack
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtPurchasePack, null);
            this.txtPurchasePack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtPurchasePack.Location = new System.Drawing.Point(243, 217);
            this.txtPurchasePack.Name = "txtPurchasePack";
            this.txtPurchasePack.Size = new System.Drawing.Size(148, 27);
            this.txtPurchasePack.TabIndex = 6;
            // 
            // txtUnitMeasure
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtUnitMeasure, null);
            this.txtUnitMeasure.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtUnitMeasure.Location = new System.Drawing.Point(243, 184);
            this.txtUnitMeasure.Name = "txtUnitMeasure";
            this.txtUnitMeasure.Size = new System.Drawing.Size(148, 27);
            this.txtUnitMeasure.TabIndex = 5;
            // 
            // txtCategory
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtCategory, null);
            this.txtCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtCategory.Location = new System.Drawing.Point(243, 154);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(148, 27);
            this.txtCategory.TabIndex = 4;
            // 
            // txtManufacturer
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtManufacturer, null);
            this.txtManufacturer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtManufacturer.Location = new System.Drawing.Point(243, 123);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(148, 27);
            this.txtManufacturer.TabIndex = 3;
            // 
            // txtCompany
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtCompany, null);
            this.txtCompany.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtCompany.Location = new System.Drawing.Point(243, 92);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(148, 27);
            this.txtCompany.TabIndex = 2;
            // 
            // txtCompanyBarCode
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtCompanyBarCode, null);
            this.txtCompanyBarCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtCompanyBarCode.Location = new System.Drawing.Point(243, 56);
            this.txtCompanyBarCode.Name = "txtCompanyBarCode";
            this.txtCompanyBarCode.Size = new System.Drawing.Size(148, 27);
            this.txtCompanyBarCode.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtProductName, null);
            this.txtProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtProductName.Location = new System.Drawing.Point(243, 23);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(148, 27);
            this.txtProductName.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(31, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Pack Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Purchase Pack";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(30, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Unit of Measure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(30, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Manufacturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Company ";
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
            // txtICCode
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtICCode, null);
            this.txtICCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtICCode.Location = new System.Drawing.Point(178, 538);
            this.txtICCode.Name = "txtICCode";
            this.txtICCode.Size = new System.Drawing.Size(86, 27);
            this.txtICCode.TabIndex = 10;
            this.txtICCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // txtShelfNo
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtShelfNo, null);
            this.txtShelfNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtShelfNo.Location = new System.Drawing.Point(178, 467);
            this.txtShelfNo.Name = "txtShelfNo";
            this.txtShelfNo.Size = new System.Drawing.Size(382, 27);
            this.txtShelfNo.TabIndex = 5;
            // 
            // txtOtherInfo
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtOtherInfo, null);
            this.txtOtherInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtOtherInfo.Location = new System.Drawing.Point(709, 565);
            this.txtOtherInfo.Multiline = true;
            this.txtOtherInfo.Name = "txtOtherInfo";
            this.txtOtherInfo.Size = new System.Drawing.Size(234, 48);
            this.txtOtherInfo.TabIndex = 14;
            this.txtOtherInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // txtTheraputicCategory
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtTheraputicCategory, null);
            this.txtTheraputicCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtTheraputicCategory.Location = new System.Drawing.Point(770, 518);
            this.txtTheraputicCategory.Name = "txtTheraputicCategory";
            this.txtTheraputicCategory.Size = new System.Drawing.Size(86, 27);
            this.txtTheraputicCategory.TabIndex = 9;
            this.txtTheraputicCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // txtMarginInPercent
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtMarginInPercent, null);
            this.txtMarginInPercent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtMarginInPercent.Location = new System.Drawing.Point(770, 475);
            this.txtMarginInPercent.Name = "txtMarginInPercent";
            this.txtMarginInPercent.Size = new System.Drawing.Size(86, 27);
            this.txtMarginInPercent.TabIndex = 6;
            this.txtMarginInPercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // txtMaxLevel
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtMaxLevel, null);
            this.txtMaxLevel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaxLevel.Location = new System.Drawing.Point(770, 437);
            this.txtMaxLevel.Name = "txtMaxLevel";
            this.txtMaxLevel.Size = new System.Drawing.Size(86, 27);
            this.txtMaxLevel.TabIndex = 4;
            // 
            // txtLBT
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtLBT, null);
            this.txtLBT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtLBT.Location = new System.Drawing.Point(474, 500);
            this.txtLBT.Name = "txtLBT";
            this.txtLBT.Size = new System.Drawing.Size(86, 27);
            this.txtLBT.TabIndex = 8;
            this.txtLBT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // txtMinLevel
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtMinLevel, null);
            this.txtMinLevel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtMinLevel.Location = new System.Drawing.Point(474, 432);
            this.txtMinLevel.Name = "txtMinLevel";
            this.txtMinLevel.Size = new System.Drawing.Size(86, 27);
            this.txtMinLevel.TabIndex = 3;
            // 
            // txtCST
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtCST, null);
            this.txtCST.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtCST.Location = new System.Drawing.Point(178, 432);
            this.txtCST.Name = "txtCST";
            this.txtCST.Size = new System.Drawing.Size(86, 27);
            this.txtCST.TabIndex = 2;
            // 
            // txtVAT_Octroi
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtVAT_Octroi, null);
            this.txtVAT_Octroi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtVAT_Octroi.Location = new System.Drawing.Point(243, 54);
            this.txtVAT_Octroi.Name = "txtVAT_Octroi";
            this.txtVAT_Octroi.Size = new System.Drawing.Size(148, 27);
            this.txtVAT_Octroi.TabIndex = 1;
            // 
            // txtVatPercent
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtVatPercent, null);
            this.txtVatPercent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtVatPercent.Location = new System.Drawing.Point(243, 19);
            this.txtVatPercent.Name = "txtVatPercent";
            this.txtVatPercent.Size = new System.Drawing.Size(148, 27);
            this.txtVatPercent.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVAT_Octroi);
            this.groupBox1.Controls.Add(this.txtVatPercent);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VAT Calculation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(29, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "VAT + Octroi % (for Salrerate)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(30, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "VAT in %";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(42, 435);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "C.S.T";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(42, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Shelf No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(306, 435);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "Minimum Level";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(43, 508);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 19);
            this.label14.TabIndex = 1;
            this.label14.Text = "Hide";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(42, 537);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 19);
            this.label15.TabIndex = 1;
            this.label15.Text = "I/C Code";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(42, 573);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 19);
            this.label16.TabIndex = 1;
            this.label16.Text = "DPCO Product";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(306, 508);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 19);
            this.label17.TabIndex = 1;
            this.label17.Text = "LBT in %";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(306, 537);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 19);
            this.label18.TabIndex = 1;
            this.label18.Text = "Scheduled Drag";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(306, 573);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 19);
            this.label19.TabIndex = 1;
            this.label19.Text = "Print Labels";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(609, 435);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 19);
            this.label20.TabIndex = 1;
            this.label20.Text = "Maximum Level";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(609, 475);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 19);
            this.label21.TabIndex = 1;
            this.label21.Text = "Margin in %";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(609, 508);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(155, 19);
            this.label22.TabIndex = 1;
            this.label22.Text = "Therapeutic Category";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(609, 555);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 19);
            this.label23.TabIndex = 1;
            this.label23.Text = "Other info.";
            // 
            // cmbDPCOProduct
            // 
            this.cmbDPCOProduct.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.cmbDPCOProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDPCOProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDPCOProduct.FormattingEnabled = true;
            this.cmbDPCOProduct.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbDPCOProduct.Location = new System.Drawing.Point(175, 581);
            this.cmbDPCOProduct.Name = "cmbDPCOProduct";
            this.cmbDPCOProduct.Size = new System.Drawing.Size(61, 21);
            this.cmbDPCOProduct.TabIndex = 12;
            // 
            // cmbHide
            // 
            this.cmbHide.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.cmbHide.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbHide.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHide.FormattingEnabled = true;
            this.cmbHide.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbHide.Location = new System.Drawing.Point(175, 504);
            this.cmbHide.Name = "cmbHide";
            this.cmbHide.Size = new System.Drawing.Size(61, 21);
            this.cmbHide.TabIndex = 7;
            // 
            // cmbScheduledDrug
            // 
            this.cmbScheduledDrug.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.cmbScheduledDrug.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbScheduledDrug.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbScheduledDrug.FormattingEnabled = true;
            this.cmbScheduledDrug.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbScheduledDrug.Location = new System.Drawing.Point(474, 542);
            this.cmbScheduledDrug.Name = "cmbScheduledDrug";
            this.cmbScheduledDrug.Size = new System.Drawing.Size(61, 21);
            this.cmbScheduledDrug.TabIndex = 11;
            // 
            // cmbPrintLables
            // 
            this.cmbPrintLables.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.cmbPrintLables.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPrintLables.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPrintLables.FormattingEnabled = true;
            this.cmbPrintLables.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbPrintLables.Location = new System.Drawing.Point(474, 574);
            this.cmbPrintLables.Name = "cmbPrintLables";
            this.cmbPrintLables.Size = new System.Drawing.Size(61, 21);
            this.cmbPrintLables.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(326, 617);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(925, 658);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbHide);
            this.Controls.Add(this.cmbPrintLables);
            this.Controls.Add(this.cmbScheduledDrug);
            this.Controls.Add(this.cmbDPCOProduct);
            this.Controls.Add(this.txtICCode);
            this.Controls.Add(this.txtShelfNo);
            this.Controls.Add(this.txtOtherInfo);
            this.Controls.Add(this.txtTheraputicCategory);
            this.Controls.Add(this.txtMarginInPercent);
            this.Controls.Add(this.txtMaxLevel);
            this.Controls.Add(this.txtLBT);
            this.Controls.Add(this.txtMinLevel);
            this.Controls.Add(this.txtCST);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmAddArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddProducts_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbMainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMainDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private ColorTextBox txtCategory;
        private ColorTextBox txtManufacturer;
        private ColorTextBox txtPackDesc;
        private ColorTextBox txtPurchasePack;
        private ColorTextBox txtUnitMeasure;
        private ColorTextBox txtVAT_Octroi;
        private ColorTextBox txtVatPercent;
        private ColorTextBox txtCST;
        private ColorTextBox txtShelfNo;
        private ColorTextBox txtICCode;
        private ColorTextBox txtMinLevel;
        private ColorTextBox txtLBT;
        private ColorTextBox txtMaxLevel;
        private ColorTextBox txtOtherInfo;
        private ColorTextBox txtMarginInPercent;
        private ColorTextBox txtTheraputicCategory;
        private ColorTextBox txtCompany;
        private System.Windows.Forms.ComboBox cmbDPCOProduct;
        private System.Windows.Forms.ComboBox cmbHide;
        private System.Windows.Forms.ComboBox cmbScheduledDrug;
        private System.Windows.Forms.ComboBox cmbPrintLables;
        private ColorButton btnSave;

        
    }
}