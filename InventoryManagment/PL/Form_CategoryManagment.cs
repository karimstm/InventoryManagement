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
using System.Data;
using InventoryManagment.BL;

namespace InventoryManagment.PL
{
    public partial class Form_CategoryManagment : MetroForm
    {
        public Form_CategoryManagment()
        {
            InitializeComponent();
            btnDisplayAll_Click(null, null);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DataTable dt =  CLASS_CATEGORY.SP_CATEGORYSELECTALL();
            dgvCategory.DataSource = dt;
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                txtCatID.Text = dgvCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCatName.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_CATEGORY.SP_CATEGORYSEARSH(txtDisplay.Text);
            dgvCategory.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CLASS_CATEGORY.SP_CATEGORYUPDATE(int.Parse(txtCatID.Text), txtCatName.Text);
            MessageBox.Show("Mise à jour réussie", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDisplayAll_Click(null,null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCatID.Text != string.Empty)
            {
                CLASS_CATEGORY.SP_CATEGORYDELTE(int.Parse(txtCatID.Text));
                MessageBox.Show("Supprimé avec succès", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDisplayAll_Click(null, null);
                txtCatID.Text = txtCatName.Text = string.Empty;
            }

        }
    }
}
