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
    public partial class frmAddUpdateProduct : Form
    {
        int checkInt;
        double checkDouble;
        Int64 checkLong;
        Category add = new Category();
       
        public frmAddUpdateProduct()
        {
            InitializeComponent();
            cmbCategory.DataSource = add.selectcategory().Tables[0];

            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.DisplayMember = "categoryName";
            this.ActiveControl = txtBarcode;
            DateTime date = DateTime.Now;
           
   
           string date1 = DateTime.Now.ToString("dd-MM-yyyy");
          
            this.txtExpiryDate.Text = date1;
          

        }

        public void clearAll()
        {
            txtBarcode.Text = "";
            txtQty.Text = "";
            txtPPrice.Text = "";
            txtProductName.Text = "";
            txtProductNo.Text = "";
            txtUnit.Text = "";
            txtSellingPrice.Text = "";
        
            txtExpiryDate.Text = "";
            this.ActiveControl = txtBarcode;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please Enter Product Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtProductName.Focus();
            }
            else if (txtBarcode.Text == "")
            {
                MessageBox.Show("Please Enter Valid Barcode", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtBarcode.Focus();
            }
            else if (txtPPrice.Text == "" || !double.TryParse(txtPPrice.Text, out checkDouble) || Convert.ToDouble(txtPPrice.Text) <= 0)
            {
                MessageBox.Show("Please Enter valid Purchase Price", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtPPrice.Focus();
            }
            else if (txtSellingPrice.Text == "" || !double.TryParse(txtSellingPrice.Text, out checkDouble) || Convert.ToDouble(txtSellingPrice.Text) <= 0)
            {
                MessageBox.Show("Please Enter valid Selling Price", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtSellingPrice.Focus();
            }

            else if (txtQty.Text == "" || !int.TryParse(txtQty.Text, out checkInt) || Convert.ToInt32(txtQty.Text) <= 0)
            {
                MessageBox.Show("Please Enter valid No Of Cartons", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtQty.Focus();
            }
            else if (txtUnit.Text == "")
            {
                MessageBox.Show("Please Enter Quantity In Cartons", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtUnit.Focus();
            }
            else if (txtProductNo.Text == "" || !int.TryParse(txtProductNo.Text, out checkInt) || Convert.ToInt32(txtProductNo.Text) <= 0)
            {
                MessageBox.Show("Please Enter valid Product No", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtProductNo.Focus();
            }
            else if (cmbCategory.Text == "")
            {
                MessageBox.Show("Please Select category", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                cmbCategory.Focus();
            }
            
            else
            {

                Product product = new Product();
                if (product.checkBarCode(txtBarcode.Text))
                {
                    bool inserted = product.addProduct(txtProductName.Text, txtBarcode.Text,  txtPPrice.Text, txtSellingPrice.Text, txtQty.Text, txtUnit.Text, txtProductNo.Text, cmbCategory.Text,txtExpiryDate.Text);

                    if (inserted)
                    {
                        MessageBox.Show("Success","Information",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
                        clearAll();
                    }

                    else
                    {
                        MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    }
                }
                else{
                    MessageBox.Show("BarCode Already Exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);

                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();    

        }

        private void frmAddUpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void txtSellingPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void txtProductNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQtyInCarton_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExpiryDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
