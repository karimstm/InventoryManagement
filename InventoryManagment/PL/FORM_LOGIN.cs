using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using InventoryManagment.BL;

namespace InventoryManagment.PL
{
    public partial class FORM_LOGIN : MetroForm
    {
        public FORM_LOGIN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Saisire un le nom de votre compte SVP");
                return;
            }

            if (txtUserPassword.Text == string.Empty)
            {
                MessageBox.Show("Saisire votre mot de pass SVP");
                return;
            }

            DataTable dt = LoginClass.SP_SELECTLOGIN(txtUsername.Text, txtUserPassword.Text);
            if (dt.Rows.Count>=1)
            {
                MainForm.check = true;
                MainForm.P_ID = int.Parse(dt.Rows[0]["Per_ID"].ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Votre Nom ou mot de pass errone!");
            }

        }
    }
}
