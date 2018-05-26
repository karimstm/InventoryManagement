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
    public partial class Form_NewPurchase : MetroForm
    {
        public Form_NewPurchase()
        {
            InitializeComponent();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Form_GridProductsSuppliers frm = new Form_GridProductsSuppliers("Suppliers");
            frm.ShowDialog();
            txtID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSupplierName.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTel.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtFax.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = frm.dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            Form_GridProductsSuppliers frm = new Form_GridProductsSuppliers("Products");
            frm.ShowDialog();
            for (int i = 0; i < dgvProducts.Rows.Count; i++)
            {
                if (frm.dataGridView1.CurrentRow.Cells[0].Value.ToString() == dgvProducts.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Ce produit a déjà été ajouté");
                    return;
                }
            }
            dgvProducts.Rows.Add(frm.dataGridView1.CurrentRow.Cells[0].Value,
                frm.dataGridView1.CurrentRow.Cells[1].Value,
                frm.dataGridView1.CurrentRow.Cells[2].Value,
                frm.dataGridView1.CurrentRow.Cells[3].Value,
                frm.dataGridView1.CurrentRow.Cells[7].Value);
            calcTotal();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.Remove(dgvProducts.CurrentRow);
            calcTotal();
        }
        public void calcTotal()
        {
            double total = 0;
            for (int i = 0; i < dgvProducts.Rows.Count; i++)
            {
                total += double.Parse(dgvProducts.Rows[i].Cells[4].Value.ToString());
            }
            txtTotal.Text = total.ToString();
        }

        private void btnAddnewPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRef.Text == string.Empty || txtBuyerName.Text == string.Empty || dgvProducts.Rows.Count == 0)
                {
                    MessageBox.Show("Remplir tous les champs!");
                }
                else
                {
                    DataTable dtInvoiceDetail = new DataTable();
                    dtInvoiceDetail.Columns.Add("P_ID");
                    dtInvoiceDetail.Columns.Add("P_Price");
                    foreach (DataGridViewRow dr in dgvProducts.Rows)
                    {
                        dtInvoiceDetail.Rows.Add(dr.Cells[0].Value, dr.Cells[4].Value);
                    }
                    CLASS_INVOICE.SP_INVOICEINSERT(txtRef.Text, dtpFacture.Value.Date, decimal.Parse(txtTotal.Text), int.Parse(txtID.Text), txtBuyerName.Text, dtInvoiceDetail);
                    MessageBox.Show("La facture a été ajoutée avec succès");
                    PrintPurchase.Enabled = true;
                    clearzone();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintPurchase_Click(object sender, EventArgs e)
        {
            int I = CLASS_INVOICE.SP_MAXIDINVOICE();
            RPT.FORM_RPT FRM = new RPT.FORM_RPT();
            RPT.Print_SelectedInvoice SELECTEDINVOICE = new RPT.Print_SelectedInvoice();
            SELECTEDINVOICE.SetParameterValue("@I_ID", I);
            FRM.crystalReportViewer1.ReportSource = SELECTEDINVOICE;
            FRM.ShowDialog();
        }
        private void clearzone()
        {
            dgvProducts.Rows.Clear();

        }
    }
}
