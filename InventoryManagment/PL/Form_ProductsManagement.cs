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
using System.IO;

namespace InventoryManagment.PL
{
    public partial class Form_ProductsManagement : MetroForm
    {
        public Form_ProductsManagement()
        {
            InitializeComponent();
            btnDisplay_Click(null, null);
            CMBFilter.SelectedIndex = 0;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_PRODUCTS.SP_DISPLAYALLPRODUCTS_LESSDETAILS();
            dgvProduit.DataSource = dt;
            dgvquantity.Rows.Clear();

        }
        public static int I;
        private void dgvProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvquantity.Rows.Clear();
            I = int.Parse(dgvProduit.SelectedRows[0].Cells[0].Value.ToString());
            DataTable dt = CLASS_PRODUCTS.SP_DISPLAYALLPRODUCTSBYID(I);
            foreach (DataRow dr in dt.Rows)
            {
                dgvquantity.Rows.Add(dr["P_ID"], dr["Brand_Name"], dr["Cat_Name"], dr["P_Description"], dr["P_Price"], dr["WareHouse_Location"], dr["Delivered_BY"],
                    dr["Acquisition_Date"], dr["State_Nom"]);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new Form_AddNewProducts("Update").ShowDialog();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            byte[] Arr = CLASS_PRODUCTS.SP_PRODUCTGETIMAGE(int.Parse(dgvProduit.SelectedRows[0].Cells[0].Value.ToString()));
            MemoryStream ms = new MemoryStream(Arr);
            Form_DisplayImage fimage = new Form_DisplayImage();
            fimage.PICIMAGE.Image = Image.FromStream(ms);
            fimage.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            I = int.Parse(dgvProduit.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult dr = MessageBox.Show("Voules-vous vraiment supprimer", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLASS_PRODUCTS.SP_DELETEPRODUCTS(I);
                MessageBox.Show("Supprimer avec succès", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_ProductsManagement_Activated(object sender, EventArgs e)
        {
            btnDisplay_Click(null, null);
        }


        private void CMBFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (CMBFilter.Text)
            {
                case "Quantité":
                    DataTable dt = CLASS_PRODUCTS.SP_DISPLAYALLPRODUCTSBYQUANTITY();
                    dgvfilter.DataSource = dt;
                    break;
                default:
                    break;
            }
        }

        private void BTNSEARCH_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_PRODUCTS.SP_SEARCHPRODUCT(txtSearch.Text);
            dgvProduit.DataSource = dt;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RPT.FORM_RPT Frm = new RPT.FORM_RPT();
            RPT.Products_RPT PRODUCTS = new RPT.Products_RPT();
            Frm.crystalReportViewer1.ReportSource = PRODUCTS;
            Frm.ShowDialog();

        }

        private void PrintSelectedProduct_Click(object sender, EventArgs e)
        {
            RPT.FORM_RPT FRM = new RPT.FORM_RPT();
            RPT.SelectedProduct_RPT SELECTEDPRODUCT = new RPT.SelectedProduct_RPT();
            SELECTEDPRODUCT.SetParameterValue("@ID", dgvProduit.SelectedRows[0].Cells[0].Value);
            FRM.crystalReportViewer1.ReportSource = SELECTEDPRODUCT;
            FRM.ShowDialog();

        }
    }
}
