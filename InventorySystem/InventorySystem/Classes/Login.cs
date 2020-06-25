using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Configuration;

namespace InventorySystem.Classes
{
    class Login
    {
        string connectionString= System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;


        public bool login(string username, string password)
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;


            if (username != "" && password != "")
            {
                string directory = Directory.GetCurrentDirectory();



                try
                {
                    string query = "SELECT * FROM [dbo].[login]";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (username.Equals(row["username"].ToString()) && password.Equals(row["password"].ToString()))
                        {
                            return true;
                        }
                    }
                    MessageBox.Show("Username or Passsword Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception db)
                {
                    MessageBox.Show("Problem with your Database\n" + db.Message + "\t" + db.Source, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please Enter Username & Passsword", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        public bool checklogin(string catName)
        {
            DataSet ds = new DataSet();

            string query = "SELECT * FROM [dbo].[login]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);


            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (catName.Equals(row["username"].ToString()))
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




        public bool UpdatePassowrd(string username, string password,string newPassword,string repeatPassword)
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;



            if (username != "" && password != "" && newPassword != "" && repeatPassword!="")
            {
                if (repeatPassword == newPassword)
                {
                    string directory = Directory.GetCurrentDirectory();



                    try
                    {
                        string query = "SELECT * FROM [dbo].[login]";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            if (username.Equals(row["username"].ToString()) && password.Equals(row["password"].ToString()))
                            {
                                SqlConnection con = new SqlConnection(connectionString);
                                con.Open();

                                string query1 = "UPDATE [dbo].[login] SET password='"+newPassword+"'where username='"+username+"'";
                                SqlCommand cmd = new SqlCommand(query1, con);
                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    cmd.Dispose();
                                    con.Close();

                                    return true;
                                }
                                cmd.Dispose();
                                con.Close();
                            }
                        }
                        MessageBox.Show("Username or Passsword Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    catch (Exception db)
                    {
                        MessageBox.Show("Problem with your Database\n" + db.Message + "\t" + db.Source, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password Doesnt match. Try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Username & Passsword", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public string type(string username)
        {
            string qry = "SELECT type FROM login WHERE username LIKE'" + username + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(qry, connectionString);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds);
            }
            catch (Exception db)
            {
                MessageBox.Show("Problem with your Database\n" + db.Message + "\t" + db.Source, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //--

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string type = row["type"].ToString();
                return type;
            }
            return "";
        }
    }
}
