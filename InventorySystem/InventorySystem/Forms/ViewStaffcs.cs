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
    public partial class ViewStaffcs : Form
    {
        Staff s = new Staff();
        string fname;
        string lname;
        string city; string province;
        string contact;
        string username;
        string mid;
        string street;
        string state;
        public ViewStaffcs()
        {
            InitializeComponent();
            dataGridView1.DataSource= s.selectStaff().Tables[0];
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Tahoma", 12F);

        }

      

        private void txtSearchByItemName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[3].DataPropertyName + ", System.String) like '" + txtSearchByItemName.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchByItemCode_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[5].DataPropertyName + ", System.String) like '" + txtSearchByItemCode.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
              /*  frmUpdateStaff p = new frmUpdateStaff();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string fname = row.Cells[0].Value.ToString();
                string lname = row.Cells[1].Value.ToString();
                string city = row.Cells[3].Value.ToString();
                string province = row.Cells[4].Value.ToString();
                string contact = row.Cells[4].Value.ToString();
                string username = row.Cells[5].Value.ToString();


                DataSet ds = new DataSet();
                    ds=s.getStaffData(contact, fname);

                string mid="";
                    string street = "";
                       string barangy = "";
                    
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                     mid = r["mid"].ToString();
                     street = r["street"].ToString();
                     barangy = r["barangy"].ToString();
                }
                


                   p.doubleClick(fname, lname, contact, city, username, mid, street, barangy, province);

            }
            p.ShowDialog();
            */
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns["SId"].HeaderText = "Staff ID";
            dataGridView1.Columns["SId"].ReadOnly = true;

            dataGridView1.Columns["fname"].HeaderText = "First Name";
            dataGridView1.Columns["lname"].HeaderText = "Last Name";
            dataGridView1.Columns["contact"].HeaderText = "Contact Number";
            dataGridView1.Columns["city"].HeaderText = "City";
            dataGridView1.Columns["username"].HeaderText = "UserName";
            dataGridView1.Columns["mid"].HeaderText = "MID";
            dataGridView1.Columns["state"].HeaderText = "State ";

            dataGridView1.Columns["province"].HeaderText = "Province";
          
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow select = dataGridView1.Rows[selectedrowindex];
            string sid = Convert.ToString(select.Cells["SId"].Value);
         

            if (dataGridView1.Columns[e.ColumnIndex].Name == "fname" || dataGridView1.Columns[e.ColumnIndex].Name == "lname" || dataGridView1.Columns[e.ColumnIndex].Name == "contact" || dataGridView1.Columns[e.ColumnIndex].Name == "city" || dataGridView1.Columns[e.ColumnIndex].Name == "username" || dataGridView1.Columns[e.ColumnIndex].Name == "mid" || dataGridView1.Columns[e.ColumnIndex].Name == "province")
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                fname = Convert.ToString(selectedRow.Cells["fname"].Value);

                lname = Convert.ToString(selectedRow.Cells["lname"].Value);
                state = Convert.ToString(selectedRow.Cells["state"].Value);

                contact = Convert.ToString(selectedRow.Cells["contact"].Value);

                city = Convert.ToString(selectedRow.Cells["city"].Value);

                username = Convert.ToString(selectedRow.Cells["username"].Value);

                mid = Convert.ToString(selectedRow.Cells["mid"].Value);

                province = Convert.ToString(selectedRow.Cells["province"].Value);
                s.updateStaff(sid, fname,lname,mid,state,city,province,contact,username);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = s.selectStaff().Tables[0];

            }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                string b = Convert.ToString(item.Cells["SId"].Value);
                if (s.deleteStaff(b))
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

        private void lblSearchByItem_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
