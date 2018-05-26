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
    public partial class Form_Etat : MetroForm
    {
        bool _check;
        public Form_Etat(bool check)
        {
            
            InitializeComponent();
            _check = check;
            if (_check == false)
            {
                btnAdd.Text = "Editer";
                DataTable dt = CLASS_ETAT.SP_SELECTETATBYID(Form_EtatManagment.ID);
                foreach (DataRow dr in dt.Rows)
                {
                    txtEtatName.Text = dr["State_Nom"].ToString();
                }
            }
            else
            {
                btnAdd.Text = "Ajouter";
                
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_check == true)
            {
                CLASS_ETAT.SP_ADDNEWETAT(txtEtatName.Text);
                MessageBox.Show("Ajouté avec succès", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEtatName.Clear();
                txtEtatName.Focus();
            }
            else
            {
                CLASS_ETAT.SP_UPDATEETAT(Form_EtatManagment.ID, txtEtatName.Text);
                MessageBox.Show("Mis à jour avec succés", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
