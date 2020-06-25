using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InventorySystem.Classes;
using Inventory_System;

namespace InventorySystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtUsername != null && txtPassword != null)
            {
                Login enter = new Login();
                if (enter.login(txtUsername.Text, txtPassword.Text))
                {
                    if (enter.type(txtUsername.Text).Equals("Admin"))
                    {
                        frmMain mainAdmin = new frmMain();
                        mainAdmin.Show();
                    }
                    else
                    {
                        MainForm form = new MainForm();
                        form.Show();
                    }

                    this.Hide();
                }
                else
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
 