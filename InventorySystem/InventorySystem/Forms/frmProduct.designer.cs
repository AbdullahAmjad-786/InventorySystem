namespace Inventory_System
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.lblSearch = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(690, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 35;
            this.lblSearch.Text = "Search";
            this.lblSearch.Visible = false;
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.Color.White;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7,
            this.ColumnHeader8,
            this.ColumnHeader9,
            this.ColumnHeader10,
            this.ColumnHeader11});
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(0, 40);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(1123, 411);
            this.ListView1.TabIndex = 34;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Product No. ";
            this.ColumnHeader4.Width = 80;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Item Code";
            this.ColumnHeader5.Width = 141;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Product Description";
            this.ColumnHeader6.Width = 290;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Barcode";
            this.ColumnHeader7.Width = 106;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "Category";
            this.ColumnHeader8.Width = 110;
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.Text = "Unit Price";
            this.ColumnHeader9.Width = 98;
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.Text = "Stocks on Hand";
            this.ColumnHeader10.Width = 95;
            // 
            // ColumnHeader11
            // 
            this.ColumnHeader11.Text = "Reorder Level";
            this.ColumnHeader11.Width = 85;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AutoSize = false;
            this.ToolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabel1,
            this.ToolStripButton4,
            this.ToolStripButton3,
            this.ToolStripButton2,
            this.ToolStripButton5,
            this.ToolStripButton1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1123, 40);
            this.ToolStrip1.TabIndex = 33;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(16, 37);
            this.ToolStripLabel1.Text = "   ";
            // 
            // ToolStripButton4
            // 
            this.ToolStripButton4.AutoSize = false;
            this.ToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton4.Image")));
            this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton4.Name = "ToolStripButton4";
            this.ToolStripButton4.Size = new System.Drawing.Size(65, 40);
            this.ToolStripButton4.Text = "&New";
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.AutoSize = false;
            this.ToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton3.Image")));
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(65, 40);
            this.ToolStripButton3.Text = "&Update";
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.AutoSize = false;
            this.ToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton2.Image")));
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(65, 40);
            this.ToolStripButton2.Text = "&Search";
            // 
            // ToolStripButton5
            // 
            this.ToolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton5.Image")));
            this.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton5.Name = "ToolStripButton5";
            this.ToolStripButton5.Size = new System.Drawing.Size(71, 37);
            this.ToolStripButton5.Text = "S&tock-In";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.AutoSize = false;
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(65, 40);
            this.ToolStripButton1.Text = "Clos&e";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 451);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblSearch;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.ColumnHeader ColumnHeader6;
        internal System.Windows.Forms.ColumnHeader ColumnHeader7;
        internal System.Windows.Forms.ColumnHeader ColumnHeader8;
        internal System.Windows.Forms.ColumnHeader ColumnHeader9;
        internal System.Windows.Forms.ColumnHeader ColumnHeader10;
        internal System.Windows.Forms.ColumnHeader ColumnHeader11;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton4;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.ToolStripButton ToolStripButton5;
        internal System.Windows.Forms.ToolStripButton ToolStripButton1;
    }
}