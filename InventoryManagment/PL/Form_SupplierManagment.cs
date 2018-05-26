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
    public partial class Form_SupplierManagment : MetroForm
    {
        public Form_SupplierManagment()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Entrez le nom de fournisseur SVP!");
                return;
            }

            CLASS_SUPPLIERS.SP_ADDNEWSUPPLIER(txtName.Text, txtPhone.Text, txtfax.Text, txtemail.Text, txtAdress.Text, txtCounty.Text);
            MessageBox.Show("Fournisseurs a été ajouté avec succès");
            btnNew_Click(null, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = CLASS_SUPPLIERS.SP_SUPPLIERSEARCH(txtSearch.Text);
            dgvSuppliers.DataSource = dt;
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvSuppliers.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = dgvSuppliers.CurrentRow.Cells[2].Value.ToString();
            txtfax.Text = dgvSuppliers.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dgvSuppliers.CurrentRow.Cells[4].Value.ToString();
            txtAdress.Text = dgvSuppliers.CurrentRow.Cells[5].Value.ToString();
            txtCounty.Text = dgvSuppliers.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnDisplayall_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_SUPPLIERS.SP_SUPPLIERSELECTALL();
            dgvSuppliers.DataSource = dt;
        }

        private void Form_SupplierManagment_Activated(object sender, EventArgs e)
        {
            btnDisplayall_Click(null, null);
        }
        int I;
        private void btndelete_Click(object sender, EventArgs e)
        {
            I = int.Parse(dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult ds = MessageBox.Show("Voules vous vraiment supprimer cette Fournisseur?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ds == DialogResult.Yes)
            {
                
                CLASS_SUPPLIERS.SP_SUPPLIERDELETE(I);
                MessageBox.Show("Le fournisseur a été supprimé avec succès.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void btnCAncel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            I = int.Parse(dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString());
            CLASS_SUPPLIERS.SP_SUPPLIERUPDATE(I, txtName.Text, txtPhone.Text, txtfax.Text, txtemail.Text, txtAdress.Text, txtCounty.Text);
            MessageBox.Show("Le fournisseur a été mis à jour avec succès.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox4.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = String.Empty;
            }
        }
    }
}
