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
    public partial class frmCustomer : Form
    {
        int checkInt;
        Int64 checkLong;
        Customer c=new Customer();
        public frmCustomer()
        {
            InitializeComponent();
            this.ActiveControl = txtContactNo;

        }
            //// Add Customer
            

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtContactNo.Text == "" || !Int64.TryParse(txtContactNo.Text, out checkLong) || Convert.ToInt64(txtContactNo.Text) <= 0)
            {
                MessageBox.Show("Enter Valid Contact Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtContactNo.Focus();
            }
            else if (txtFirstName.Text == "")
            {
                MessageBox.Show("Enter fist Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtFirstName.Focus();
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Enter Last Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtLastName.Focus();
            }
            else if (txtState.Text == "")
            {
                MessageBox.Show("Enter Address", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtState.Focus();
            }
            else if (txtCity.Text == "")
            {
                MessageBox.Show("Enter City", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtCity.Focus();
            }
            else if (txtBalance.Text == "" || !int.TryParse(txtBalance.Text, out checkInt))
            {
                MessageBox.Show("Enter Valid Balance", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtBalance.Focus();
            }
            else
            {
                if(c.addcustomer(txtFirstName.Text,txtLastName.Text,txtCity.Text,Convert.ToInt64(txtContactNo.Text),txtState.Text,txtBalance.Text))
                {
                    MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    txtBalance.Text = "";
                    txtCity.Text = "";
                    txtContactNo.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtState.Text = "";
                    this.ActiveControl = txtContactNo;

                }
                else
                {
                    MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    txtBalance.Text = "";
                    txtCity.Text = "";
                    txtContactNo.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtState.Text = "";
                    this.ActiveControl = txtContactNo;

                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
