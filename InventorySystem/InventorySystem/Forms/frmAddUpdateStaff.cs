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
    public partial class frmAddUpdateStaff : Form
    {
        int checkInt;
        Int64 checkLong;
        Staff staff = new Staff();

        public frmAddUpdateStaff()
        {
            InitializeComponent();
            txtStaffID.Text = staff.getStaffID().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void clearAll()
        {
            txtBarangay.Text = "";
            txtCity.Text = "";
            txtConfirmPassword.Text = "";
            txtContactNo.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMI.Text = "";
            txtPassword.Text = "";
            txtProvince.Text = "";
            txtRole.Text = "";
            txtStaffID.Text = "";
            //txtStreet.Text = "";
            txtUsername.Text = "";
            txtUsername.Text = "";
            this.ActiveControl = txtStaffID;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
             if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please Enter First Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtFirstName.Focus();
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Please Enter  Last Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtFirstName.Focus();
            }
            else if (txtCity.Text == "")
            {
                MessageBox.Show("Please Enter City name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtCity.Focus();
            }
            else if (txtContactNo.Text == "" || !Int64.TryParse(txtContactNo.Text, out checkLong) || Convert.ToInt64(txtContactNo.Text) <= 0)
            {
                MessageBox.Show("Please Enter valid Contact no", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtContactNo.Focus();
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter User Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtUsername.Focus();
            }
            else if (txtRole.Text == "")
            {
                MessageBox.Show("Please Select Roll", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtRole.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtPassword.Focus();
            }
            else if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please Confirm your Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtConfirmPassword.Focus();
            }
            else if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Confirm Password does not match your password. Enter again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtConfirmPassword.Focus();
            }
            else
            {
                Login log = new Login();
                if (log.checklogin(txtUsername.Text))
                {
                    if (staff.addStaff(txtStaffID.Text, txtFirstName.Text, txtLastName.Text, txtMI.Text, txtBarangay.Text, txtCity.Text, txtProvince.Text, txtContactNo.Text, txtUsername.Text, txtRole.Text, txtPassword.Text, txtConfirmPassword.Text))
                    {
                        MessageBox.Show("Successfully Added !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                        clearAll();
                        txtStaffID.Text = staff.getStaffID().ToString();

                    }
                    else
                        MessageBox.Show("Error!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                }
                else
                {
                    MessageBox.Show("User Name Already Exists!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ustaff()
        {
            Staff staff = new Staff();
            /* bool inserted = staff.deleteStaff(txtStaffID.Text);

             if (inserted)
             {
                 MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
             }

             else
             {
                 MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
             }*/
            /*

                        DataSet ds = staff.selectStaff(txtStaffID.Text);
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("This Staff Id do not exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                        }
                        else
                        {
                            DataRow row = ds.Tables[0].Rows[0];
                            txtBarangay.Text = row["barangy"].ToString();
                            txtCity.Text = row["city"].ToString();
                            txtContactNo.Text = row["contact"].ToString();
                            txtFirstName.Text = row["fname"].ToString();
                            txtLastName.Text = row["lname"].ToString();
                            txtMI.Text = row["mid"].ToString();
                            txtProvince.Text = row["province"].ToString();
                            txtStreet.Text = row["street"].ToString();
                            txtUsername.Text = row["username"].ToString();
                            txtRole.Text = row["type"].ToString();
                        }
                        */
        }
    }
}
