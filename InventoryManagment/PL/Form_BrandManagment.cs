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
    public partial class Form_BrandManagment : MetroForm
    {
        public Form_BrandManagment()
        {
            InitializeComponent();
            btnDisplayAll_Click(null, null);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_MARQUE.SP_DISPLAYBRANDALL();
            dgvmarque.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = CLASS_MARQUE.SP_SEARCHBRAND(txtSearch.Text);
            dgvmarque.DataSource = dt;
        }

        private void Form_BrandManagment_Activated(object sender, EventArgs e)
        {
            btnDisplayAll_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Form_Marque("Ajouter").ShowDialog();
        }

        public static int I;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            I = int.Parse(dgvmarque.SelectedRows[0].Cells[0].Value.ToString());
            new Form_Marque("Editer").ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            I = int.Parse(dgvmarque.SelectedRows[0].Cells[0].Value.ToString());
            if (dgvmarque.SelectedRows.Count > 0 )
            {
                CLASS_MARQUE.SP_DELETEBRAND(I);
                MessageBox.Show("Supprimer avec succès", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
