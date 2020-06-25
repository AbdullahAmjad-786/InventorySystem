namespace Inventory_System
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnProduct = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.btnPOS = new System.Windows.Forms.ToolStripButton();
            this.btnStockIn = new System.Windows.Forms.ToolStripButton();
            this.btnStaff = new System.Windows.Forms.ToolStripButton();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAndUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.POSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.urduToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inputLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.urduToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSearchByItemName = new System.Windows.Forms.TextBox();
            this.lblSearchByItem = new System.Windows.Forms.Label();
            this.txtSearchByItemCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSearchbyBarCode = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSearchbyName = new System.Windows.Forms.Button();
            this.StatusStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            resources.ApplyResources(this.StatusStrip1, "StatusStrip1");
            this.StatusStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel3,
            this.lblDate,
            this.ToolStripStatusLabel5,
            this.lblTimer});
            this.StatusStrip1.Name = "StatusStrip1";
            // 
            // ToolStripStatusLabel3
            // 
            resources.ApplyResources(this.ToolStripStatusLabel3, "ToolStripStatusLabel3");
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // ToolStripStatusLabel5
            // 
            resources.ApplyResources(this.ToolStripStatusLabel5, "ToolStripStatusLabel5");
            this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            this.ToolStripStatusLabel5.Click += new System.EventHandler(this.ToolStripStatusLabel5_Click);
            // 
            // lblTimer
            // 
            resources.ApplyResources(this.lblTimer, "lblTimer");
            this.lblTimer.Name = "lblTimer";
            // 
            // ToolStrip1
            // 
            resources.ApplyResources(this.ToolStrip1, "ToolStrip1");
            this.ToolStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1,
            this.btnProduct,
            this.ToolStripButton7,
            this.btnPOS,
            this.btnStockIn,
            this.btnStaff});
            this.ToolStrip1.Name = "ToolStrip1";
            // 
            // toolStripButton3
            // 
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.ForeColor = System.Drawing.Color.White;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // btnProduct
            // 
            resources.ApplyResources(this.btnProduct, "btnProduct");
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // ToolStripButton7
            // 
            resources.ApplyResources(this.ToolStripButton7, "ToolStripButton7");
            this.ToolStripButton7.ForeColor = System.Drawing.Color.White;
            this.ToolStripButton7.Name = "ToolStripButton7";
            this.ToolStripButton7.Click += new System.EventHandler(this.ToolStripButton7_Click);
            // 
            // btnPOS
            // 
            resources.ApplyResources(this.btnPOS, "btnPOS");
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Click += new System.EventHandler(this.ToolStripButton5_Click);
            // 
            // btnStockIn
            // 
            resources.ApplyResources(this.btnStockIn, "btnStockIn");
            this.btnStockIn.ForeColor = System.Drawing.Color.White;
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Click += new System.EventHandler(this.ToolStripButton6_Click);
            // 
            // btnStaff
            // 
            resources.ApplyResources(this.btnStaff, "btnStaff");
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::InventorySystem.Properties.Resources.c;
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // MenuStrip1
            // 
            resources.ApplyResources(this.MenuStrip1, "MenuStrip1");
            this.MenuStrip1.BackColor = System.Drawing.Color.White;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.RecordToolStripMenuItem,
            this.TransactionToolStripMenuItem,
            this.LanguageToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Name = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem1,
            this.staffToolStripMenuItem1,
            this.categoryToolStripMenuItem1,
            this.customerToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            resources.ApplyResources(this.FileToolStripMenuItem, "FileToolStripMenuItem");
            // 
            // productToolStripMenuItem1
            // 
            this.productToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProductToolStripMenuItem});
            this.productToolStripMenuItem1.Name = "productToolStripMenuItem1";
            resources.ApplyResources(this.productToolStripMenuItem1, "productToolStripMenuItem1");
            // 
            // updateProductToolStripMenuItem
            // 
            this.updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            resources.ApplyResources(this.updateProductToolStripMenuItem, "updateProductToolStripMenuItem");
            this.updateProductToolStripMenuItem.Click += new System.EventHandler(this.updateProductToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem1
            // 
            this.staffToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateStaffToolStripMenuItem});
            this.staffToolStripMenuItem1.Name = "staffToolStripMenuItem1";
            resources.ApplyResources(this.staffToolStripMenuItem1, "staffToolStripMenuItem1");
            // 
            // updateStaffToolStripMenuItem
            // 
            this.updateStaffToolStripMenuItem.Name = "updateStaffToolStripMenuItem";
            resources.ApplyResources(this.updateStaffToolStripMenuItem, "updateStaffToolStripMenuItem");
            this.updateStaffToolStripMenuItem.Click += new System.EventHandler(this.updateStaffToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem1
            // 
            this.categoryToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCategoryToolStripMenuItem});
            this.categoryToolStripMenuItem1.Name = "categoryToolStripMenuItem1";
            resources.ApplyResources(this.categoryToolStripMenuItem1, "categoryToolStripMenuItem1");
            // 
            // updateCategoryToolStripMenuItem
            // 
            this.updateCategoryToolStripMenuItem.Name = "updateCategoryToolStripMenuItem";
            resources.ApplyResources(this.updateCategoryToolStripMenuItem, "updateCategoryToolStripMenuItem");
            this.updateCategoryToolStripMenuItem.Click += new System.EventHandler(this.updateCategoryToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAndUpdateToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            resources.ApplyResources(this.customerToolStripMenuItem, "customerToolStripMenuItem");
            // 
            // viewAndUpdateToolStripMenuItem
            // 
            this.viewAndUpdateToolStripMenuItem.Name = "viewAndUpdateToolStripMenuItem";
            resources.ApplyResources(this.viewAndUpdateToolStripMenuItem, "viewAndUpdateToolStripMenuItem");
            this.viewAndUpdateToolStripMenuItem.Click += new System.EventHandler(this.viewAndUpdateToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            resources.ApplyResources(this.ExitToolStripMenuItem, "ExitToolStripMenuItem");
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // RecordToolStripMenuItem
            // 
            this.RecordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaffToolStripMenuItem,
            this.CategoryToolStripMenuItem,
            this.ProductToolStripMenuItem});
            this.RecordToolStripMenuItem.Name = "RecordToolStripMenuItem";
            resources.ApplyResources(this.RecordToolStripMenuItem, "RecordToolStripMenuItem");
            // 
            // StaffToolStripMenuItem
            // 
            this.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem";
            resources.ApplyResources(this.StaffToolStripMenuItem, "StaffToolStripMenuItem");
            this.StaffToolStripMenuItem.Click += new System.EventHandler(this.StaffToolStripMenuItem_Click);
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            resources.ApplyResources(this.CategoryToolStripMenuItem, "CategoryToolStripMenuItem");
            this.CategoryToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem_Click);
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            resources.ApplyResources(this.ProductToolStripMenuItem, "ProductToolStripMenuItem");
            this.ProductToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // TransactionToolStripMenuItem
            // 
            this.TransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.POSToolStripMenuItem});
            this.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem";
            resources.ApplyResources(this.TransactionToolStripMenuItem, "TransactionToolStripMenuItem");
            // 
            // POSToolStripMenuItem
            // 
            this.POSToolStripMenuItem.Name = "POSToolStripMenuItem";
            resources.ApplyResources(this.POSToolStripMenuItem, "POSToolStripMenuItem");
            this.POSToolStripMenuItem.Click += new System.EventHandler(this.POSToolStripMenuItem_Click);
            // 
            // LanguageToolStripMenuItem
            // 
            this.LanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemLanguageToolStripMenuItem,
            this.inputLanguageToolStripMenuItem});
            this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
            resources.ApplyResources(this.LanguageToolStripMenuItem, "LanguageToolStripMenuItem");
            this.LanguageToolStripMenuItem.Click += new System.EventHandler(this.LanguageToolStripMenuItem_Click);
            // 
            // systemLanguageToolStripMenuItem
            // 
            this.systemLanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem1,
            this.urduToolStripMenuItem1});
            this.systemLanguageToolStripMenuItem.Name = "systemLanguageToolStripMenuItem";
            resources.ApplyResources(this.systemLanguageToolStripMenuItem, "systemLanguageToolStripMenuItem");
            // 
            // englishToolStripMenuItem1
            // 
            this.englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
            resources.ApplyResources(this.englishToolStripMenuItem1, "englishToolStripMenuItem1");
            this.englishToolStripMenuItem1.Click += new System.EventHandler(this.englishToolStripMenuItem1_Click);
            // 
            // urduToolStripMenuItem1
            // 
            this.urduToolStripMenuItem1.Name = "urduToolStripMenuItem1";
            resources.ApplyResources(this.urduToolStripMenuItem1, "urduToolStripMenuItem1");
            this.urduToolStripMenuItem1.Click += new System.EventHandler(this.urduToolStripMenuItem1_Click);
            // 
            // inputLanguageToolStripMenuItem
            // 
            this.inputLanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem2,
            this.urduToolStripMenuItem2});
            this.inputLanguageToolStripMenuItem.Name = "inputLanguageToolStripMenuItem";
            resources.ApplyResources(this.inputLanguageToolStripMenuItem, "inputLanguageToolStripMenuItem");
            // 
            // englishToolStripMenuItem2
            // 
            this.englishToolStripMenuItem2.Name = "englishToolStripMenuItem2";
            resources.ApplyResources(this.englishToolStripMenuItem2, "englishToolStripMenuItem2");
            this.englishToolStripMenuItem2.Click += new System.EventHandler(this.englishToolStripMenuItem2_Click);
            // 
            // urduToolStripMenuItem2
            // 
            this.urduToolStripMenuItem2.Name = "urduToolStripMenuItem2";
            resources.ApplyResources(this.urduToolStripMenuItem2, "urduToolStripMenuItem2");
            this.urduToolStripMenuItem2.Click += new System.EventHandler(this.urduToolStripMenuItem2_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            resources.ApplyResources(this.HelpToolStripMenuItem, "HelpToolStripMenuItem");
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            resources.ApplyResources(this.AboutToolStripMenuItem, "AboutToolStripMenuItem");
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            resources.ApplyResources(this.changePasswordToolStripMenuItem, "changePasswordToolStripMenuItem");
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // txtSearchByItemName
            // 
            resources.ApplyResources(this.txtSearchByItemName, "txtSearchByItemName");
            this.txtSearchByItemName.Name = "txtSearchByItemName";
            this.txtSearchByItemName.TextChanged += new System.EventHandler(this.txtSearchByItemName_TextChanged);
            // 
            // lblSearchByItem
            // 
            resources.ApplyResources(this.lblSearchByItem, "lblSearchByItem");
            this.lblSearchByItem.Name = "lblSearchByItem";
            // 
            // txtSearchByItemCode
            // 
            resources.ApplyResources(this.txtSearchByItemCode, "txtSearchByItemCode");
            this.txtSearchByItemCode.Name = "txtSearchByItemCode";
            this.txtSearchByItemCode.TextChanged += new System.EventHandler(this.txtSearchByItemCode_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // monthCalendar1
            // 
            resources.ApplyResources(this.monthCalendar1, "monthCalendar1");
            this.monthCalendar1.Name = "monthCalendar1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.LightSlateGray;
            this.label4.Name = "label4";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::InventorySystem.Properties.Resources.syntax;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // BtnSearchbyBarCode
            // 
            resources.ApplyResources(this.BtnSearchbyBarCode, "BtnSearchbyBarCode");
            this.BtnSearchbyBarCode.Name = "BtnSearchbyBarCode";
            this.BtnSearchbyBarCode.UseVisualStyleBackColor = true;
            this.BtnSearchbyBarCode.Click += new System.EventHandler(this.BtnSearchbyCode_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.productcode,
            this.productname,
            this.category,
            this.purchaseprice,
            this.sellingprice,
            this.Qty,
            this.unit,
            this.expirydate});
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseDoubleClick);
            // 
            // barcode
            // 
            resources.ApplyResources(this.barcode, "barcode");
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            // 
            // productcode
            // 
            resources.ApplyResources(this.productcode, "productcode");
            this.productcode.Name = "productcode";
            this.productcode.ReadOnly = true;
            // 
            // productname
            // 
            resources.ApplyResources(this.productname, "productname");
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            // 
            // category
            // 
            resources.ApplyResources(this.category, "category");
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // purchaseprice
            // 
            resources.ApplyResources(this.purchaseprice, "purchaseprice");
            this.purchaseprice.Name = "purchaseprice";
            this.purchaseprice.ReadOnly = true;
            // 
            // sellingprice
            // 
            resources.ApplyResources(this.sellingprice, "sellingprice");
            this.sellingprice.Name = "sellingprice";
            this.sellingprice.ReadOnly = true;
            // 
            // Qty
            // 
            resources.ApplyResources(this.Qty, "Qty");
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // unit
            // 
            resources.ApplyResources(this.unit, "unit");
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // expirydate
            // 
            resources.ApplyResources(this.expirydate, "expirydate");
            this.expirydate.Name = "expirydate";
            this.expirydate.ReadOnly = true;
            // 
            // BtnSearchbyName
            // 
            resources.ApplyResources(this.BtnSearchbyName, "BtnSearchbyName");
            this.BtnSearchbyName.Name = "BtnSearchbyName";
            this.BtnSearchbyName.UseVisualStyleBackColor = true;
            this.BtnSearchbyName.Click += new System.EventHandler(this.BtnSearchbyName_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.BtnSearchbyName);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSearchbyBarCode);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchByItemCode);
            this.Controls.Add(this.lblSearchByItem);
            this.Controls.Add(this.txtSearchByItemName);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Enter += new System.EventHandler(this.frmMain_Enter);
            this.Leave += new System.EventHandler(this.frmMain_Leave);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
        internal System.Windows.Forms.ToolStripStatusLabel lblDate;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel5;
        internal System.Windows.Forms.ToolStripStatusLabel lblTimer;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btnProduct;
        internal System.Windows.Forms.ToolStripButton btnPOS;
        internal System.Windows.Forms.ToolStripButton btnStockIn;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RecordToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem StaffToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TransactionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem POSToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripButton btnStaff;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateCategoryToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSearchByItemName;
        private System.Windows.Forms.Label lblSearchByItem;
        private System.Windows.Forms.TextBox txtSearchByItemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ToolStripButton toolStripButton3;
        internal System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAndUpdateToolStripMenuItem;
        internal System.Windows.Forms.ToolStripButton ToolStripButton7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ToolStripMenuItem LanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem urduToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inputLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem urduToolStripMenuItem2;
        private System.Windows.Forms.Button BtnSearchbyBarCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirydate;
        private System.Windows.Forms.Button BtnSearchbyName;
    }
}