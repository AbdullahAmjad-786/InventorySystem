using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace InventorySystem.Classes
{

    class PointOfSale
    {
        string connectionString;
        SqlConnection con;
        SqlDataReader reader;
        DataSet BackupData;
        public  PointOfSale()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            con = new SqlConnection(connectionString);
            BackupData = new DataSet();
        }


        public bool validBarCodeAnd(string barCode)
        {
            con.Open();

            string ID = "";
            string query = "Select barcode FROM [dbo].[product] where barcode = '" + barCode + "' AND Qty <> 0";
            SqlCommand cmd = new SqlCommand(query, con);


            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = reader["barcode"].ToString();
            }
            if (ID != "")
            {
                reader.Close();
                cmd.Dispose();
                con.Close();


                return true;
            }
            else
            {
                reader.Close();
                cmd.Dispose();
                con.Close();

                return false;

            }


        }



        public bool validBarCode(string barCode)
        {
            con.Open();

            string ID = "";
            string query = "Select barcode FROM [dbo].[product] where barcode = '" + barCode + "'";
            SqlCommand cmd = new SqlCommand(query, con);


            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = reader["barcode"].ToString();
            }
            if (ID != "")
            {
                reader.Close();
                cmd.Dispose();
                con.Close();


                return true;
            }
            else
            {
                reader.Close();
                cmd.Dispose();
                con.Close();

                return false;

            }
           

        }


        public int getInvoiceID()
        {
            
            con.Open();

            int ID =0;
            string query = "select max(CAST(invoice.InvoiceID as int)) from dbo.invoice";
            SqlCommand cmd = new SqlCommand(query, con);

            string temp = "0";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp =reader.GetValue(0).ToString();
            }
            if (temp == "")
            {
                ID = 1;
            }
            else
            {
                ID = Convert.ToInt32(temp);
                ID++;
            }
            reader.Close();
            cmd.Dispose();
            con.Close();
            return ID;


        }

        /*public bool updateQty(int barcode, int qty)
        {

            int q = Convert.ToInt32(getQty1(barcode)) - qty;
            con.Open();

            DataSet ds = new DataSet();

            string query = "SELECT * FROM [dbo].[product] where barcode= '" + barcode + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            string expiry="", no_of_cartons = "", sellingprice = "", unitprice = "", purchaseprice = "", productno = "", level = "", name = "", cat="";
            string qcartons = "";
            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                qcartons = row["qtyincartons"].ToString();
                expiry = row["expirydate"].ToString();
                no_of_cartons = row["noofcartons"].ToString();
                name = row["productname"].ToString();
                purchaseprice=row["purchaseprice"].ToString();
                unitprice=row["unitprice"].ToString();
               sellingprice= row["sellingprice"].ToString();
               productno= row["productno"].ToString();
                level=row["reorderlevel"].ToString();
                cat=row["category"].ToString();
               
            }
           // qty=Convert.ToInt32(qcartons) - qty;
            string query1 = "UPDATE [dbo].[product] SET noofcartons='" + Convert.ToInt32(no_of_cartons) + "',sellingprice='" + Convert.ToDouble(sellingprice) + "',unitprice='" + Convert.ToDouble(unitprice) + "',purchaseprice='" + Convert.ToDouble(purchaseprice) + "',productno='" + Convert.ToInt32(productno) + "',category='" + cat + "',qtyincartons='" + q + "' ,reorderlevel='" + Convert.ToInt32(level) + "' where barcode='" + barcode + "'";
            SqlCommand cmd = new SqlCommand(query1, con);
            int check = cmd.ExecuteNonQuery();
            reader.Close();
            cmd.Dispose();
            con.Close();


            if (check==1)
            {

                return true;
            }
            else
                return false;
        }*/
        public string getBarCode(int productNumber)
        {

            con.Open();

            string ID = "";
            string query = "Select barcode FROM [dbo].[product] where productno = '"+productNumber+"'" ;
            SqlCommand cmd = new SqlCommand(query, con);


            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = reader["barcode"].ToString();
            }

            reader.Close();
            cmd.Dispose();
            con.Close();
            return ID;


        }


        public DataSet getDataDashBoard()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

           string query = "SELECT barcode,productno,productname,category,purchaseprice,sellingprice,Qty,Unit,expirydate FROM [dbo].[product]";
           SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            adapter.Fill(BackupData);
            return ds;
        }

        public DataSet getBackupData()
        {
            return BackupData;
        }


        public void updateQtyForPos(string barcode, int qty)
        {
            con.Open();

            Product p = new Product();

            string query = "UPDATE [dbo].[product] SET Qty ='" + qty + "' where barcode = '" + barcode + "'";
            SqlCommand cmd = new SqlCommand(query, con);


            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();




        }



        public void updateQty(string barcode,int qty)
        {
          //  if()
       

            string productno = "0";
            Product p = new Product();
            int totalqty = p.totalQty(barcode, productno);
       //     int qtyIncart = p.qtyIncartons(barcode, productno);
       //     int totatCart = p.numberOfcartons(barcode, productno);


            con.Open();
            totalqty -= qty;
         //   int sub = totalqty / qtyIncart;
   //         if (totalqty % qtyIncart == 0)
     //       {
       //         totatCart=sub;
        //    }
         //   else
           //     totatCart = sub+1;


            string query = "UPDATE [dbo].[product] SET Qty ='"+totalqty+"' where barcode = '" + barcode + "'";
            SqlCommand cmd = new SqlCommand(query, con);


             cmd.ExecuteNonQuery();
      
            cmd.Dispose();
            con.Close();
            



        }

        public DataSet getDataPOS()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            string query = "SELECT barcode,productname,sellingprice,Qty FROM [dbo].[product] WHERE Qty <> 0";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }



        public DataSet getData()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                    string query = "SELECT barcode,productname,sellingprice,Qty FROM [dbo].[product] ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
            return ds;                
        }

        public string getItemName(string barCode)
        {
            con.Open();

            
            string query = "Select productname FROM [dbo].[product] WHERE barcode ='"+barCode+ "'";
            SqlCommand cmd = new SqlCommand(query, con);

            string temp = "";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp = reader.GetValue(0).ToString();
            }
            reader.Close();
            cmd.Dispose();
            con.Close();
            return temp;



        }


        public string getQty1(int productNumber)
        {

            con.Open();

            string ID = "";
            string query = "Select qtyincartons FROM [dbo].[product] where barcode = '" + productNumber + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            string no, no1;
            no = "";
            no1 = no;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                no1 = reader["qtyincartons"].ToString();

            }
            ID =no1.ToString();
            reader.Close();
            cmd.Dispose();
            con.Close();
            return ID;


        }



        public string getQty(string productNumber)
        {

            con.Open();

            string ID = "";
            string query = "Select Qty FROM [dbo].[product] where barcode = '" + productNumber + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            string no;
            no = "";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                 no = reader["Qty"].ToString();
                
            }
            int total = Convert.ToInt32(no);
            ID = total.ToString();
            reader.Close();
            cmd.Dispose();
            con.Close();
            return ID;


        }

        public bool addSales(string CID,string barcode,string Price, string IID, string qty)
        {

            try
            {

                con.Open();

                string query = "INSERT INTO [dbo].[sales] VALUES('" + CID + "', '" +barcode + "','" +Convert.ToInt32(IID)+ "', '"+Convert.ToInt32(qty)+ "','" + Convert.ToInt32(Price) + "')";

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

        public bool addProduct(string id,string CID, string CName,  string Total,string InvoiceDate)
        {
            DateTime date2 = DateTime.Parse(InvoiceDate).Date;
            string temp = date2.ToShortDateString();
            int currId = Convert.ToInt32(id);
            //currId = currId + 1;
           // string temp = "15-01-19";
            try
            {
               
                con.Open();

                string query= "INSERT INTO [dbo].[invoice] VALUES('"+currId.ToString() + "','"+CID+"', '"+Convert.ToDecimal(Total)+"','"+CName+ "','"+temp+"')";
                
                SqlCommand add = new SqlCommand(query, con);
                int check = add.ExecuteNonQuery();
              //  con.Close();
                if (check == 1)
                {
                    con.Close();
                    return true;
                }
                else
                    con.Close();
                return false;
            }
            catch (Exception db)
            {
                con.Close();
                return false;
            }

        }


    }
}
