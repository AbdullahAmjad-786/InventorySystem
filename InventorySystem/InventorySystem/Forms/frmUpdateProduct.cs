using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Classes;
namespace InventorySystem.Forms
{
    public partial class frmUpdateProduct : Form
    {
        Category add = new Category();
        Product p = new Product();
        public frmUpdateProduct()
        {
            InitializeComponent();
            cmbCategory.DataSource = add.selectcategory().Tables[0];
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.DisplayMember = "categoryName";
            this.btnSave.Enabled = false;
            this.button1.Enabled = false;
        }

        public void doubleClick(string pName, string barcode, string purhcaseP, string SellingP, string cat, string noOfCartoons, string qtyIncartons,string pNO, string expiraryDate)
        {
            txtProductName.Text = pName;
            txtBarcode.Text = barcode;
            txtExpiryDate.Text = expiraryDate;
            txtPPrice.Text = purhcaseP;
            txtSellingPrice.Text = SellingP;
            txtQty.Text = noOfCartoons;
            txtUnit.Text = qtyIncartons;
            // txtReorderLevel.Text = "";
            cmbCategory.Text = cat;
            txtProductNo.Text = pNO;
            this.btnSave.Enabled = true;
            this.button1.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (p.updateProduct(txtProductName.Text, txtBarcode.Text,  txtPPrice.Text, txtSellingPrice.Text, txtQty.Text, txtUnit.Text, txtProductNo.Text, cmbCategory.Text, txtExpiryDate.Text))
            {
                MessageBox.Show("Succesfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                txtProductName.Text = "";
                txtBarcode.Text = "";
                txtExpiryDate.Text = "";
                txtPPrice.Text = "";
                txtSellingPrice.Text = "";
                txtQty.Text = "";
                txtUnit.Text = "";
                txtProductNo.Text = "";
                cmbCategory.Text = "";
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            bool inserted = product.deleteProduct(txtProductNo.Text, txtBarcode.Text);

            if (inserted)
            {
                MessageBox.Show("Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                txtProductName.Text = "";
                txtBarcode.Text = "";
                txtProductNo.Text = "";
                //txtUnitPrice.Text = "";
                txtPPrice.Text = "";
                txtSellingPrice.Text = "";
                txtQty.Text = "";
                txtUnit.Text = "";
              //  txtReorderLevel.Text = "";
                cmbCategory.Text = "";

            }

            else
            {
                MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
        }
    }





}
