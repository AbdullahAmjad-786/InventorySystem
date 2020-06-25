using System;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace InventorySystem.Classes
{
    class Product
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection con;
        public bool addProduct(string name, string barcode,  string purchaseprice, string sellingprice, string qty, string unit, string productno, string category, string expiry)
        {
            
            try
            {
                 con = new SqlConnection(connectionString);
                con.Open();
            
                

                string query = "INSERT INTO [dbo].[product] (productname,barcode,purchaseprice" +
                    ",sellingprice,Qty,Unit,productno,category,expirydate)" +
                    " VALUES ('" + name + "','" + barcode + "','" + Convert.ToDouble(purchaseprice) + "','" + Convert.ToDouble(sellingprice) + "','" + Convert.ToUInt32(qty) + "','" + unit + "','" + Convert.ToInt32(productno) + "','" + category + "','" + expiry + "')";
                SqlCommand add = new SqlCommand(query, con);
                int check = add.ExecuteNonQuery();

                if (check == 1)
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
       

        public bool deleteProduct(string productno, string code)
        {

            try
            {
                string query = "DELETE from [dbo].[product] where productno='" + productno + "' OR barcode='" + code + "'";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand add = new SqlCommand(query, con);
                int check = add.ExecuteNonQuery();

                if (check == 1)
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
        public bool checkBarCode(string catName)
        {
            DataSet ds = new DataSet();

            string query = "SELECT * FROM [dbo].[product]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);


            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (catName.Equals(row["barcode"].ToString()))
                {
                    return false;
                }
            }
            if (ds.Tables[0].Rows.Count == 0)
            {
                return true;
            }
            else
                return true;
        }

        public bool updateProduct(string name, string barcode,  string purchaseprice, string sellingprice, string qty, string unit, string productno, string category, string expiry)
        {

            try
            {
                //int result=UpdateCartonsORUpdateQtyInCartons(barcode,productno);



                string query = "UPDATE [dbo].[product] SET productname= '"+name+"', expirydate='"+ expiry + "',Qty='" + Convert.ToInt32(qty)+"',sellingprice='" + Convert.ToDouble(sellingprice) + "',purchaseprice='" + Convert.ToDouble(purchaseprice) + "',productno='" + productno + "',category='" + category + "',Unit='" + unit + "' where barcode='" + barcode + "' OR productno='" + Convert.ToInt32(productno) + "'";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand add = new SqlCommand(query, con);
                int check = add.ExecuteNonQuery();

                if (check == 1)
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

        public string getExpiraydate(string barcode)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlDataReader reader;
            string ID = "";
            string query = "Select expirydate FROM [dbo].[product] WHERE barcode= '"+barcode+"'";
            SqlCommand cmd = new SqlCommand(query, con);

        
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = reader.GetValue(0).ToString();
            }
         
            reader.Close();
            cmd.Dispose();
            con.Close();
            return ID;


        }


        public DataSet selectProduct(string no, string code)
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SELECT * FROM [dbo].[product] where productname= '" + no + "'OR barcode='" + code + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);


                adapter.Fill(ds);
                return ds;
            }
            catch (Exception db)
            {

                return ds;
            }

        }


        public int numberOfcartons(string barcode, string productno)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlDataReader reader;
            string ID = "";
            string query = "Select noofcartons FROM [dbo].[product] WHERE barcode= '" + barcode + "' OR productno='"+Convert.ToInt32(productno)+"'";
            SqlCommand cmd = new SqlCommand(query, con);


            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = reader.GetValue(0).ToString();
            }

            reader.Close();
            cmd.Dispose();
            con.Close();
            return Convert.ToInt32( ID);



        }


        public int qtyIncartons(string barcode, string productno)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlDataReader reader;
            string ID = "";
            string query = "Select qtyincartons FROM [dbo].[product] WHERE barcode= '" + barcode + "' OR productno='" + Convert.ToInt32(productno) + "'";
            SqlCommand cmd = new SqlCommand(query, con);


            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = reader.GetValue(0).ToString();
            }

            reader.Close();
            cmd.Dispose();
            con.Close();
            return Convert.ToInt32(ID);


        }

        public int totalQty(string barcode, string productno)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlDataReader reader;
            string ID = "";
            string query = "Select Qty FROM [dbo].[product] WHERE barcode= '" + barcode + "' OR productno='" + Convert.ToInt32(productno) + "'";
            SqlCommand cmd = new SqlCommand(query, con);


            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = reader.GetValue(0).ToString();
            }

            reader.Close();
            cmd.Dispose();
            con.Close();
            return Convert.ToInt32(ID);


        }

        public string getProductName(string barcode)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlDataReader reader;
            string ID = "";
            string query = "Select  productname FROM [dbo].[product] WHERE barcode= '" + barcode + "'";
            SqlCommand cmd = new SqlCommand(query, con);


            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = reader.GetValue(0).ToString();
            }

            reader.Close();
            cmd.Dispose();
            con.Close();
            return (ID);


        }


        public int UpdateCartonsORUpdateQtyInCartons(string barcode, string productno)
        {

            int result = 0;
         //   int totalqty = totalQty(barcode,productno);
            int qtyIncart = qtyIncartons(barcode, productno);
            int totatCart = numberOfcartons(barcode, productno);

          //  result = (qtyIncart * totatCart)-totalqty;


            return result;
        }



    }
}
