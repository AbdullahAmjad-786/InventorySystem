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

namespace Inventory_System
{
    
    public partial class frmAddUpdateCategory : Form
    {
      //  int checkInt;
        Category add = new Category();

        public frmAddUpdateCategory()
        {
            InitializeComponent();
            comboBox1.DataSource = add.selectcategory().Tables[0];
            
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DisplayMember = "categoryName";
                        this.ActiveControl = txtCatName;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
         
            if (txtCatName.Text == "")
            {
                MessageBox.Show("Please Select Category Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtCatName.Focus();
            }
            else
            {
                if (add.checkCategory(txtCatName.Text.ToUpper()))
                {

                    if (add.addcategory(txtCatName.Text.ToUpper(), txtCatDescription.Text))
                    {
                        MessageBox.Show("Succefully Added ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                        comboBox1.DataSource = null;
                        comboBox1.DataSource = add.selectcategory().Tables[0];
                        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                        comboBox1.DisplayMember = "categoryName";
                        comboBox1.Refresh();
                        comboBox1.Update();

                        this.Refresh();
                        clearall();
                    }
                }
                else
                {
                    MessageBox.Show("Already In the Database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    clearall();
                }   
            }
        }

        public void clearall()
        {
            txtCatName.Text = "";
            txtCatDescription.Text = "";
        }

   
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
        private void frmAddUpdateCategory_Load(object sender, EventArgs e)
        {
        }
    }
}
