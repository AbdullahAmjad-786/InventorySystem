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
    public partial class frmPrintReport : Form
    {
        public frmPrintReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmPrintReport_Load(object sender, EventArgs e)
        {

        }

        public void SetReportParameters(string Title,string date,string time,string InvoiceNo,string CstName,string CstAddress,string total,DataGridView data)
        {
            receipt1.Database.Tables["ProdcutsData"].SetDataSource(SetTableData(data));
            //receipt1.SetDataSource(data.DataSource);
            receipt1.SetParameterValue("pTitle", Title);
            receipt1.SetParameterValue("pDate", date);
            receipt1.SetParameterValue("pTime", time);
            receipt1.SetParameterValue("pInvoiceNo", InvoiceNo);
            receipt1.SetParameterValue("pCustomerName", CstName);
            receipt1.SetParameterValue("pCustomerAddress", CstAddress);
            receipt1.SetParameterValue("pTotal", total);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = receipt1;
            crystalReportViewer1.Refresh();
        }

        public DataTable SetTableData(DataGridView data)
        {
            DataTable Product = new DataTable();
            Product.Columns.Add("ProductName", typeof(string));
            Product.Columns.Add("Qty", typeof(string));
            Product.Columns.Add("Price", typeof(string));
            Product.Columns.Add("Unit", typeof(string));
            Product.Columns.Add("Amount", typeof(string));

            for(int i=0;i<data.RowCount;i++)
            {
                Product.Rows.Add(data.Rows[i].Cells[1].Value.ToString(), data.Rows[i].Cells[0].Value.ToString(), data.Rows[i].Cells[2].Value.ToString(), data.Rows[i].Cells[3].Value.ToString(), data.Rows[i].Cells[4].Value.ToString());
            }
            return Product;
        }
    }
}
