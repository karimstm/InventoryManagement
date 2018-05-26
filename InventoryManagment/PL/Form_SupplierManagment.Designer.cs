namespace InventoryManagment.PL
{
    partial class Form_SupplierManagment
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnCAncel = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtfax = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnDisplayall = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSuppliers);
            this.groupBox1.Location = new System.Drawing.Point(11, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "les données";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnDisplayall);
            this.groupBox2.Controls.Add(this.btnCAncel);
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(358, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Location = new System.Drawing.Point(11, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 66);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rechercher";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCounty);
            this.groupBox4.Controls.Add(this.txtAdress);
            this.groupBox4.Controls.Add(this.txtemail);
            this.groupBox4.Controls.Add(this.txtfax);
            this.groupBox4.Controls.Add(this.txtPhone);
            this.groupBox4.Controls.Add(this.txtName);
            this.groupBox4.Controls.Add(this.metroLabel6);
            this.groupBox4.Controls.Add(this.metroLabel5);
            this.groupBox4.Controls.Add(this.metroLabel4);
            this.groupBox4.Controls.Add(this.metroLabel3);
            this.groupBox4.Controls.Add(this.metroLabel2);
            this.groupBox4.Controls.Add(this.metroLabel1);
            this.groupBox4.Location = new System.Drawing.Point(11, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(913, 176);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "les données des fournisseur";
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuppliers.Location = new System.Drawing.Point(3, 16);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(907, 157);
            this.dgvSuppliers.TabIndex = 0;
            this.dgvSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(10, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(198, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(293, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 38);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Mise a jour";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(388, 14);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(76, 38);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnCAncel
            // 
            this.btnCAncel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCAncel.FlatAppearance.BorderSize = 0;
            this.btnCAncel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAncel.ForeColor = System.Drawing.Color.White;
            this.btnCAncel.Location = new System.Drawing.Point(483, 14);
            this.btnCAncel.Name = "btnCAncel";
            this.btnCAncel.Size = new System.Drawing.Size(76, 38);
            this.btnCAncel.TabIndex = 3;
            this.btnCAncel.Text = "Annuler";
            this.btnCAncel.UseVisualStyleBackColor = false;
            this.btnCAncel.Click += new System.EventHandler(this.btnCAncel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nom de Fornisseur";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(50, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Tel";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(50, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(28, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Fax";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(479, 37);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "E-mail";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(479, 76);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Adresse";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(479, 121);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(34, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Pays";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(193, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 23);
            this.txtName.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(193, 80);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(243, 23);
            this.txtPhone.TabIndex = 7;
            // 
            // txtfax
            // 
            this.txtfax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfax.Location = new System.Drawing.Point(193, 125);
            this.txtfax.Name = "txtfax";
            this.txtfax.Size = new System.Drawing.Size(243, 23);
            this.txtfax.TabIndex = 8;
            // 
            // txtCounty
            // 
            this.txtCounty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Location = new System.Drawing.Point(551, 125);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(243, 23);
            this.txtCounty.TabIndex = 11;
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(551, 80);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(243, 39);
            this.txtAdress.TabIndex = 10;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(551, 37);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(243, 23);
            this.txtemail.TabIndex = 9;
            // 
            // btnDisplayall
            // 
            this.btnDisplayall.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDisplayall.FlatAppearance.BorderSize = 0;
            this.btnDisplayall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayall.ForeColor = System.Drawing.Color.White;
            this.btnDisplayall.Location = new System.Drawing.Point(103, 14);
            this.btnDisplayall.Name = "btnDisplayall";
            this.btnDisplayall.Size = new System.Drawing.Size(76, 38);
            this.btnDisplayall.TabIndex = 4;
            this.btnDisplayall.Text = "Afficher";
            this.btnDisplayall.UseVisualStyleBackColor = false;
            this.btnDisplayall.Click += new System.EventHandler(this.btnDisplayall_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(8, 14);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(76, 38);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Form_SupplierManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 524);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form_SupplierManagment";
            this.Resizable = false;
            this.Text = "Gestion des Fornisseurs";
            this.Activated += new System.EventHandler(this.Form_SupplierManagment_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Button btnCAncel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtfax;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnDisplayall;
        private System.Windows.Forms.Button btnNew;
    }
}