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
    public partial class FrmUpdateCustomer : Form
    {

        Customer c = new Customer();
        public FrmUpdateCustomer()
        {
            InitializeComponent();
            dataGridView1.DataSource = c.getCustomerData().Tables[0];
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Tahoma", 13F);
         
        }





        private void txtSearchByItemCode_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[0].DataPropertyName + ", System.String) like '" + txtSearchByItemCode.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();

        }

        private void txtSearchByItemName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[1].DataPropertyName + ", System.String) like '" + txtSearchByItemName.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();


        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dataGridView1.Columns["customerFirstName"].HeaderText = "First Name";
            dataGridView1.Columns["customerLastName"].HeaderText = "Last Name";
            dataGridView1.Columns["customerContactNumber"].HeaderText = "Contact Number";
            dataGridView1.Columns["customerCity"].HeaderText = "City";
            dataGridView1.Columns["Address"].HeaderText = "Address ";

            dataGridView1.Columns["Balance"].HeaderText = "Balance";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                string b = Convert.ToString(item.Cells["customerContactNumber"].Value);
               
                if (c.deleteStaff(Convert.ToInt64(b)))
                {
                    MessageBox.Show("Succefully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    dataGridView1.Rows.RemoveAt(item.Index);

                }
                else
                {
                    MessageBox.Show("Can Not Delete. Please Try Again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);

                }

            }


        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow select = dataGridView1.Rows[selectedrowindex];
            string contact = Convert.ToString(select.Cells["customerContactNumber"].Value);

            string customerFname, customerLname, city, balance, state;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "customerFirstName" || dataGridView1.Columns[e.ColumnIndex].Name == "customerLastName" || dataGridView1.Columns[e.ColumnIndex].Name == "Address" || dataGridView1.Columns[e.ColumnIndex].Name == "customerCity" || dataGridView1.Columns[e.ColumnIndex].Name == "Balance" )
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                customerFname = Convert.ToString(selectedRow.Cells["customerFirstName"].Value);

                customerLname = Convert.ToString(selectedRow.Cells["customerLastName"].Value);
                state = Convert.ToString(selectedRow.Cells["Address"].Value);

                
                city = Convert.ToString(selectedRow.Cells["customerCity"].Value);

                
                
                balance = Convert.ToString(selectedRow.Cells["Balance"].Value);
                c.updateCustomer(customerFname,customerLname,city,Convert.ToInt64(contact),state,balance);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = c.getCustomerData().Tables[0];

            }


        }
    }
}
