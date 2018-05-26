namespace InventoryManagment.PL
{
    partial class Form_ProductsManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvquantity = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.dgvfilter = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBFilter = new System.Windows.Forms.ComboBox();
            this.BTNSEARCH = new System.Windows.Forms.Button();
            this.PrintSelectedProduct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfilter)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche d\'un Produit";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(183, 64);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvProduit);
            this.groupBox1.Location = new System.Drawing.Point(30, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1135, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les données";
            // 
            // dgvProduit
            // 
            this.dgvProduit.AllowUserToAddRows = false;
            this.dgvProduit.AllowUserToDeleteRows = false;
            this.dgvProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduit.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduit.Location = new System.Drawing.Point(3, 19);
            this.dgvProduit.MultiSelect = false;
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.ReadOnly = true;
            this.dgvProduit.RowHeadersVisible = false;
            this.dgvProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduit.Size = new System.Drawing.Size(1129, 176);
            this.dgvProduit.TabIndex = 0;
            this.dgvProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvquantity);
            this.groupBox2.Location = new System.Drawing.Point(26, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1135, 89);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details Aditionale";
            // 
            // dgvquantity
            // 
            this.dgvquantity.AllowUserToAddRows = false;
            this.dgvquantity.AllowUserToDeleteRows = false;
            this.dgvquantity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvquantity.BackgroundColor = System.Drawing.Color.White;
            this.dgvquantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvquantity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvquantity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dgvquantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvquantity.Location = new System.Drawing.Point(3, 19);
            this.dgvquantity.MultiSelect = false;
            this.dgvquantity.Name = "dgvquantity";
            this.dgvquantity.ReadOnly = true;
            this.dgvquantity.RowHeadersVisible = false;
            this.dgvquantity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvquantity.Size = new System.Drawing.Size(1129, 67);
            this.dgvquantity.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Marque";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Categorie";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Description";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Prix";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Emplacement";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Livre par";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Acquisation";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Etat Produit";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(169)))), ((int)(((byte)(224)))));
            this.btnDisplay.FlatAppearance.BorderSize = 0;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisplay.Location = new System.Drawing.Point(444, 61);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(92, 29);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Afficher";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(169)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(542, 61);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 29);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Editer";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(169)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(640, 61);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(169)))), ((int)(((byte)(224)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(738, 61);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(137, 29);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Imprimer Les Produit";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(169)))), ((int)(((byte)(224)))));
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(1066, 61);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(101, 29);
            this.btnImage.TabIndex = 8;
            this.btnImage.Text = "Afficher Image";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // dgvfilter
            // 
            this.dgvfilter.AllowUserToAddRows = false;
            this.dgvfilter.AllowUserToDeleteRows = false;
            this.dgvfilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvfilter.BackgroundColor = System.Drawing.Color.White;
            this.dgvfilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvfilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvfilter.Location = new System.Drawing.Point(3, 19);
            this.dgvfilter.MultiSelect = false;
            this.dgvfilter.Name = "dgvfilter";
            this.dgvfilter.ReadOnly = true;
            this.dgvfilter.RowHeadersVisible = false;
            this.dgvfilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfilter.Size = new System.Drawing.Size(1133, 112);
            this.dgvfilter.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvfilter);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(23, 428);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1139, 134);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Group By";
            // 
            // CMBFilter
            // 
            this.CMBFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBFilter.FormattingEnabled = true;
            this.CMBFilter.Items.AddRange(new object[] {
            "Quantité"});
            this.CMBFilter.Location = new System.Drawing.Point(122, 400);
            this.CMBFilter.Name = "CMBFilter";
            this.CMBFilter.Size = new System.Drawing.Size(168, 23);
            this.CMBFilter.TabIndex = 15;
            this.CMBFilter.SelectedIndexChanged += new System.EventHandler(this.CMBFilter_SelectedIndexChanged_1);
            // 
            // BTNSEARCH
            // 
            this.BTNSEARCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(169)))), ((int)(((byte)(224)))));
            this.BTNSEARCH.FlatAppearance.BorderSize = 0;
            this.BTNSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSEARCH.ForeColor = System.Drawing.Color.White;
            this.BTNSEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNSEARCH.Location = new System.Drawing.Point(393, 64);
            this.BTNSEARCH.Name = "BTNSEARCH";
            this.BTNSEARCH.Size = new System.Drawing.Size(43, 23);
            this.BTNSEARCH.TabIndex = 16;
            this.BTNSEARCH.Text = ">>";
            this.BTNSEARCH.UseVisualStyleBackColor = false;
            this.BTNSEARCH.Click += new System.EventHandler(this.BTNSEARCH_Click);
            // 
            // PrintSelectedProduct
            // 
            this.PrintSelectedProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(169)))), ((int)(((byte)(224)))));
            this.PrintSelectedProduct.FlatAppearance.BorderSize = 0;
            this.PrintSelectedProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintSelectedProduct.ForeColor = System.Drawing.Color.White;
            this.PrintSelectedProduct.Location = new System.Drawing.Point(881, 61);
            this.PrintSelectedProduct.Name = "PrintSelectedProduct";
            this.PrintSelectedProduct.Size = new System.Drawing.Size(179, 29);
            this.PrintSelectedProduct.TabIndex = 17;
            this.PrintSelectedProduct.Text = "Imprimer le Produit selectione";
            this.PrintSelectedProduct.UseVisualStyleBackColor = false;
            this.PrintSelectedProduct.Click += new System.EventHandler(this.PrintSelectedProduct_Click);
            // 
            // Form_ProductsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 586);
            this.Controls.Add(this.PrintSelectedProduct);
            this.Controls.Add(this.BTNSEARCH);
            this.Controls.Add(this.CMBFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form_ProductsManagement";
            this.Padding = new System.Windows.Forms.Padding(23, 70, 23, 24);
            this.Resizable = false;
            this.Text = "Gestion des produits";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form_ProductsManagement_Activated);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfilter)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProduit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvquantity;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.DataGridView dgvfilter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMBFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button BTNSEARCH;
        private System.Windows.Forms.Button PrintSelectedProduct;
    }
}