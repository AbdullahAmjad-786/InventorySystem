using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace InventorySystem.Classes
{
    class Stock
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public DataRow getCurrentP(string product)
        {

            DataRow row = null;
            try
            {

                string qury = "Select qtyincartons,sellingprice,noofcartons,totalqty from [dbo].[product] where productno='" + product + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(qury, connectionString);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                row = ds.Tables[0].Rows[0];
                return row;

            }
            catch (Exception db)
            {
                return row;
            }


        }

        public DataRow getCurrent(string barCode)
        {

            DataRow row=null;
            try {

                string qury = "Select productname,sellingprice,noofcartons,totalqty,qtyincartons from [dbo].[product] where barcode='" + barCode + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(qury, connectionString);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                row = ds.Tables[0].Rows[0];
                return row;

            }
            catch (Exception db)
            {
                return row;
            }


        }

        public bool addStock(string barCode, string unitprice, string currentstock, string addqty, string totalstock)
        {
            DataRow ds =getCurrent(barCode);
            

            try
            {

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "INSERT into [dbo].[stock] VALUES('" + barCode + "','" + Convert.ToDecimal(unitprice) + "','" + Convert.ToInt32(currentstock) + "','" + Convert.ToInt32(addqty) + "','" + Convert.ToInt32(totalstock) + "')";
                SqlCommand add = new SqlCommand(query, con);
                int check = add.ExecuteNonQuery();
                query = "Update [dbo].[product] SET noofcartons='"+ Convert.ToInt32(totalstock)  + "',sellingprice='" + Convert.ToDouble(unitprice) + "',totalqty='" + ((Convert.ToInt32(totalstock)- Convert.ToInt32(ds["noofcartons"].ToString())) * Convert.ToInt32(ds["qtyincartons"].ToString())+ Convert.ToInt32(ds["totalqty"].ToString())) + "'where barcode='" +barCode+"'";
                add = new SqlCommand(query, con);
                int check1 = add.ExecuteNonQuery();

                if (check == 1&&check1==1)
                {
                    con.Close();
                    return true;
                }
                else

                    return false;
            }
            catch (Exception db)
            {
                return false;
            }


        }


        ///
        

    }
}
