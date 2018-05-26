namespace InventoryManagment.PL
{
    partial class Form_CategoryManagment
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(243, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nom ou ID de la catégorie à rechercher";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(266, 78);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(368, 25);
            this.txtDisplay.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(649, 78);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCatName);
            this.groupBox1.Controls.Add(this.txtCatID);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(7, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données de catégorie";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 32);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(21, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "ID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 79);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(120, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Nom de Categorie";
            // 
            // txtCatID
            // 
            this.txtCatID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatID.Location = new System.Drawing.Point(147, 32);
            this.txtCatID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.ReadOnly = true;
            this.txtCatID.Size = new System.Drawing.Size(286, 25);
            this.txtCatID.TabIndex = 3;
            // 
            // txtCatName
            // 
            this.txtCatName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatName.Location = new System.Drawing.Point(147, 73);
            this.txtCatName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(286, 25);
            this.txtCatName.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCategory);
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(459, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 299);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Catégories";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnDisplayAll);
            this.groupBox3.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(7, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 158);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operations";
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDisplayAll.FlatAppearance.BorderSize = 0;
            this.btnDisplayAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAll.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAll.Location = new System.Drawing.Point(6, 36);
            this.btnDisplayAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(187, 35);
            this.btnDisplayAll.TabIndex = 3;
            this.btnDisplayAll.Text = "Afficher toutes les catégories";
            this.btnDisplayAll.UseVisualStyleBackColor = false;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(254, 87);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(162, 35);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Imprimer les catégories";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(199, 36);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(217, 35);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Modifier la catégorie sélectionnée";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(6, 87);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(237, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Supprimer la catégorie sélectionnée";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.Location = new System.Drawing.Point(3, 21);
            this.dgvCategory.MultiSelect = false;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(489, 275);
            this.dgvCategory.TabIndex = 0;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // Form_CategoryManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_CategoryManagment";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de Categorie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.TextBox txtCatID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.DataGridView dgvCategory;
    }
}