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
using InventoryManagment.BL;

namespace InventoryManagment.PL
{
    public partial class Form_Marque : MetroForm
    {
        string _check;
        public Form_Marque(string Check)
        {
            
            InitializeComponent();
            _check = Check;
            if (_check == "Ajouter")
            {
                this.Text = "Ajouter une marque";
                btnadd.Text = "Ajouter";
            }
            else if (_check == "Editer")
            {
                this.Text = "Editer une marque";
                btnadd.Text = "Editer";
                DataTable dt = CLASS_MARQUE.SP_SELECTBRANDBYID(Form_BrandManagment.I);
                foreach (DataRow dr in dt.Rows)
                {
                    txtmarque.Text = dr["Brand_Name"].ToString();
                }
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (_check == "Ajouter")
            {
                CLASS_MARQUE.SP_ADDNEWBRAND(txtmarque.Text);
                MessageBox.Show("Ajouté avec succès", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmarque.Clear();
                txtmarque.Focus();
            }
            else if (_check == "Editer")
            {
                CLASS_MARQUE.SP_UPDATEBRAND(Form_BrandManagment.I, txtmarque.Text);
                MessageBox.Show("Editer avec succès", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
