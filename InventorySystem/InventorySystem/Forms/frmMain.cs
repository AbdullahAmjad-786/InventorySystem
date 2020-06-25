
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem;
using InventorySystem.Forms;
using InventorySystem.Classes;
using System.Globalization;
using System.Threading;

namespace Inventory_System
{
    public partial class frmMain : Form
    {
        DateTime date;
        PointOfSale pos;
        bool flag = true;
        
        public frmMain()
        {
            pos = new PointOfSale();
           
            date = new DateTime();
        //    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ur-PK");
            InitializeComponent();
            date = DateTime.Now;
            lblDate.Text = date.Date.ToString("dd-MM-yyyy");
            timer1.Start();
     

            dataGridView1.EnableHeadersVisualStyles = true;

            dataGridView1.DataSource = pos.getDataDashBoard().Tables[0];
            // dataGridView2.DataSource = pos.getBackupData()


            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Tahoma", 12F);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dataGridView2.RowsDefaultCellStyle.Font = new Font("Tahoma", 12F);
        }
     

        #region
        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.LoadData(dataGridView1);
            form.Show();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            frmAddUpdateProduct addproduct = new frmAddUpdateProduct();
            addproduct.Show();
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            frmStockIn addstock = new frmStockIn();
            addstock.Show();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            frmAddUpdateCategory addcategory = new frmAddUpdateCategory();
            addcategory.Show();

        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            p.WaitForInputIdle();
        }
        #endregion

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateProduct updateproduct = new frmUpdateProduct();//bAAT SUN PHLY

