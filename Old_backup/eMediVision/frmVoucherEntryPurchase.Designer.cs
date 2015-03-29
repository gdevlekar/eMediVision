namespace eMediVision
{
    partial class frmVoucherEntryPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnContra = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnJournal = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnMisc = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CashOrCreditPurchase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblEnterDate = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblMerquee = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalQTY = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblGrossAmount = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalBigQty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblPercentDiscount = new System.Windows.Forms.Label();
            this.lblAmtDiscount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Packing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContra
            // 
            this.btnContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContra.Location = new System.Drawing.Point(16, 724);
            this.btnContra.Name = "btnContra";
            this.btnContra.Size = new System.Drawing.Size(127, 32);
            this.btnContra.TabIndex = 0;
            this.btnContra.Text = "F4 : CONTRA";
            this.btnContra.UseVisualStyleBackColor = true;
            this.btnContra.Enter += new System.EventHandler(this.btnContra_Enter);
            this.btnContra.Leave += new System.EventHandler(this.btnContra_Leave);
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(149, 724);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(127, 32);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "F5 : PAYMENT";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Enter += new System.EventHandler(this.btnPayment_Enter);
            this.btnPayment.Leave += new System.EventHandler(this.btnPayment_Leave);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.Location = new System.Drawing.Point(282, 724);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(127, 32);
            this.btnReceipt.TabIndex = 2;
            this.btnReceipt.Text = "F6 : RECEIPT";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Enter += new System.EventHandler(this.btnReceipt_Enter);
            this.btnReceipt.Leave += new System.EventHandler(this.btnReceipt_Leave);
            // 
            // btnJournal
            // 
            this.btnJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJournal.Location = new System.Drawing.Point(415, 724);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(127, 32);
            this.btnJournal.TabIndex = 3;
            this.btnJournal.Text = "F7 :  JOURNAL";
            this.btnJournal.UseVisualStyleBackColor = true;
            this.btnJournal.Enter += new System.EventHandler(this.btnJournal_Enter);
            this.btnJournal.Leave += new System.EventHandler(this.btnJournal_Leave);
            // 
            // btnSale
            // 
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Location = new System.Drawing.Point(548, 724);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(127, 32);
            this.btnSale.TabIndex = 4;
            this.btnSale.Text = "F8 : SALE";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Enter += new System.EventHandler(this.btnSale_Enter);
            this.btnSale.Leave += new System.EventHandler(this.btnSale_Leave);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(681, 724);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(160, 32);
            this.btnPurchase.TabIndex = 5;
            this.btnPurchase.Text = "F9 : PURCHASE";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Enter += new System.EventHandler(this.btnPurchase_Enter);
            this.btnPurchase.Leave += new System.EventHandler(this.btnPurchase_Leave);
            // 
            // btnMisc
            // 
            this.btnMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisc.Location = new System.Drawing.Point(847, 724);
            this.btnMisc.Name = "btnMisc";
            this.btnMisc.Size = new System.Drawing.Size(127, 32);
            this.btnMisc.TabIndex = 6;
            this.btnMisc.Text = "F10 : MISC";
            this.btnMisc.UseVisualStyleBackColor = true;
            this.btnMisc.Enter += new System.EventHandler(this.btnMisc_Enter);
            this.btnMisc.Leave += new System.EventHandler(this.btnMisc_Leave);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(16, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 17);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(116, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 17);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entry of Vouchers - Purchase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(904, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "User : ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CashOrCreditPurchase
            // 
            this.CashOrCreditPurchase.AutoSize = true;
            this.CashOrCreditPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashOrCreditPurchase.Location = new System.Drawing.Point(11, 45);
            this.CashOrCreditPurchase.Name = "CashOrCreditPurchase";
            this.CashOrCreditPurchase.Size = new System.Drawing.Size(157, 17);
            this.CashOrCreditPurchase.TabIndex = 1;
            this.CashOrCreditPurchase.Text = "Cash/Credit Purchase : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(743, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date : ";
            this.label5.Visible = false;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(924, 64);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(62, 17);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "ToDay : ";
            // 
            // lblEnterDate
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.lblEnterDate, null);
            this.lblEnterDate.BeepOnError = true;
            this.lblEnterDate.Location = new System.Drawing.Point(799, 64);
            this.lblEnterDate.Mask = "00/00/0000";
            this.lblEnterDate.Name = "lblEnterDate";
            this.lblEnterDate.Size = new System.Drawing.Size(82, 20);
            this.lblEnterDate.TabIndex = 0;
            this.lblEnterDate.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.dateTimePicker1.Location = new System.Drawing.Point(730, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblMerquee
            // 
            this.lblMerquee.AutoSize = true;
            this.lblMerquee.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblMerquee.Location = new System.Drawing.Point(15, 692);
            this.lblMerquee.Name = "lblMerquee";
            this.lblMerquee.Size = new System.Drawing.Size(151, 19);
            this.lblMerquee.TabIndex = 8;
            this.lblMerquee.Text = "Display Marquee Msg";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Packing,
            this.Comp,
            this.Qty,
            this.Shelf,
            this.Exp,
            this.VatPercent,
            this.MRP,
            this.PurchaseRate,
            this.Amount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(258, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total Qty :";
            // 
            // lblTotalQTY
            // 
            this.lblTotalQTY.AutoSize = true;
            this.lblTotalQTY.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQTY.Location = new System.Drawing.Point(344, 460);
            this.lblTotalQTY.Name = "lblTotalQTY";
            this.lblTotalQTY.Size = new System.Drawing.Size(87, 19);
            this.lblTotalQTY.TabIndex = 9;
            this.lblTotalQTY.Text = "lblTotalQTY";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.Location = new System.Drawing.Point(963, 528);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(49, 19);
            this.lblVAT.TabIndex = 9;
            this.lblVAT.Text = "lblVAT";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(588, 637);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 19);
            this.label16.TabIndex = 9;
            this.label16.Text = "[-] Discount :";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(930, 637);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(82, 19);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "lblDiscount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(603, 460);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 19);
            this.label15.TabIndex = 9;
            this.label15.Text = "Gross Amount :";
            // 
            // lblGrossAmount
            // 
            this.lblGrossAmount.AutoSize = true;
            this.lblGrossAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossAmount.Location = new System.Drawing.Point(904, 460);
            this.lblGrossAmount.Name = "lblGrossAmount";
            this.lblGrossAmount.Size = new System.Drawing.Size(112, 19);
            this.lblGrossAmount.TabIndex = 9;
            this.lblGrossAmount.Text = "lblGrossAmount";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(603, 682);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 19);
            this.label21.TabIndex = 9;
            this.label21.Text = "Net Amount :";
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetAmount.Location = new System.Drawing.Point(914, 682);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(98, 19);
            this.lblNetAmount.TabIndex = 9;
            this.lblNetAmount.Text = "lblNetAmount";
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.CaptureFocus = true;
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[0];
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(940, 129);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(76, 17);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // lblTotalBigQty
            // 
            this.lblTotalBigQty.AutoSize = true;
            this.lblTotalBigQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBigQty.Location = new System.Drawing.Point(821, 129);
            this.lblTotalBigQty.Name = "lblTotalBigQty";
            this.lblTotalBigQty.Size = new System.Drawing.Size(90, 17);
            this.lblTotalBigQty.TabIndex = 1;
            this.lblTotalBigQty.Text = "Total Big Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Party Name :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(13, 117);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 17);
            this.label27.TabIndex = 1;
            this.label27.Text = "Bill No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "[-] Scm Discount :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(25, 491);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(118, 19);
            this.label28.TabIndex = 9;
            this.label28.Text = "[+] VAT On Free :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "[+] Octroi :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(25, 559);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(120, 19);
            this.label29.TabIndex = 9;
            this.label29.Text = "[+] Repl Diff Adj :";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(25, 598);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(106, 19);
            this.label30.TabIndex = 9;
            this.label30.Text = "[-] Debit Note :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(588, 491);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(93, 19);
            this.label31.TabIndex = 9;
            this.label31.Text = "[-] Discount :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(588, 528);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "[+] VAT :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(588, 559);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 19);
            this.label17.TabIndex = 9;
            this.label17.Text = "[+] Others :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(588, 598);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 19);
            this.label18.TabIndex = 9;
            this.label18.Text = "[-] Others :";
            // 
            // lblPercentDiscount
            // 
            this.lblPercentDiscount.AutoSize = true;
            this.lblPercentDiscount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentDiscount.Location = new System.Drawing.Point(742, 491);
            this.lblPercentDiscount.Name = "lblPercentDiscount";
            this.lblPercentDiscount.Size = new System.Drawing.Size(131, 19);
            this.lblPercentDiscount.TabIndex = 9;
            this.lblPercentDiscount.Text = "lblPercentDiscount";
            // 
            // lblAmtDiscount
            // 
            this.lblAmtDiscount.AutoSize = true;
            this.lblAmtDiscount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtDiscount.Location = new System.Drawing.Point(903, 491);
            this.lblAmtDiscount.Name = "lblAmtDiscount";
            this.lblAmtDiscount.Size = new System.Drawing.Size(108, 19);
            this.lblAmtDiscount.TabIndex = 9;
            this.lblAmtDiscount.Text = "lblAmtDiscount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(742, 528);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "lblPercentDiscount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(742, 559);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 19);
            this.label13.TabIndex = 9;
            this.label13.Text = "lblPercentDiscount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(742, 598);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 19);
            this.label14.TabIndex = 9;
            this.label14.Text = "lblPercentDiscount";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(742, 637);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 19);
            this.label19.TabIndex = 9;
            this.label19.Text = "lblPercentDiscount";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(25, 637);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 19);
            this.label20.TabIndex = 9;
            this.label20.Text = "Narration :";
            // 
            // textBox1
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.textBox1, null);
            this.textBox1.Location = new System.Drawing.Point(117, 640);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 52);
            this.textBox1.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(879, 559);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(131, 19);
            this.label22.TabIndex = 9;
            this.label22.Text = "lblPercentDiscount";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(879, 598);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(131, 19);
            this.label23.TabIndex = 9;
            this.label23.Text = "lblPercentDiscount";
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductName.Frozen = true;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 250;
            this.ProductName.Name = "ProductName";
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductName.Width = 250;
            // 
            // Packing
            // 
            this.Packing.Frozen = true;
            this.Packing.HeaderText = "Packing";
            this.Packing.MinimumWidth = 30;
            this.Packing.Name = "Packing";
            this.Packing.ReadOnly = true;
            this.Packing.Width = 89;
            // 
            // Comp
            // 
            this.Comp.Frozen = true;
            this.Comp.HeaderText = "Batch No";
            this.Comp.MinimumWidth = 60;
            this.Comp.Name = "Comp";
            this.Comp.ReadOnly = true;
            this.Comp.Width = 96;
            // 
            // Qty
            // 
            this.Qty.Frozen = true;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 56;
            // 
            // Shelf
            // 
            this.Shelf.Frozen = true;
            this.Shelf.HeaderText = "Scm";
            this.Shelf.MinimumWidth = 60;
            this.Shelf.Name = "Shelf";
            this.Shelf.ReadOnly = true;
            this.Shelf.Width = 63;
            // 
            // Exp
            // 
            this.Exp.Frozen = true;
            this.Exp.HeaderText = "Exp";
            this.Exp.MinimumWidth = 80;
            this.Exp.Name = "Exp";
            this.Exp.ReadOnly = true;
            this.Exp.Width = 80;
            // 
            // VatPercent
            // 
            this.VatPercent.Frozen = true;
            this.VatPercent.HeaderText = "Vat in %";
            this.VatPercent.Name = "VatPercent";
            this.VatPercent.ReadOnly = true;
            this.VatPercent.Width = 89;
            // 
            // MRP
            // 
            this.MRP.HeaderText = "MRP";
            this.MRP.MinimumWidth = 96;
            this.MRP.Name = "MRP";
            this.MRP.ReadOnly = true;
            this.MRP.Width = 96;
            // 
            // PurchaseRate
            // 
            this.PurchaseRate.HeaderText = "Purchase Rate";
            this.PurchaseRate.Name = "PurchaseRate";
            this.PurchaseRate.ReadOnly = true;
            this.PurchaseRate.Width = 124;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 96;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 96;
            // 
            // frmVoucherEntryPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNetAmount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblGrossAmount);
            this.Controls.Add(this.lblAmtDiscount);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblPercentDiscount);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.lblTotalQTY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblMerquee);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblEnterDate);
            this.Controls.Add(this.lblTotalBigQty);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CashOrCreditPurchase);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnContra);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.btnMisc);
            this.Controls.Add(this.btnJournal);
            this.Controls.Add(this.btnSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmVoucherEntryPurchase";
            this.Text = "Entry of Vouchers - Counter Sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVoucherEntry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVoucherEntry_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContra;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnJournal;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnMisc;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label CashOrCreditPurchase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.MaskedTextBox lblEnterDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblMerquee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalQTY;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblGrossAmount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblNetAmount;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalBigQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPercentDiscount;
        private System.Windows.Forms.Label lblAmtDiscount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Packing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exp;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;


    }
}