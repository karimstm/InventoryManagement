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
    public partial class Form_Backup : MetroForm
    {
        public Form_Backup()
        {
            InitializeComponent();
        }

        private void btnpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            txtpath.Text = fd.SelectedPath;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            try
            {
                string path = string.Format("{0}\\INVENTORY-{1}{2}.bak", txtpath.Text, DateTime.Now.ToShortDateString().Replace('/', '-'), DateTime.Now.ToShortTimeString().Replace(':', '-'));
                CLASS_HELPER.Backup_DB(path);
                MessageBox.Show("Sauvgarder avec succes");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
