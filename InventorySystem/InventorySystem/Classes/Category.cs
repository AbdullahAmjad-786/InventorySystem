using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace InventorySystem.Classes
{
    class Category
    {


        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public bool addcategory( string name, string discription)
        {

            try
            {
                string query = "INSERT into [dbo].[category] (categoryName,categoryDescription) VALUES('" + name + "','" + discription + "')";

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

        public bool checkCategory(string catName)
        {
            DataSet ds = new DataSet();

            string query = "SELECT * FROM [dbo].[category]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);


            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (catName.Equals(row["categoryName"].ToString()) )
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


        public bool updatecategory(string name,string dis,int id)
        {

            try
            {
                

                string query = "UPDATE [dbo].[category] SET categoryName='" + name + "',categoryDescription='" + dis + "' where categoryID='" + id + "'";

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

        public DataSet selectcategory()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SELECT categoryName FROM [dbo].[category]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception db)
            {

                return null;
            }

        }

        public DataSet selectcategory(string name)
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SELECT * FROM [dbo].[category] where categoryName='"+name+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception db)
            {

                return null;
            }

        }

        public int selectCategory(string name)
        {
            SqlDataReader reader ;
            SqlConnection con = new SqlConnection(connectionString);

            string ID = "";
            try
            {
                con.Open();
                string query = "SELECT categoryID FROM [dbo].[category] where categoryName='" +name+"'";
                SqlCommand cmd = new SqlCommand(query, con);


                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ID = reader["categoryID"].ToString();
                }

                reader.Close();
                cmd.Dispose();
                con.Close();
                return Convert.ToInt32(ID);
            }
            catch (Exception db)
            {

                return 0;
            }

        }



    }

}
