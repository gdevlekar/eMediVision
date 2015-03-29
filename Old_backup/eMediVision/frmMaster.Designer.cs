using eMediVision.Classes;
namespace eMediVision
{
    partial class frmMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaster));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGroups = new eMediVision.Classes.ColorButton();
            this.btnLedger = new eMediVision.Classes.ColorButton();
            this.btnDebtors = new eMediVision.Classes.ColorButton();
            this.btnCreditors = new eMediVision.Classes.ColorButton();
            this.btnArea = new eMediVision.Classes.ColorButton();
            this.btnProduct = new eMediVision.Classes.ColorButton();
            this.btnParallelProducts = new eMediVision.Classes.ColorButton();
            this.btnCompany = new eMediVision.Classes.ColorButton();
            this.btnCategory = new eMediVision.Classes.ColorButton();
            this.btnDruggroups = new eMediVision.Classes.ColorButton();
            this.btnPatient = new eMediVision.Classes.ColorButton();
            this.btnDoctor = new eMediVision.Classes.ColorButton();
            this.btnPrescription = new eMediVision.Classes.ColorButton();
            this.btnManufacture = new eMediVision.Classes.ColorButton();
            this.btnCreditCard = new eMediVision.Classes.ColorButton();
            this.btnSalesMan = new eMediVision.Classes.ColorButton();
            this.btnGeneralContacts = new eMediVision.Classes.ColorButton();
            this.btnTherapeutic = new eMediVision.Classes.ColorButton();
            this.btnQuit = new eMediVision.Classes.ColorButton();
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
            this.flowLayoutPanel2.Controls.Add(this.btnGroups);
            this.flowLayoutPanel2.Controls.Add(this.btnLedger);
            this.flowLayoutPanel2.Controls.Add(this.btnDebtors);
            this.flowLayoutPanel2.Controls.Add(this.btnCreditors);
            this.flowLayoutPanel2.Controls.Add(this.btnArea);
            this.flowLayoutPanel2.Controls.Add(this.btnProduct);
            this.flowLayoutPanel2.Controls.Add(this.btnParallelProducts);
            this.flowLayoutPanel2.Controls.Add(this.btnCompany);
            this.flowLayoutPanel2.Controls.Add(this.btnCategory);
            this.flowLayoutPanel2.Controls.Add(this.btnDruggroups);
            this.flowLayoutPanel2.Controls.Add(this.btnPatient);
            this.flowLayoutPanel2.Controls.Add(this.btnDoctor);
            this.flowLayoutPanel2.Controls.Add(this.btnPrescription);
            this.flowLayoutPanel2.Controls.Add(this.btnManufacture);
            this.flowLayoutPanel2.Controls.Add(this.btnCreditCard);
            this.flowLayoutPanel2.Controls.Add(this.btnSalesMan);
            this.flowLayoutPanel2.Controls.Add(this.btnGeneralContacts);
            this.flowLayoutPanel2.Controls.Add(this.btnTherapeutic);
            this.flowLayoutPanel2.Controls.Add(this.btnQuit);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 176);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(20, 1, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(273, 600);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnGroups
            // 
            this.btnGroups.BackColor = System.Drawing.SystemColors.Control;
            this.btnGroups.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroups.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGroups.Location = new System.Drawing.Point(23, 4);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(212, 25);
            this.btnGroups.TabIndex = 0;
            this.btnGroups.Text = "Groups";
            this.btnGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroups.UseVisualStyleBackColor = false;
            this.btnGroups.Click += new System.EventHandler(this.btnAcctsRpts_Click);
            this.btnGroups.Leave += new System.EventHandler(this.btnAcctsRpts_Leave);
            // 
            // btnLedger
            // 
            this.btnLedger.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnLedger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLedger.Location = new System.Drawing.Point(23, 35);
            this.btnLedger.Name = "btnLedger";
            this.btnLedger.Size = new System.Drawing.Size(212, 25);
            this.btnLedger.TabIndex = 1;
            this.btnLedger.Text = "Ledger a/cs";
            this.btnLedger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLedger.UseVisualStyleBackColor = true;
            // 
            // btnDebtors
            // 
            this.btnDebtors.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDebtors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnDebtors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDebtors.Location = new System.Drawing.Point(23, 66);
            this.btnDebtors.Name = "btnDebtors";
            this.btnDebtors.Size = new System.Drawing.Size(212, 25);
            this.btnDebtors.TabIndex = 2;
            this.btnDebtors.Text = "Debtors (Customers)";
            this.btnDebtors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDebtors.UseVisualStyleBackColor = true;
            // 
            // btnCreditors
            // 
            this.btnCreditors.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreditors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnCreditors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreditors.Location = new System.Drawing.Point(23, 97);
            this.btnCreditors.Name = "btnCreditors";
            this.btnCreditors.Size = new System.Drawing.Size(212, 25);
            this.btnCreditors.TabIndex = 3;
            this.btnCreditors.Text = "Creditors (Suppliers)";
            this.btnCreditors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditors.UseVisualStyleBackColor = true;
            // 
            // btnArea
            // 
            this.btnArea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnArea.Location = new System.Drawing.Point(23, 128);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(212, 25);
            this.btnArea.TabIndex = 5;
            this.btnArea.Text = "Area";
            this.btnArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnArea.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnProduct
            // 
            this.btnProduct.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProduct.Location = new System.Drawing.Point(23, 159);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(212, 25);
            this.btnProduct.TabIndex = 6;
            this.btnProduct.Text = "Product ";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            this.btnProduct.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnProduct.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnParallelProducts
            // 
            this.btnParallelProducts.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnParallelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnParallelProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnParallelProducts.Location = new System.Drawing.Point(23, 190);
            this.btnParallelProducts.Name = "btnParallelProducts";
            this.btnParallelProducts.Size = new System.Drawing.Size(212, 25);
            this.btnParallelProducts.TabIndex = 7;
            this.btnParallelProducts.Text = "Parallel Products";
            this.btnParallelProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParallelProducts.UseVisualStyleBackColor = true;
            this.btnParallelProducts.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnParallelProducts.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnCompany
            // 
            this.btnCompany.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnCompany.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCompany.Location = new System.Drawing.Point(23, 221);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(212, 25);
            this.btnCompany.TabIndex = 8;
            this.btnCompany.Text = "Company";
            this.btnCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnCompany.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnCategory
            // 
            this.btnCategory.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCategory.Location = new System.Drawing.Point(23, 252);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(212, 25);
            this.btnCategory.TabIndex = 9;
            this.btnCategory.Text = "Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            this.btnCategory.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnCategory.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnDruggroups
            // 
            this.btnDruggroups.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDruggroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnDruggroups.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDruggroups.Location = new System.Drawing.Point(23, 283);
            this.btnDruggroups.Name = "btnDruggroups";
            this.btnDruggroups.Size = new System.Drawing.Size(212, 25);
            this.btnDruggroups.TabIndex = 10;
            this.btnDruggroups.Text = "Drug Group";
            this.btnDruggroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDruggroups.UseVisualStyleBackColor = true;
            this.btnDruggroups.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnDruggroups.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnPatient
            // 
            this.btnPatient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPatient.Location = new System.Drawing.Point(23, 314);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(212, 25);
            this.btnPatient.TabIndex = 10;
            this.btnPatient.Text = "Patient";
            this.btnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnPatient.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnDoctor
            // 
            this.btnDoctor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnDoctor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDoctor.Location = new System.Drawing.Point(23, 345);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(212, 25);
            this.btnDoctor.TabIndex = 10;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            this.btnDoctor.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnDoctor.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnPrescription
            // 
            this.btnPrescription.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrescription.Location = new System.Drawing.Point(23, 376);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(212, 25);
            this.btnPrescription.TabIndex = 10;
            this.btnPrescription.Text = "Prescription";
            this.btnPrescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrescription.UseVisualStyleBackColor = true;
            this.btnPrescription.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnPrescription.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnManufacture
            // 
            this.btnManufacture.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnManufacture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManufacture.Location = new System.Drawing.Point(23, 407);
            this.btnManufacture.Name = "btnManufacture";
            this.btnManufacture.Size = new System.Drawing.Size(212, 25);
            this.btnManufacture.TabIndex = 10;
            this.btnManufacture.Text = "Manufacturer";
            this.btnManufacture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManufacture.UseVisualStyleBackColor = true;
            this.btnManufacture.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnManufacture.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnCreditCard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreditCard.Location = new System.Drawing.Point(23, 438);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(212, 25);
            this.btnCreditCard.TabIndex = 10;
            this.btnCreditCard.Text = "Credit Card";
            this.btnCreditCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnCreditCard.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnSalesMan
            // 
            this.btnSalesMan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalesMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSalesMan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalesMan.Location = new System.Drawing.Point(23, 469);
            this.btnSalesMan.Name = "btnSalesMan";
            this.btnSalesMan.Size = new System.Drawing.Size(212, 25);
            this.btnSalesMan.TabIndex = 10;
            this.btnSalesMan.Text = "Sales Man";
            this.btnSalesMan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesMan.UseVisualStyleBackColor = true;
            this.btnSalesMan.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnSalesMan.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnGeneralContacts
            // 
            this.btnGeneralContacts.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeneralContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnGeneralContacts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeneralContacts.Location = new System.Drawing.Point(23, 500);
            this.btnGeneralContacts.Name = "btnGeneralContacts";
            this.btnGeneralContacts.Size = new System.Drawing.Size(212, 25);
            this.btnGeneralContacts.TabIndex = 10;
            this.btnGeneralContacts.Text = "General Contacts";
            this.btnGeneralContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneralContacts.UseVisualStyleBackColor = true;
            this.btnGeneralContacts.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnGeneralContacts.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnTherapeutic
            // 
            this.btnTherapeutic.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTherapeutic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnTherapeutic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTherapeutic.Location = new System.Drawing.Point(23, 531);
            this.btnTherapeutic.Name = "btnTherapeutic";
            this.btnTherapeutic.Size = new System.Drawing.Size(212, 25);
            this.btnTherapeutic.TabIndex = 10;
            this.btnTherapeutic.Text = "Therapeutic Category";
            this.btnTherapeutic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTherapeutic.UseVisualStyleBackColor = true;
            this.btnTherapeutic.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnTherapeutic.Leave += new System.EventHandler(this.btnQuit_Leave);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuit.Location = new System.Drawing.Point(23, 562);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(212, 25);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.Enter += new System.EventHandler(this.btnQuit_Enter);
            this.btnQuit.Leave += new System.EventHandler(this.btnQuit_Leave);
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
            this.lblHelpText.Size = new System.Drawing.Size(391, 177);
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
            this.textBox1.Location = new System.Drawing.Point(83, 148);
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
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(786, 788);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHelpText);
            this.Controls.Add(this.lblMessageBig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmMaster";
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
        private ColorButton btnGroups;
        private ColorButton btnLedger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblHelpText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMessageBig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ColorButton btnDebtors;
        private ColorButton btnArea;
        private ColorButton btnProduct;
        private ColorButton btnParallelProducts;
        private ColorButton btnCompany;
        private ColorButton btnCategory;
        private ColorButton btnDruggroups;
        private ColorButton btnCreditors;
        private ColorButton btnPatient;
        private ColorButton btnDoctor;
        private ColorButton btnPrescription;
        private ColorButton btnManufacture;
        private ColorButton btnCreditCard;
        private ColorButton btnSalesMan;
        private ColorButton btnTherapeutic;
        private ColorButton btnQuit;
        private ColorButton btnGeneralContacts;


    }
}