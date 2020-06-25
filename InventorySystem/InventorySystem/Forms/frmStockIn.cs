using InventorySystem.Classes;
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
    public partial class frmStockIn : Form
    {
        int checkInt;
        double checkDouble;
        public frmStockIn()
        {
            InitializeComponent();
            this.ActiveControl = txtBarCode;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBarCode.Text == "")
            {
                MessageBox.Show("Please Enter valid Bar Code", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtBarCode.Focus();
            }
            else if (txtUnitPrice.Text == "" || !double.TryParse(txtUnitPrice.Text, out checkDouble) || Convert.ToDouble(txtUnitPrice.Text) <= 0)
            {
                MessageBox.Show("Please Enter valid Selling Price", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtUnitPrice.Focus();
            }
            else if (txtQuantity.Text == "" || !int.TryParse(txtQuantity.Text, out checkInt) || Convert.ToInt32(txtQuantity.Text) <= 0)
            {
                MessageBox.Show("Please Enter valid Quantity", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtQuantity.Focus();
            }
            else
            {
                Stock stock = new Stock();
                if (stock.addStock(txtBarCode.Text,txtUnitPrice.Text,txtCurrentStocks.Text,txtQuantity.Text,txtTotalStocks.Text ))
                {
                    MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

                }
                else
                {
                    MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                }
                
            }
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarCode.Text!="")
            {
                Stock stock = new Stock();
                DataRow row = stock.getCurrent(txtBarCode.Text);
                txtCurrentStocks.Text = row["noofcartons"].ToString();
                txtUnitPrice.Text = row["sellingprice"].ToString();
            }
        }
        private void txtNew_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text != "")
            txtTotalStocks.Text = (Convert.ToInt32(txtCurrentStocks.Text) + Convert.ToInt32(txtQuantity.Text)).ToString();

        }
        private void frmStockIn_Load(object sender, EventArgs e)
        {

        }

        private void txtCurrentStocks_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
