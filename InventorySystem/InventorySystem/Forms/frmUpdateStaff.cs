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
    public partial class frmUpdateStaff : Form
    {
        int checkInt;
        Int64 checkLong;
        public frmUpdateStaff()
        {
            InitializeComponent();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Staff staff = new Staff();
          //  staff.deleteStaff(staff.getStaffID());
            bool inserted = true; //staff.deleteStaff(txtStaffID.Text);

            

             if (inserted)
             {
                 MessageBox.Show("Successfully Deleted Staff", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                 txtBarangay.Text = "";
                txtCity.Text = "";
                txtContactNo.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtMI.Text = "";
                txtProvince.Text = "";
                txtStreet.Text = "";
                txtUsername.Text = "";
              //  txtStaffID.Text = "";
                txtRole.Text = "";
                this.Close();
            }

             else
             {
                 MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
             }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         
                /*
                Staff staff = new Staff();
                DataSet ds = staff.selectStaff(txtStaffID.Text);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("This Staff Id do not exist");
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
                    //
                    txtBarangay.ReadOnly = false;
                    txtCity.ReadOnly = false;
                    txtContactNo.ReadOnly = false;
                    txtFirstName.ReadOnly = false;
                    txtLastName.ReadOnly = false;
                    txtMI.ReadOnly = false;
                    txtProvince.ReadOnly = false;
                    txtStreet.ReadOnly = false;
                    txtUsername.ReadOnly = false;
                    btnGetData.Enabled = false;
                    txtStaffID.ReadOnly = true;
                }
                */
            
        }

        public void doubleClick(string fname, string lname, string contact, string city, string username, string mid, string street, string barangy, string province)
        {

            txtBarangay.Text = barangy;
            txtCity.Text = city;
            txtContactNo.Text = contact;
            txtFirstName.Text = fname;
            txtLastName.Text = lname;
            txtMI.Text = mid;
            txtProvince.Text = province;
            txtStreet.Text = street;
            txtUsername.Text = username;
            Login l = new Login();
            txtRole.Text=l.type(username);

        }

        private void btnSave_Click_1(object sender, EventArgs e)
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
            else if (txtStreet.Text == "" || !int.TryParse(txtStreet.Text, out checkInt) || Convert.ToInt32(txtStreet.Text) <= 0)
            {
                MessageBox.Show("Please Enter valid Street no", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtStreet.Focus();
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
            else
            {
                Staff updstaff = new Staff();
               // updstaff.updateStaff(txtStaffID.Text, txtFirstName.Text, txtLastName.Text, txtMI.Text, txtStreet.Text, txtBarangay.Text, txtCity.Text, txtProvince.Text, txtContactNo.Text, txtUsername.Text, txtRole.Text);
            }
        }

        private void txtRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
