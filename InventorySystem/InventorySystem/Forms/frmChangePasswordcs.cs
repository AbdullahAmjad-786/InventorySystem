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
namespace InventorySystem.Forms
{
    public partial class frmChangePasswordcs : Form
    {
        public frmChangePasswordcs()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            if (l.UpdatePassowrd(txtUserName.Text,txtPassword.Text, txtNewPassword.Text, txtConfirmPassword.Text))
            {
                MessageBox.Show("Succefully Changed","Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            }
            
        }
    }
}
