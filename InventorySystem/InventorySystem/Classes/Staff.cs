using System;
using System.Data;
using System.Data.SqlClient;

namespace InventorySystem.Classes
{
    class Staff
    {

        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public DataSet getStaffData(string contact,string fname)
        {
            DataSet ds = new DataSet();


            string query = "Select SId,mid,state,province FROM [dbo].[staff] WHERE fname='"+fname+"' AND contact='"+contact+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
           
            adapter.Fill(ds);


            return ds;


        }
        public int getStaffID(string contact, string fname)
        {
            DataSet ds = new DataSet();

            int id = 0;
            string query = "Select SId FROM [dbo].[staff] WHERE fname='" + fname + "' AND contact='" + contact + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
            
            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {

                id = Convert.ToInt32(row["SId"].ToString());
            }

                return id;


        }


        public int getStaffID()
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            int ID = 0;
            string query = "Select MAX(SId) FROM [dbo].[staff] GROUP BY SId";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            string temp = "0";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp = reader.GetValue(0).ToString();
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


        public bool addStaff(string sid, string fname, string lname, string mid, string ad_street, string ad_barangy, string ad_province, string contact, string username, string role, string password, string confirmpassword)
        {
            try
            {
                string query = "INSERT into [dbo].[staff] (SId,fname,lname,mid,state,city,province,contact,username) VALUES('" + sid + "','" + fname + "','" + lname + "','" + mid + "','" + ad_street + "','" + ad_barangy + "','" + ad_province + "','" + contact + "','" + username + "')";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand add = new SqlCommand(query, con);
                int check = add.ExecuteNonQuery();
                query = "INSERT into [dbo].[login] (username,type,password) VALUES('" + username + "','" + role + "' ,'" + password +"')";
                add = new SqlCommand(query, con);
                int check1 = add.ExecuteNonQuery();
                if (check == 1 && check1==1)
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
        public bool updateStaff(string sid, string fname, string lname, string mid, string state, string ad_city, string ad_province, string contact, string username)
        {

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
               

                string query = "UPDATE [dbo].[staff] SET fname='" + fname + "',lname='" + lname + "',mid='" + mid + "',state='" + state + "',city='" + ad_city + "',province='" + ad_province + "',contact='" +contact + "',username='" + username + "' where SId='" + sid + "'";

                
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

        public bool deleteStaff(string sid)
        {

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
             
                string query = "SELECT username from [dbo].[staff] where SId='" + sid + "'";
                SqlCommand select = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(select);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataRow row = ds.Tables[0].Rows[0];
                string username = row["username"].ToString();


                query = "DELETE from [dbo].[staff] where SId='" + sid + "'";
                con.Open();
                SqlCommand add = new SqlCommand(query, con);
                int check = add.ExecuteNonQuery();
                con.Close();

                string query1 = "DELETE from [dbo].[login] where username='" + username + "'";
                con.Open();
                SqlCommand c = new SqlCommand(query1, con);
                int check1 = add.ExecuteNonQuery();

                con.Close();
                if (check == 1 || check1==1)
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
        public DataSet selectStaff()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SELECT SId,fname,mid,lname,username,contact,city,province,state FROM [dbo].[staff]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
                

                adapter.Fill(ds);
                return ds;
            }
            catch (Exception db)
            {

                return ds;
            }

        }




    }

}
