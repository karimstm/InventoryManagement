using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagment.BL;
using MetroFramework.Forms;

namespace InventoryManagment.PL
{
    public partial class Form_EtatManagment : MetroForm
    {
        public Form_EtatManagment()
        {
            InitializeComponent();
            btnDisplayAll_Click(null,null);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_ETAT.SP_DISPLAYALLETAT();
            dgvEtat.DataSource = dt;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new Form_Etat(true).ShowDialog();
        }

        public static int ID;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ID = int.Parse(dgvEtat.SelectedRows[0].Cells[0].Value.ToString());
            new Form_Etat(false).ShowDialog();
        }

        private void Form_EtatManagment_Activated(object sender, EventArgs e)
        {
            btnDisplayAll_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ID = int.Parse(dgvEtat.SelectedRows[0].Cells[0].Value.ToString());
            CLASS_ETAT.SP_DELETEETAT(ID);
            MessageBox.Show("Supprimé avec succès", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = CLASS_ETAT.SP_SEARCHETAT(txtsearch.Text);
            dgvEtat.DataSource = dt;
        }
    }
}
