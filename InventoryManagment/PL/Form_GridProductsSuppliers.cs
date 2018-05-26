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
    public partial class Form_GridProductsSuppliers : MetroForm
    {
        public static string _check;
        public Form_GridProductsSuppliers(string check)
        {
            InitializeComponent();
            _check = check;
            if (_check == "Products")
            {
                DataTable dt = CLASS_PRODUCTS.SP_DISPLAYALLPRODUCTS();
                dataGridView1.DataSource = dt;

            }
            else if(_check == "Suppliers")
            {
                DataTable dt = CLASS_SUPPLIERS.SP_SUPPLIERSELECTALL();
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
