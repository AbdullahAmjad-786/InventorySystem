using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace InventorySystem.Classes
{
    class sales
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public DataSet getByDate(string date1,string date2)
            {
            DateTime d1 = DateTime.Parse(date1).Date;
            string temp1 = d1.ToShortDateString();
            DateTime d2 = DateTime.Parse(date2).Date;
            string temp2 = d2.ToShortDateString();

            string query = "Select  invoice.InvoiceID,InvoiceDate,customerName,invoice.CustomerID,barcode as ProductName,SellingPrice,qty,grandTotal FROM [dbo].[invoice],[dbo].[sales] Where invoice.InvoiceID = sales.invoiceID  AND invoice.InvoiceDate >= '" + temp1+ "' AND  invoice.InvoiceDate <='"+temp2+ "' order by customerName ";
          //  string query = "Select  invoice.InvoiceID,InvoiceDate,customerName,invoice.CustomerID,barcode,qty,grandTotal FROM [dbo].[invoice],[dbo].[sales]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            return ds;
            
            
            }

        public string barcode(string date1, string date2)
        {


        

            string query = "Select TOP 1 sales.barcode from invoice,sales Where invoice.InvoiceID = sales.invoiceID  AND invoice.InvoiceDate >= '" + date1 + "' AND  invoice.InvoiceDate <='" + date2 + "'   GROUP BY sales.barcode ORDER BY COUNT(*) DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                return row["barcode"].ToString();
            }
            return "";
        }

    }

}

