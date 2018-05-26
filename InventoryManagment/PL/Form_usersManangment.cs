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
    public partial class Form_usersManangment : MetroForm
    {
        public Form_usersManangment()
        {
            InitializeComponent();
            btndisplay_Click(null, null);
        }

        private void Form_usersManangment_Load(object sender, EventArgs e)
        {

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_USERS.SP_DISPLAYALLUSERS();
            dgvusers.DataSource = dt;
        }
        public static int I;
        private void btnupdate_Click(object sender, EventArgs e)
        {
            I = int.Parse(dgvusers.SelectedRows[0].Cells[0].Value.ToString());
            new Form_AddNewUser(true).ShowDialog();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            DataTable DT = CLASS_USERS.SP_SEARCHUSERS(txtsearch.Text);
            dgvusers.DataSource = DT;
        }
        
        private void btndelete_Click(object sender, EventArgs e)
        {
            I = int.Parse(dgvusers.SelectedRows[0].Cells[0].Value.ToString());
            CLASS_USERS.SP_DELETEUSER(I);
            MessageBox.Show("Supprimer avec succes!");
            btndisplay_Click(null, null);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
