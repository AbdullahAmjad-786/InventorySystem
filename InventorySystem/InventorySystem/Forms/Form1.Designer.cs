namespace InventorySystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textUnit = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSaleQty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAvailableQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNewBalance = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtBalnace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPaymentDue = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnSearchbyName = new System.Windows.Forms.Button();
            this.BtnSearchbyCode = new System.Windows.Forms.Button();
            this.textBarCode = new System.Windows.Forms.TextBox();
            this.lblSearchByItem = new System.Windows.Forms.Label();
            this.txtSearchByItemName = new System.Windows.Forms.TextBox();
            this.txtSearchByItemCode = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new InventorySystem.InventoryDataSet();
            this.label25 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.grdCart = new System.Windows.Forms.DataGridView();
            this.productTableAdapter = new InventorySystem.InventoryDataSetTableAdapters.productTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Name = "label3";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.txtCustomerId);
            this.panel1.Controls.Add(this.txtInvoiceDate);
            this.panel1.Controls.Add(this.txtInvoiceNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCustomerName
            // 
            resources.ApplyResources(this.txtCustomerName, "txtCustomerName");
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // txtCustomerId
            // 
            resources.ApplyResources(this.txtCustomerId, "txtCustomerId");
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            this.txtCustomerId.Leave += new System.EventHandler(this.txtCustomerId_Leave);
            // 
            // txtInvoiceDate
            // 
            resources.ApplyResources(this.txtInvoiceDate, "txtInvoiceDate");
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            this.txtInvoiceDate.TextChanged += new System.EventHandler(this.txtInvoiceDate_TextChanged);
            // 
            // txtInvoiceNo
            // 
            resources.ApplyResources(this.txtInvoiceNo, "txtInvoiceNo");
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.TextChanged += new System.EventHandler(this.txtInvoiceNo_TextChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightSlateGray;
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Name = "label8";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.textUnit);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.txtTotalAmount);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtSaleQty);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtAvailableQty);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtUnitPrice);
            this.panel2.Controls.Add(this.txtItemName);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textUnit
            // 
            resources.ApplyResources(this.textUnit, "textUnit");
            this.textUnit.Name = "textUnit";
            this.textUnit.ReadOnly = true;
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.button9, "button9");
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // txtTotalAmount
            // 
            resources.ApplyResources(this.txtTotalAmount, "txtTotalAmount");
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.button9_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtSaleQty
            // 
            resources.ApplyResources(this.txtSaleQty, "txtSaleQty");
            this.txtSaleQty.Name = "txtSaleQty";
            this.txtSaleQty.ReadOnly = true;
            this.txtSaleQty.TextChanged += new System.EventHandler(this.txtSaleQty_TextChanged);
            this.txtSaleQty.Leave += new System.EventHandler(this.txtTotal_calculate);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtAvailableQty
            // 
            resources.ApplyResources(this.txtAvailableQty, "txtAvailableQty");
            this.txtAvailableQty.Name = "txtAvailableQty";
            this.txtAvailableQty.ReadOnly = true;
            this.txtAvailableQty.TextChanged += new System.EventHandler(this.txtAvailableQty_TextChanged);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtUnitPrice
            // 
            resources.ApplyResources(this.txtUnitPrice, "txtUnitPrice");
            this.txtUnitPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // txtItemName
            // 
            resources.ApplyResources(this.txtItemName, "txtItemName");
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.AcceptsTabChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            this.txtItemName.Leave += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightSlateGray;
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Name = "label14";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.txtNewBalance);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.txtBalnace);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.txtPaymentDue);
            this.panel4.Controls.Add(this.txtGrandTotal);
            this.panel4.Controls.Add(this.txtDiscount);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.lblGrandTotal);
            this.panel4.Name = "panel4";
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtNewBalance
            // 
            this.txtNewBalance.BackColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.txtNewBalance, "txtNewBalance");
            this.txtNewBalance.ForeColor = System.Drawing.Color.Chartreuse;
            this.txtNewBalance.Name = "txtNewBalance";
            this.txtNewBalance.ReadOnly = true;
            this.txtNewBalance.TextChanged += new System.EventHandler(this.txtNewBalance_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSlateGray;
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtBalnace
            // 
            this.txtBalnace.BackColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.txtBalnace, "txtBalnace");
            this.txtBalnace.ForeColor = System.Drawing.Color.Chartreuse;
            this.txtBalnace.Name = "txtBalnace";
            this.txtBalnace.ReadOnly = true;
            this.txtBalnace.TextChanged += new System.EventHandler(this.txtBalnace_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged_1);
            this.txtTotal.Leave += new System.EventHandler(this.txtTotal_Leave_1);
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // txtPaymentDue
            // 
            this.txtPaymentDue.BackColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.txtPaymentDue, "txtPaymentDue");
            this.txtPaymentDue.ForeColor = System.Drawing.Color.Chartreuse;
            this.txtPaymentDue.Name = "txtPaymentDue";
            this.txtPaymentDue.ReadOnly = true;
            this.txtPaymentDue.TextChanged += new System.EventHandler(this.txtPaymentDue_TextChanged);
            // 
            // txtGrandTotal
            // 
            resources.ApplyResources(this.txtGrandTotal, "txtGrandTotal");
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.TextChanged += new System.EventHandler(this.txtGrandTotal_TextChanged);
            // 
            // txtDiscount
            // 
            resources.ApplyResources(this.txtDiscount, "txtDiscount");
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged_1);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BackColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.lblGrandTotal, "lblGrandTotal");
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblGrandTotal.Name = "lblGrandTotal";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.BackColor = System.Drawing.Color.LightSlateGray;
            this.label21.Name = "label21";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Controls.Add(this.BtnSearchbyName);
            this.panel5.Controls.Add(this.BtnSearchbyCode);
            this.panel5.Controls.Add(this.textBarCode);
            this.panel5.Controls.Add(this.lblSearchByItem);
            this.panel5.Controls.Add(this.txtSearchByItemName);
            this.panel5.Controls.Add(this.txtSearchByItemCode);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Name = "panel5";
            // 
            // BtnSearchbyName
            // 
            resources.ApplyResources(this.BtnSearchbyName, "BtnSearchbyName");
            this.BtnSearchbyName.Name = "BtnSearchbyName";
            this.BtnSearchbyName.UseVisualStyleBackColor = true;
            this.BtnSearchbyName.Click += new System.EventHandler(this.BtnSearchbyName_Click);
            // 
            // BtnSearchbyCode
            // 
            resources.ApplyResources(this.BtnSearchbyCode, "BtnSearchbyCode");
            this.BtnSearchbyCode.Name = "BtnSearchbyCode";
            this.BtnSearchbyCode.UseVisualStyleBackColor = true;
            this.BtnSearchbyCode.Click += new System.EventHandler(this.BtnSearchbyCode_Click);
            // 
            // textBarCode
            // 
            resources.ApplyResources(this.textBarCode, "textBarCode");
            this.textBarCode.Name = "textBarCode";
            this.textBarCode.Leave += new System.EventHandler(this.textBarCode_Leave_1);
            // 
            // lblSearchByItem
            // 
            resources.ApplyResources(this.lblSearchByItem, "lblSearchByItem");
            this.lblSearchByItem.Name = "lblSearchByItem";
            // 
            // txtSearchByItemName
            // 
            resources.ApplyResources(this.txtSearchByItemName, "txtSearchByItemName");
            this.txtSearchByItemName.Name = "txtSearchByItemName";
            this.txtSearchByItemName.TextChanged += new System.EventHandler(this.txtSearchByItemName_TextChanged);
            // 
            // txtSearchByItemCode
            // 
            resources.ApplyResources(this.txtSearchByItemCode, "txtSearchByItemCode");
            this.txtSearchByItemCode.Name = "txtSearchByItemCode";
            this.txtSearchByItemCode.TextChanged += new System.EventHandler(this.txtSearchByItemCode_TextChanged);
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.BackColor = System.Drawing.Color.LightSlateGray;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Name = "label24";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            this.productBindingSource1.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "InventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.BackColor = System.Drawing.Color.LightSlateGray;
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Name = "label25";
            // 
            // button10
            // 
            resources.ApplyResources(this.button10, "button10");
            this.button10.BackColor = System.Drawing.Color.LightSlateGray;
            this.button10.Name = "button10";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            resources.ApplyResources(this.button11, "button11");
            this.button11.BackColor = System.Drawing.Color.LightSlateGray;
            this.button11.Name = "button11";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // grdCart
            // 
            this.grdCart.AllowUserToAddRows = false;
            this.grdCart.AllowUserToResizeRows = false;
            resources.ApplyResources(this.grdCart, "grdCart");
            this.grdCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdCart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarCode,
            this.ItemName,
            this.sellingprice,
            this.Qty,
            this.unit,
            this.TotalPrice});
            this.grdCart.Name = "grdCart";
            this.grdCart.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdCart_CellBeginEdit);
            this.grdCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCart_CellContentClick);
            this.grdCart.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCart_CellContentDoubleClick);
            this.grdCart.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCart_CellEndEdit);
            this.grdCart.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCart_CellEnter);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Name = "label1";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name,
            this.price,
            this.quantity,
            this.unitnumber});
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseDoubleClick);
            // 
            // code
            // 
            resources.ApplyResources(this.code, "code");
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            resources.ApplyResources(this.price, "price");
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // unitnumber
            // 
            resources.ApplyResources(this.unitnumber, "unitnumber");
            this.unitnumber.Name = "unitnumber";
            this.unitnumber.ReadOnly = true;
            // 
            // BarCode
            // 
            resources.ApplyResources(this.BarCode, "BarCode");
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            // 
            // ItemName
            // 
            resources.ApplyResources(this.ItemName, "ItemName");
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sellingprice
            // 
            resources.ApplyResources(this.sellingprice, "sellingprice");
            this.sellingprice.Name = "sellingprice";
            this.sellingprice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Qty
            // 
            resources.ApplyResources(this.Qty, "Qty");
            this.Qty.Name = "Qty";
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // unit
            // 
            resources.ApplyResources(this.unit, "unit");
            this.unit.Name = "unit";
            // 
            // TotalPrice
            // 
            resources.ApplyResources(this.TotalPrice, "TotalPrice");
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.grdCart);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSaleQty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAvailableQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPaymentDue;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearchByItemName;
        private System.Windows.Forms.TextBox txtSearchByItemCode;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
     //   private dbImsDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView grdCart;
        private InventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private InventoryDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.TextBox textBarCode;
        private System.Windows.Forms.Label lblSearchByItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.RichTextBox txtTotal;
        private System.Windows.Forms.TextBox txtBalnace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNewBalance;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textUnit;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitnumber;
        private System.Windows.Forms.Button BtnSearchbyName;
        private System.Windows.Forms.Button BtnSearchbyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }

}