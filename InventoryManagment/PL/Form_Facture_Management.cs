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
    public partial class Form_Facture_Management : MetroForm
    {
        public Form_Facture_Management()
        {
            InitializeComponent();
            btnDisplay_Click(null, null);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_INVOICE.SP_DISPLAYALLINVOICE();
            dgvFacture.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = int.Parse(dgvFacture.CurrentRow.Cells[0].Value.ToString());
            DialogResult R = MessageBox.Show("Voulez vous vraiment supprimer cette facture?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                CLASS_INVOICE.SP_DELETEINVOICE(i);
                MessageBox.Show("Facture supprimer avec succes!");
            }
        }

        private void Form_Facture_Management_Activated(object sender, EventArgs e)
        {
            btnDisplay_Click(null, null);
        }

        private void btnCAncel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSEarch_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_INVOICE.SP_SEARCHINVOICE(txtsearch.Text);
            dgvFacture.DataSource = dt;

        }

        private void btnPrintSelected_Click(object sender, EventArgs e)
        {
            RPT.FORM_RPT FRM = new RPT.FORM_RPT();
            RPT.Print_SelectedInvoice SELECTEDINVOICE = new RPT.Print_SelectedInvoice();
            SELECTEDINVOICE.SetParameterValue("@I_ID", dgvFacture.SelectedRows[0].Cells[0].Value);
            FRM.crystalReportViewer1.ReportSource = SELECTEDINVOICE;
            FRM.ShowDialog();
        }
    }
}
