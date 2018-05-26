namespace InventoryManagment.PL
{
    partial class Form_NewPurchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dtpFacture = new System.Windows.Forms.DateTimePicker();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.PrintPurchase = new System.Windows.Forms.Button();
            this.btnAddnewPurchase = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRef);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.dtpFacture);
            this.groupBox1.Controls.Add(this.txtBuyerName);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les données de facturation";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(130, 21);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(279, 20);
            this.txtRef.TabIndex = 5;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(6, 22);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(77, 19);
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "Facture REF";
            // 
            // dtpFacture
            // 
            this.dtpFacture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFacture.Location = new System.Drawing.Point(130, 57);
            this.dtpFacture.Name = "dtpFacture";
            this.dtpFacture.Size = new System.Drawing.Size(279, 20);
            this.dtpFacture.TabIndex = 3;
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Location = new System.Drawing.Point(130, 91);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(279, 20);
            this.txtBuyerName.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nom de l\'acheteur";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 58);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Date Facture";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddSupplier);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtFax);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.txtSupplierName);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Location = new System.Drawing.Point(491, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les données de Fournisseur";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.ForeColor = System.Drawing.Color.Gray;
            this.btnAddSupplier.Location = new System.Drawing.Point(363, 21);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(32, 20);
            this.btnAddSupplier.TabIndex = 12;
            this.btnAddSupplier.Text = ".....";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(178, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(179, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(178, 105);
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(179, 20);
            this.txtFax.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(178, 77);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(179, 20);
            this.txtTel.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(178, 49);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(179, 20);
            this.txtID.TabIndex = 8;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(178, 21);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.Size = new System.Drawing.Size(179, 20);
            this.txtSupplierName.TabIndex = 7;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 132);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Email";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 104);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(28, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Fax";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 76);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(24, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Tel";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 48);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "ID de Fournisseur";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 20);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(128, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Nom de Fournisseur";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvProducts);
            this.groupBox3.Location = new System.Drawing.Point(23, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(918, 143);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Les Produits";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.productname,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.GridColor = System.Drawing.Color.Gray;
            this.dgvProducts.Location = new System.Drawing.Point(3, 16);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(912, 124);
            this.dgvProducts.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // productname
            // 
            this.productname.HeaderText = "Nom de Produit";
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numéro de série";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Garantie Expiration ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "prix";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.metroLabel8);
            this.groupBox4.Controls.Add(this.btnAddProduct);
            this.groupBox4.Location = new System.Drawing.Point(23, 377);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(918, 44);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Gray;
            this.btnDelete.Location = new System.Drawing.Point(281, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 27);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Supprimer le produit sélectionné";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(708, 12);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(179, 20);
            this.txtTotal.TabIndex = 15;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(643, 13);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(36, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Total";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.White;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.Gray;
            this.btnAddProduct.Location = new System.Drawing.Point(23, 13);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(197, 27);
            this.btnAddProduct.TabIndex = 13;
            this.btnAddProduct.Text = "Ajouter un Produit Dans la facture";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.Controls.Add(this.PrintPurchase);
            this.groupBox5.Controls.Add(this.btnAddnewPurchase);
            this.groupBox5.Location = new System.Drawing.Point(23, 428);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(918, 75);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Operation";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Gray;
            this.btnCancel.Location = new System.Drawing.Point(559, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(197, 27);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PrintPurchase
            // 
            this.PrintPurchase.BackColor = System.Drawing.Color.White;
            this.PrintPurchase.Enabled = false;
            this.PrintPurchase.FlatAppearance.BorderSize = 0;
            this.PrintPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPurchase.ForeColor = System.Drawing.Color.Gray;
            this.PrintPurchase.Location = new System.Drawing.Point(281, 30);
            this.PrintPurchase.Name = "PrintPurchase";
            this.PrintPurchase.Size = new System.Drawing.Size(197, 27);
            this.PrintPurchase.TabIndex = 18;
            this.PrintPurchase.Text = "Imprimer la facture";
            this.PrintPurchase.UseVisualStyleBackColor = false;
            this.PrintPurchase.Click += new System.EventHandler(this.PrintPurchase_Click);
            // 
            // btnAddnewPurchase
            // 
            this.btnAddnewPurchase.BackColor = System.Drawing.Color.White;
            this.btnAddnewPurchase.FlatAppearance.BorderSize = 0;
            this.btnAddnewPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddnewPurchase.ForeColor = System.Drawing.Color.Gray;
            this.btnAddnewPurchase.Location = new System.Drawing.Point(23, 30);
            this.btnAddnewPurchase.Name = "btnAddnewPurchase";
            this.btnAddnewPurchase.Size = new System.Drawing.Size(197, 27);
            this.btnAddnewPurchase.TabIndex = 17;
            this.btnAddnewPurchase.Text = "Enregistrer la facture";
            this.btnAddnewPurchase.UseVisualStyleBackColor = false;
            this.btnAddnewPurchase.Click += new System.EventHandler(this.btnAddnewPurchase_Click);
            // 
            // Form_NewPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 523);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form_NewPurchase";
            this.Resizable = false;
            this.Text = "Facturation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dtpFacture;
        private System.Windows.Forms.TextBox txtBuyerName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtTotal;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button PrintPurchase;
        private System.Windows.Forms.Button btnAddnewPurchase;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtRef;
        private MetroFramework.Controls.MetroLabel metroLabel9;
    }
}