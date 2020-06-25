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
    public partial class frmSales : Form
    {
        sales s = new sales();
        Product p = new Product();
        public frmSales()
        {

            InitializeComponent();
            string date1 = DateTime.Now.ToString("MM-dd-yyyy");
            txtDateFrom.Text = date1;
            txtDateTo.Text = date1;
            dataGridView1.EnableHeadersVisualStyles = true;

            dataGridView1.ReadOnly = true;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Tahoma", 12F);


        }

        private void frmSales_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDateTo.Text!="" && txtDateFrom.Text !="")
            { 
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = s.getByDate(txtDateFrom.Text, txtDateTo.Text).Tables[0];
            int count = dataGridView1.Rows.Count - 1;
            txtTotalRecords.Text = count.ToString();
            txtTotalBlance.Text = CellSum().ToString();
            string barcode=s.barcode(txtDateFrom.Text, txtDateTo.Text);
                txtBarCode.Text = barcode;
                txtItemName.Text = p.getProductName(barcode);


            }
        }



        private double CellSum()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count-1; ++i)
            {

                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value.ToString());
                
            }
            return sum;
        }
    }
}
