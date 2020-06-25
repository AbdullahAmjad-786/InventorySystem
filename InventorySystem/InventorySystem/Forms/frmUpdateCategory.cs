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

namespace InventorySystem.Forms
{
    public partial class frmUpdateCategory : Form
    {

        Category add =new Category();
        public frmUpdateCategory()
        {
            InitializeComponent();
            comboBox1.DataSource = add.selectcategory().Tables[0];

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DisplayMember = "categoryName";
            
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
             Category categ= new Category();
                DataSet ds = categ.selectcategory(comboBox1.Text);
               
                if (ds.Tables[0].Rows.Count==0)
                {
                    MessageBox.Show("This Category does not exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                }


                else
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    txtCatName.Text = row["categoryName"].ToString();
                    txtCatDescription.Text = row["categoryDescription"].ToString();
                }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtCatName.Text == "")
            {
                MessageBox.Show("Please Select Category Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtCatName.Focus();
            }
            else
            {
                int id = add.selectCategory(comboBox1.Text);
                if (add.updatecategory(txtCatName.Text.ToUpper(), txtCatDescription.Text,id))
                {

                   
                        MessageBox.Show("Succefully Updated ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                        comboBox1.DataSource = null;
                        comboBox1.DataSource = add.selectcategory().Tables[0];
                        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                        comboBox1.DisplayMember = "categoryName";
                        comboBox1.Refresh();
                        comboBox1.Update();

                        this.Refresh();
                        clearall();
                    
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