            updateproduct.Show();

        }

        private void updateStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStaffcs staff = new ViewStaffcs();
            staff.ShowDialog();
        }

        private void updateCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateCategory updatecategory = new frmUpdateCategory();//bAAT SUN PHLY

            updatecategory.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

       

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           

            dataGridView1.Columns["barcode"].HeaderText = "Bar Code";
            dataGridView1.Columns["productno"].HeaderText = "Product #";
            dataGridView1.Columns["productname"].HeaderText = "Prodcut Name";
            dataGridView1.Columns["category"].HeaderText = "Category";
            dataGridView1.Columns["expirydate"].HeaderText = "Expiray Date";
            dataGridView1.Columns["purchaseprice"].HeaderText = "Purchase Price";
            dataGridView1.Columns["sellingprice"].HeaderText = "Selling Price";
            dataGridView1.Columns["Qty"].HeaderText = "Quantity";
            dataGridView1.Columns["Unit"].HeaderText = "Unit";

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
             Application.Exit();
        }

        private void txtSearchByItemName_TextChanged(object sender, EventArgs e)
        {

            if(txtSearchByItemName.Text =="")
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }


           /* string searchValue = txtSearchByItemName.Text;

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[2].DataPropertyName + ", System.String) like '" + txtSearchByItemName.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
            string date1 = DateTime.Now.ToShortDateString();
            */
        /*    foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //  MessageBox.Show(""+ DateTime.Parse(TodayDate.ToString()) + DateTime.Parse(row.Cells[8].Value.ToString()));
                DateTime date2 = DateTime.Parse(row.Cells[8].Value.ToString()).Date;
                string temp = date2.ToShortDateString();

                if (Convert.ToInt32(row.Cells[9].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                if (DateTime.Parse(date1) >= DateTime.Parse(temp))
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }

            }*/

        }

        private void txtSearchByItemCode_TextChanged(object sender, EventArgs e)
        {

            if (txtSearchByItemCode.Text == "")
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }
            /*
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[1].DataPropertyName + ", System.String) like '" + txtSearchByItemCode.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
            string date1 = DateTime.Now.Date.ToShortDateString();
            */
            /*    foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    //  MessageBox.Show(""+ DateTime.Parse(TodayDate.ToString()) + DateTime.Parse(row.Cells[8].Value.ToString()));

                    DateTime date2 = DateTime.Parse(row.Cells[8].Value.ToString()).Date;
                    string temp = date2.ToShortDateString();

                    if (Convert.ToInt32(row.Cells[9].Value) == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    if (DateTime.Parse(date1) >= DateTime.Parse(temp))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }

                }*/

        }


        #region
        private void StaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateStaff addStaff = new frmAddUpdateStaff();//bAAT SUN PHLY

            addStaff.Show();
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCategory addcategory = new frmAddUpdateCategory();
            addcategory.Show();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateProduct addproduct = new frmAddUpdateProduct();
            addproduct.Show();
        }

        private void POSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmUpdateProduct p = new frmUpdateProduct();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string barcode = row.Cells[0].Value.ToString();
                string  productno= row.Cells[1].Value.ToString();
                string  productnumber= row.Cells[2].Value.ToString();
                string cat = row.Cells[3].Value.ToString();
            //    string unit = row.Cells[4].Value.ToString();
                string pur = row.Cells[4].Value.ToString();
                string sell = row.Cells[5].Value.ToString();
                string cartons = row.Cells[6].Value.ToString();
                string qtyIncartons = row.Cells[7].Value.ToString();
                string expiry= row.Cells[8].Value.ToString();
                //string avbqty = row.Cells[9].Value.ToString();

                p.doubleClick(productnumber, barcode, pur, sell,cat,cartons,qtyIncartons,productno, expiry);

            }
            p.ShowDialog();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }
            /*  BindingSource bs = new BindingSource();
              bs.DataSource = dataGridView1.DataSource;
              bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[0].DataPropertyName + ", System.String) like '" + textBox1.Text.Replace("'", "''") + "%'");
              dataGridView1.DataSource = bs;
              dataGridView1.Refresh();
              string date1 = DateTime.Now.ToShortDateString();
              */
            /*  foreach (DataGridViewRow row in dataGridView1.Rows)
              {
                  //  MessageBox.Show(""+ DateTime.Parse(TodayDate.ToString()) + DateTime.Parse(row.Cells[8].Value.ToString()));
                  DateTime date2 = DateTime.Parse(row.Cells[8].Value.ToString()).Date;
                  string temp = date2.ToShortDateString();

                  if (Convert.ToInt32(row.Cells[9].Value) == 0)
                  {
                      row.DefaultCellStyle.BackColor = Color.Red;
                  }
                  if (DateTime.Parse(date1) >= DateTime.Parse(temp))
                  {
                      row.DefaultCellStyle.BackColor = Color.LightGreen;
                  }

              }*/


        }

        private void frmMain_Leave(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //    NativeMethods.SetParent(p.MainWindowHandle, this.Handle);
        }

        private void frmMain_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            flag = true;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pos.getDataDashBoard().Tables[0];
            dataGridView1.Update();
            dataGridView1.Refresh();
            string date1 = DateTime.Now.ToString("MM/dd/yyyy");
           // string date1 = DateTime.Now.ToString("dd-MM-yyyy");
          /*  foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //  MessageBox.Show(""+ DateTime.Parse(TodayDate.ToString()) + DateTime.Parse(row.Cells[8].Value.ToString()));

                int year = DateTime.Parse(date1).ToLocalTime().Date.Year - DateTime.Parse(row.Cells[8].Value.ToString()).ToLocalTime().Date.Year;
                
                if (year > 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (year == 0)
                {
                    
     
                    int month = DateTime.ParseExact(date1, "MM/dd/yyyy", null, DateTimeStyles.None).Date.Month - DateTime.ParseExact(row.Cells[8].Value.ToString(), "MM/dd/yyyy", null, DateTimeStyles.None).Date.Month;
                    ;
                    if (month > 0)
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    else if (month == 0)
                    {
                        int day = DateTime.ParseExact(date1, "MM/dd/yyyy", null, DateTimeStyles.None).Date.Day - DateTime.ParseExact(row.Cells[8].Value.ToString(), "MM/dd/yyyy", null, DateTimeStyles.None).Date.Day;
                        if (day >= 0)
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
                if (Convert.ToInt32(row.Cells[9].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }*/
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            frmAddUpdateStaff staff = new frmAddUpdateStaff();
            staff.ShowDialog();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
                if (flag)
            {

                }
            }
        
        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            frmCustomer cust = new frmCustomer();
            cust.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePasswordcs change = new frmChangePasswordcs();
            change.ShowDialog();
        }

        private void viewAndUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateCustomer cust = new FrmUpdateCustomer();
            cust.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripStatusLabel5_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            frmAddUpdateStaff s = new frmAddUpdateStaff();
            s.ShowDialog();
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            frmAddUpdateCategory cat = new frmAddUpdateCategory();
            cat.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string date1 = DateTime.Now.ToString("dd/MM/yyyy");

           /* foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //  MessageBox.Show(""+ DateTime.Parse(TodayDate.ToString()) + DateTime.Parse(row.Cells[8].Value.ToString()));

                int year = DateTime.Parse(date1).Date.Year - DateTime.Parse(row.Cells[8].Value.ToString()).Date.Year;
                if (year>0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (year == 0)
                {


                    int month = DateTime.ParseExact(date1, "MM/dd/yyyy", null, DateTimeStyles.None).Date.Month - DateTime.ParseExact(row.Cells[8].Value.ToString(), "MM/dd/yyyy", null, DateTimeStyles.None).Date.Month;
                    ;
                    if (month > 0)
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    else if (month == 0)
                    {
                        int day = DateTime.ParseExact(date1, "MM/dd/yyyy", null, DateTimeStyles.None).Date.Day - DateTime.ParseExact(row.Cells[8].Value.ToString(), "MM/dd/yyyy", null, DateTimeStyles.None).Date.Day;
                        if (day >= 0)
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
                if (Convert.ToInt32(row.Cells[9].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }

            }*/
        }

        private void ToolStripButton7_Click(object sender, EventArgs e)
        {
            frmSales s = new frmSales();
            s.ShowDialog();
        }

        private void urduToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void LanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void englishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-GB");
            this.Controls.Clear();
            InitializeComponent();

            dataGridView1.EnableHeadersVisualStyles = true;

            dataGridView1.DataSource = pos.getDataDashBoard().Tables[0];


            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Tahoma", 12F);
        }

        private void urduToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ur-PK");
            this.Controls.Clear();
            InitializeComponent();

            dataGridView1.EnableHeadersVisualStyles = true;

            dataGridView1.DataSource = pos.getDataDashBoard().Tables[0];


            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Tahoma", 12F);
        }

        private void englishToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.EnglishName == "English (United States)")
                {
                    InputLanguage.CurrentInputLanguage = lang;
                }
                // Checkbox.Text += lang.Culture.EnglishName + '\n';
            }
        }

        private void urduToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.EnglishName == "Urdu (Pakistan)")
                {
                    InputLanguage.CurrentInputLanguage = lang;
                }
                // Checkbox.Text += lang.Culture.EnglishName + '\n';
            }
        }

        private void BtnSearchbyCode_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (textBox1.Text != "")
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                dataGridView2.Rows.Clear();
             
                for(int i=0;i<dataGridView1.Rows.Count;i++)
                {
                    if(dataGridView1.Rows[i].Cells[0].Value.ToString().StartsWith(textBox1.Text.ToString()))
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[temp].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                        dataGridView2.Rows[temp].Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                        dataGridView2.Rows[temp].Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                        dataGridView2.Rows[temp].Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value;
                        dataGridView2.Rows[temp].Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value;
                        dataGridView2.Rows[temp].Cells[5].Value = dataGridView1.Rows[i].Cells[5].Value;
                        dataGridView2.Rows[temp].Cells[6].Value = dataGridView1.Rows[i].Cells[6].Value;
                        dataGridView2.Rows[temp].Cells[7].Value = dataGridView1.Rows[i].Cells[7].Value;
                        dataGridView2.Rows[temp].Cells[8].Value = dataGridView1.Rows[i].Cells[8].Value;
                        temp++;
                    }
                }
            }
            else
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }


            string date1 = DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (txtSearchByItemCode.Text != "")
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                dataGridView2.Rows.Clear();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[2].Value.ToString().StartsWith(txtSearchByItemCode.Text.ToString()))
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[temp].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                        dataGridView2.Rows[temp].Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                        dataGridView2.Rows[temp].Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                        dataGridView2.Rows[temp].Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value;
                        dataGridView2.Rows[temp].Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value;
                        dataGridView2.Rows[temp].Cells[5].Value = dataGridView1.Rows[i].Cells[5].Value;
                        dataGridView2.Rows[temp].Cells[6].Value = dataGridView1.Rows[i].Cells[6].Value;
                        dataGridView2.Rows[temp].Cells[7].Value = dataGridView1.Rows[i].Cells[7].Value;
                        dataGridView2.Rows[temp].Cells[8].Value = dataGridView1.Rows[i].Cells[8].Value;
                        temp++;
                    }
                }
            }
            else
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }


            string date1 = DateTime.Now.ToShortDateString();
        }

        private void BtnSearchbyName_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (txtSearchByItemName.Text != "")
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                dataGridView2.Rows.Clear();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().StartsWith(txtSearchByItemName.Text.ToString()))
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[temp].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                        dataGridView2.Rows[temp].Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                        dataGridView2.Rows[temp].Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                        dataGridView2.Rows[temp].Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value;
                        dataGridView2.Rows[temp].Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value;
                        dataGridView2.Rows[temp].Cells[5].Value = dataGridView1.Rows[i].Cells[5].Value;
                        dataGridView2.Rows[temp].Cells[6].Value = dataGridView1.Rows[i].Cells[6].Value;
                        dataGridView2.Rows[temp].Cells[7].Value = dataGridView1.Rows[i].Cells[7].Value;
                        dataGridView2.Rows[temp].Cells[8].Value = dataGridView1.Rows[i].Cells[8].Value;
                        temp++;
                    }
                }
            }
            else
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }


            string date1 = DateTime.Now.ToShortDateString();
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmUpdateProduct p = new frmUpdateProduct();

            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                string barcode = row.Cells[0].Value.ToString();
                string productno = row.Cells[1].Value.ToString();
                string productnumber = row.Cells[2].Value.ToString();
                string cat = row.Cells[3].Value.ToString();
                //    string unit = row.Cells[4].Value.ToString();
                string pur = row.Cells[4].Value.ToString();
                string sell = row.Cells[5].Value.ToString();
                string cartons = row.Cells[6].Value.ToString();
                string qtyIncartons = row.Cells[7].Value.ToString();
                string expiry = row.Cells[8].Value.ToString();
                //string avbqty = row.Cells[9].Value.ToString();

                p.doubleClick(productnumber, barcode, pur, sell, cat, cartons, qtyIncartons, productno, expiry);

            }
            p.ShowDialog();
        }
    }
}
