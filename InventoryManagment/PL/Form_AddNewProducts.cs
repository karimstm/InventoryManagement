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
using MetroFramework;

namespace InventoryManagment.PL
{
    public partial class Form_AddNewProducts : MetroForm
    {
        public static bool _Checked;
        public static string _CheckForm;
        public Form_AddNewProducts(string CheckForm)
        {
            InitializeComponent();
            _CheckForm = CheckForm;
            //-----------------------------------------------------------
            DataTable Categorydt = CLASS_PRODUCTS.SP_FILLCMBCATEGORY();
            cmbCategory.DataSource = Categorydt;
            cmbCategory.DisplayMember = "Cat_Name";
            cmbCategory.ValueMember = "Cat_ID";
            //------------------------------------------------------------
            DataTable Marquedt = CLASS_PRODUCTS.SP_FILLCMBBRAND();
            cmbMarque.DataSource = Marquedt;
            cmbMarque.DisplayMember = "Brand_Name";
            cmbMarque.ValueMember = "Brand_ID";
            //------------------------------------------------------------
            DataTable Etatdt = CLASS_PRODUCTS.SP_FILLCMBETAT();
            cmbEtat.DataSource = Etatdt;
            cmbEtat.DisplayMember = "State_Nom";
            cmbEtat.ValueMember = "State_ID";
            //-----------------------------------------------------------
            DataTable MagazinDT = CLASS_PRODUCTS.SP_FILLCMBWAREHOUSE();
            cmbEmplacement.DataSource = MagazinDT;
            cmbEmplacement.DisplayMember = "WareHouse_Location";
            cmbEmplacement.ValueMember = "WareHouse_ID";
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (_CheckForm == "New")
            {
                this.Text = "Ajouter un Produit";
                btnADD.Text = "Ajouter";
            }
            else if (_CheckForm == "Update")
            {
                this.Text = "Editer le Produit";
                btnADD.Text = "Editer";
                DataTable dt = CLASS_PRODUCTS.SP_DISPLAYALLPRODUCTSBYID(Form_ProductsManagement.I);
                foreach (DataRow dr in dt.Rows)
                {
                    txtName.Text = dr["P_ID"].ToString();
                    cmbCategory.Text = dr["Cat_Name"].ToString();
                    cmbMarque.Text = dr["Brand_Name"].ToString();
                    txtSerialNumber.Text = dr["Serial_Number"].ToString();
                    cmbEtat.Text = dr["State_Nom"].ToString();
                    txtUser.Text = dr["U_Name"].ToString();
                    cmbEmplacement.Text = dr["WareHouse_Location"].ToString();
                    byte[] Arr = (byte[])dr["P_Image"];
                    MemoryStream ms = new MemoryStream(Arr);
                    PICIMAGE.Image = Image.FromStream(ms);
                    dtpexpiration.Text = dr["EXPIRE_DATE"].ToString();
                    dtpDeleviry.Text = dr["Acquisition_Date"].ToString();
                    dtploueexpiration.Text = dr["lease_Expire"].ToString();
                    if (dr["leased"].ToString() == 0.ToString())
                    {
                        OuiRadioBTN.Checked = true;
                    }
                    else
                    {
                        NonRadioBTN.Checked = true;
                    }
                    txtPrice.Text = dr["P_Price"].ToString();
                    txtDescription.Text = dr["P_Description"].ToString();
                    txtdeliveryguy.Text = dr["Delivered_BY"].ToString();


                }
            }


        }
        object leasedate;
        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {

                MemoryStream ms = new MemoryStream();
                PICIMAGE.Image.Save(ms, PICIMAGE.Image.RawFormat);
                byte[] arr = ms.ToArray();

                if (_CheckForm == "New")
                {
                    if (txtSerialNumber.Text != string.Empty && txtName.Text != string.Empty)
                    {

                        CLASS_PRODUCTS.SP_ADDNEWPRODUCTS((int)cmbMarque.SelectedValue, (int)cmbCategory.SelectedValue, arr, txtName.Text,
                              txtDescription.Text, double.Parse(txtPrice.Text), txtSerialNumber.Text, txtUser.Text, (int)cmbEmplacement.SelectedValue,
                               _Checked, leasedate, txtdeliveryguy.Text, dtpDeleviry.Value, dtpexpiration.Value, (int)cmbEtat.SelectedValue);
                        MessageBox.Show("Ajouté avec succès", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Remplir les champs obligatoires", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (_CheckForm == "Update")
                {
                    
                    CLASS_PRODUCTS.SP_UPDATEPRODUCTS((int)cmbMarque.SelectedValue, (int)cmbCategory.SelectedValue, arr, txtName.Text,
                              txtDescription.Text, double.Parse(txtPrice.Text), txtSerialNumber.Text, txtUser.Text, (int)cmbEmplacement.SelectedValue,
                               _Checked, leasedate, txtdeliveryguy.Text, dtpDeleviry.Value, dtpexpiration.Value, (int)cmbEtat.SelectedValue);
                    MessageBox.Show("Editer avec succès", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void OuiRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            _Checked = true;
            dtploueexpiration.Enabled = true;
            leasedate = dtploueexpiration.Value;

        }

        private void NonRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            _Checked = false;
            dtploueexpiration.Enabled = false;
            leasedate = DBNull.Value;
            

        }

        private void btnImageUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files |*.*|JPG|*.jpg|PNG|*.png";
            ofd.ShowDialog();
            PICIMAGE.Image = Image.FromFile(ofd.FileName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            new Form_ProductsManagement().ShowDialog();
        }
    }
}
