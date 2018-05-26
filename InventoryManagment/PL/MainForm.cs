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
using InventoryManagment.PL;
namespace InventoryManagment.PL
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        public static bool check = false;
        public static int P_ID = 0;

        private void panel1_Click_1(object sender, EventArgs e)
        {
            new FORM_LOGIN().ShowDialog();
        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (P_ID == 1)
            {
                LogoutPanel.Enabled = Pbackup.Enabled = Prestore.Enabled = check;
                if (check == false)
                {
                    MainTab.DisableTab(ProductTab);
                    MainTab.DisableTab(SupplierTab);
                    MainTab.DisableTab(UserTab);
                }
                else
                {
                    MainTab.EnableTab(ProductTab);
                    MainTab.EnableTab(SupplierTab);
                    MainTab.EnableTab(UserTab);
                }
            }
            else if(P_ID == 2)
            {
                LogoutPanel.Enabled= panel17.Enabled = check;
                if (check == false)
                {
                    MainTab.DisableTab(ProductTab);
                }
                else
                {
                    MainTab.EnableTab(ProductTab);
                }
            }
            else if (P_ID == 0)
            {
                LogoutPanel.Enabled = Pbackup.Enabled = Prestore.Enabled = check;
                if (check == false)
                {
                    MainTab.DisableTab(ProductTab);
                    MainTab.DisableTab(SupplierTab);
                    MainTab.DisableTab(UserTab);
                }
                else
                {
                    MainTab.EnableTab(ProductTab);
                    MainTab.EnableTab(SupplierTab);
                    MainTab.EnableTab(UserTab);
                }
            }
            
        }


        private void LogoutPanel_Click(object sender, EventArgs e)
        {
            check = false;
            MainForm_Activated(null, null);
            P_ID = 0;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            new Form_Category().ShowDialog();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            new Form_CategoryManagment().ShowDialog();
        }


        private void panel9_Click(object sender, EventArgs e)
        {
            new Form_Etat(true).ShowDialog();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            new Form_EtatManagment().ShowDialog();
        }

        private void panel24_Click(object sender, EventArgs e)
        {
            new Form_Marque("Ajouter").ShowDialog();
        }

        private void panel26_Click(object sender, EventArgs e)
        {
            new Form_BrandManagment().ShowDialog();
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            new Form_AddNewProducts("New").ShowDialog();
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            new Form_ProductsManagement().ShowDialog();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Click(object sender, EventArgs e)
        {
            new Form_SupplierManagment().ShowDialog();
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            new Form_NewPurchase().ShowDialog();
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            new Form_Facture_Management().ShowDialog();
        }

        private void useradd_Click(object sender, EventArgs e)
        {
            new Form_AddNewUser(false).ShowDialog();
        }

        private void panel23_Click(object sender, EventArgs e)
        {
            new Form_usersManangment().ShowDialog();
        }

        private void Pbackup_Click(object sender, EventArgs e)
        {
            new Form_Backup().ShowDialog();
        }

        private void Prestore_Click(object sender, EventArgs e)
        {
            new Form_RestoreBackup().ShowDialog();
        }
    }
}
