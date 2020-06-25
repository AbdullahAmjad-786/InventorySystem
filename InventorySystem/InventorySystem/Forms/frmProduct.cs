using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class frmProduct : Form
    {
        public bool adding;

        public bool updating;
        public void LoadProducts()
        {
            try
            {
              //  sqL = "SELECT ProductNo, ProductCOde, P.Description, Barcode, UnitPrice, StocksOnHand, ReorderLevel, CategoryName FROM Product as P, Category as C WHERE C.CategoryNo = P.CategoryNo AND P.Description LIKE '" + lblSearch.Text + "%'";
              //  ConnDB();
               // cmd = new MySqlCommand(sqL, conn);
               // dr = cmd.ExecuteReader();

                ListViewItem x = default(ListViewItem);
                ListView1.Items.Clear();


                //while (dr.Read == true)
                //{
                //    //x = new ListViewItem(dr("ProductNo").ToString);
                //    //x.SubItems.Add(dr("ProductCode"));
                //    //x.SubItems.Add(dr("Description"));
                //    //x.SubItems.Add(dr("Barcode"));
                //    //x.SubItems.Add(dr("CategoryName"));
                //    //x.SubItems.Add(Strings.Format(dr("UnitPrice"), "#,##0.00"));
                //    //x.SubItems.Add(dr("StocksOnHand"));
                //    //x.SubItems.Add(dr("ReOrderLevel"));

                //    ListView1.Items.Add(x);
                //}
            }
            catch (Exception ex)
            {
                //Interaction.MsgBox(ex.ToString);
            }
            finally
            {
              //  cmd.Dispose();
             //   conn.Close();
            }
        }

        private void frmProduct_Load(System.Object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ToolStripButton1_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButton4_Click(System.Object sender, System.EventArgs e)
        {
            adding = true;
            updating = false;
          //  frmAddUpdateProduct.ShowDialog();
        }

        private void ToolStripButton3_Click(System.Object sender, System.EventArgs e)
        {
            if (ListView1.Items.Count == 0)
            {
                MessageBox.Show("Please select record to update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                return;
            }
            try
            {

                if (string.IsNullOrEmpty(ListView1.FocusedItem.Text))
                {
                }
                else {
                    adding = false;
                    updating = true;
              //      frmAddUpdateProduct.ShowDialog();
                }


            }
            catch (Exception ex)
            {
            }


        }

        private void ToolStripButton2_Click(System.Object sender, System.EventArgs e)
        {
          //  lblSearch.Text = Interaction.InputBox("Enter Product Decription :", "Product Search");
            LoadProducts();
        }

        private void ToolStripButton5_Click(System.Object sender, System.EventArgs e)
        {
            if (ListView1.Items.Count == 0)
            {
            //    Interaction.MsgBox("Please select product or item to add stocks.", MsgBoxStyle.Exclamation, "Add Stocks");
                return;
            }

            try
            {
              //  frmStockIn.ShowDialog();

            }
            catch (Exception ex)
            {
            }

        }

    }
}
