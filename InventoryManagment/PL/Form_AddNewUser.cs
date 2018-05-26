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
    public partial class Form_AddNewUser : MetroForm
    {
        bool IsUpdate;
        public Form_AddNewUser(bool _IsUpdate)
        {
            InitializeComponent();
            this.IsUpdate = _IsUpdate;
            //--------------------------------------
            DataTable dt = CLASS_USERS.SP_FULLCMBPERM();
            cmbPermission.DataSource = dt;
            cmbPermission.DisplayMember = "Per_Name";
            cmbPermission.ValueMember = "Per_ID";
            //---------------------------------------
            if (IsUpdate)
            {
                this.Text = "Editer l'utilisateur";
                btn.Text = "Editer";
                DataTable dtbyid = CLASS_USERS.SP_DISPLAYALLUSERSBYID(Form_usersManangment.I);
                foreach (DataRow dr in dtbyid.Rows)
                {
                    txtUsername.Text = dr["USERNAME"].ToString();
                    txtPasswrod.Text = dr["PASSWORD"].ToString();
                    txtPasswordConfirmation.Text = dr["PASSWORD"].ToString();
                    txtFullName.Text = dr["FULLNAME"].ToString();
                    cmbPermission.Text = dr["PERMISSION"].ToString();
                }

            }
            else
            {
                this.Text = "Ajouter un utilisateur";
                btn.Text = "Ajouter";
            }
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Ajouter le nom de d'utilisateur!");
                    return;
                }
                else if (txtPasswrod.Text != txtPasswordConfirmation.Text)
                {
                    MessageBox.Show("Les champs de mot de passe doivent être similaires");
                    return;
                }
                else if (txtPasswrod.Text == "")
                {
                    MessageBox.Show("Enter un mot de passe");
                    return;
                }
                else if (txtFullName.Text == "")
                {
                    MessageBox.Show("Vous devez entrer votre nom complet");
                    return;
                }

                if (IsUpdate)
                {
                    CLASS_USERS.SP_UPDATEUSERS(Form_usersManangment.I, txtUsername.Text, txtPasswrod.Text, txtFullName.Text, int.Parse(cmbPermission.SelectedValue.ToString()));
                    MessageBox.Show("editer avec succes!");
                }
                else
                {
                    CLASS_USERS.SP_ADDNEWUSER(txtUsername.Text, txtPasswrod.Text, txtFullName.Text, int.Parse(cmbPermission.SelectedValue.ToString()));
                    MessageBox.Show("Ajouter avec succes!");
                    foreach (Control c in groupBox1.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
