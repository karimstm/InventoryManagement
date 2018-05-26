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
    public partial class Form_RestoreBackup : MetroForm
    {
        public Form_RestoreBackup()
        {
            InitializeComponent();
        }

        private void btnpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = ofd.FileName;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnrestore_Click(object sender, EventArgs e)
        {
            try
            {
                CLASS_HELPER.Restore(txtpath.Text);
                MessageBox.Show("La restauration a été effectuée avec succès");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
