using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class frmDataBase : Form
    {
        private string TstServerMySQL;
        private string TstPortMySQL;
        private string TstUserNameMySQL;
        private string TstPwdMySQL;
        private string TstDBNameMySQL;
        private void cmdTest_Click(System.Object sender, System.EventArgs e)
        {
            //Test database connection

            TstServerMySQL = txtServerHost.Text;
            TstPortMySQL = txtPort.Text;
            TstUserNameMySQL = txtUserName.Text;
            TstPwdMySQL = txtPassword.Text;
            TstDBNameMySQL = txtDatabase.Text;


            try
            {
                //conn.ConnectionString = "Server = '" + TstServerMySQL + "';  " + "Port = '" + TstPortMySQL + "'; " + "Database = '" + TstDBNameMySQL + "'; " + "user id = '" + TstUserNameMySQL + "'; " + "password = '" + TstPwdMySQL + "'";


                //conn.Open();
                //Interaction.MsgBox("Test connection successful", MsgBoxStyle.Information, "Database Settings");

            }
            catch (Exception ex)
            {
             //   Interaction.MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings");

            }
           // DisconnMy();
        }

        private void cmdSave_Click(System.Object sender, System.EventArgs e)
        {
            TstServerMySQL = txtServerHost.Text;
            TstPortMySQL = txtPort.Text;
            TstUserNameMySQL = txtUserName.Text;
            TstPwdMySQL = txtPassword.Text;
            TstDBNameMySQL = txtDatabase.Text;

            try
            {
                //conn.ConnectionString = "Server = '" + TstServerMySQL + "';  " + "Port = '" + TstPortMySQL + "'; " + "Database = '" + TstDBNameMySQL + "'; " + "user id = '" + TstUserNameMySQL + "'; " + "password = '" + TstPwdMySQL + "'";
                //conn.Open();

                //DBNameMySQL = txtDatabase.Text;
                //ServerMySQL = txtServerHost.Text;
                //UserNameMySQL = txtUserName.Text;
                //PortMySQL = txtPort.Text;
                //PwdMySQL = txtPassword.Text;

                //SaveData();
                this.Close();
            }
            catch (Exception ex)
            {
              //  Interaction.MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings");
            }
          //  DisconnMy();
            //save database
        }

        private void cmdClose_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmDatabase_Load(System.Object sender, System.EventArgs e)
        {
            this.Location = new Point(178, 127);
            //txtServerHost.Text = ServerMySQL;
            //txtPort.Text = PortMySQL;
            //txtUserName.Text = UserNameMySQL;
            //txtPassword.Text = PwdMySQL;
            //txtDatabase.Text = DBNameMySQL;
        }

    }
}
