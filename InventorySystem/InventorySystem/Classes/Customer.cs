using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace InventorySystem.Classes
{
    class Customer
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;


        ///Get Name And Balacne Customers Data
        public DataSet getCustomerData(Int64 Contact)
        {
            DataSet ds = new DataSet();


            string query = "Select * FROM [dbo].[customers] WHERE customerContactNumber= '"+Contact+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            adapter.Fill(ds);


            return ds;


        }



        ///Get Whole Customers Data
        public DataSet getCustomerData()
        {
            DataSet ds = new DataSet();


            string query = "Select customerContactNumber,customerLastName,customerFirstName,customerCity,Address,Balance FROM [dbo].[customers]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            adapter.Fill(ds);


            return ds;


        }

        ///Add Customer
        public bool addcustomer(string fname, string lname, string ad_city, Int64 contact, string ad_state, string c_balance)
        {

            try
            {
                string query = "INSERT into [dbo].[customers] (customerFirstName,customerLastName,customerContactNumber,customerCity,Balance,Address) VALUES('" + fname + "','" + lname + "','" + contact.ToString() + "','" + ad_city + "','" + c_balance + "','" + ad_state + "')";

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
        ///
        //// Update Customer
        public bool updateCustomer(string fname, string lname, string ad_city, Int64 contact, string ad_state, string c_balance)
        {

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();


                string query = "UPDATE [dbo].[customers] SET customerFirstName='" + fname + "',customerLastName='" + lname + "',customerContactNumber='" + contact + "',customerCity='" + ad_city + "',Balance='" + c_balance + "',Address='" + ad_state + "' where customerContactNumber='" + contact + "'";


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
        ////

        //// get_ContactNumber

        public bool checkContactNumber(Int64 contact)
        {

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();


                string query = "Select customerContactNumber FROM [dbo].[customers] where customerContactNumber='" + contact + "'";


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
            ///
           
       }

        //// get_Balance
        public string getBalance(string contact)
        {
            DataSet ds = new DataSet();

            int id = 0;
            string query = "Select Balance FROM [dbo].[customers] WHERE CustomerContactNumber='" + contact + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {

                id = Convert.ToInt32(row["Balance"].ToString());
            }

            return id.ToString();
        }

        //// Delete_customer
        public bool deleteStaff(Int64 contact)
        {

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
               string  query = "DELETE from [dbo].[customers] where customerContactNumber='" + contact + "'";
                con.Open();
                SqlCommand add = new SqlCommand(query, con);
                int check = add.ExecuteNonQuery();
                con.Close();
                if (check == 1)
                {

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


        //// get_Balance
        public bool SetBalance(Int64 contact, string balance)
        {
            SqlConnection con = new SqlConnection(connectionString);

            string query = "UPDATE  [dbo].[customers] SET Balance='"+ balance + "' WHERE CustomerContactNumber='" + contact + "'";
            con.Open();
            SqlCommand add = new SqlCommand(query, con);
            int check = add.ExecuteNonQuery();
            con.Close();
            if (check == 1)
            {

                return true;
            }
            else

                return false;


        }




    }


}
