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
    public partial class Form_Category : MetroForm
    {
        public Form_Category()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == string.Empty)
            {
                MessageBox.Show("Veuillez et un nom de catégorie", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            CLASS_CATEGORY.SP_ADDCATEGORY(txtCategoryName.Text);
            MessageBox.Show("Catégorie a été ajouté avec succès", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCategoryName.Text = string.Empty;
        }
    }
}
