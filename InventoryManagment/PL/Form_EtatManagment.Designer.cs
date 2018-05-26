namespace InventoryManagment.PL
{
    partial class Form_EtatManagment
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEtat = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "L\'ID ou le Nom de l\'État";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(179, 85);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(270, 22);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEtat);
            this.groupBox1.Location = new System.Drawing.Point(24, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Donnes";
            // 
            // dgvEtat
            // 
            this.dgvEtat.AllowUserToAddRows = false;
            this.dgvEtat.AllowUserToDeleteRows = false;
            this.dgvEtat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEtat.BackgroundColor = System.Drawing.Color.White;
            this.dgvEtat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEtat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEtat.Location = new System.Drawing.Point(3, 18);
            this.dgvEtat.MultiSelect = false;
            this.dgvEtat.Name = "dgvEtat";
            this.dgvEtat.ReadOnly = true;
            this.dgvEtat.RowHeadersVisible = false;
            this.dgvEtat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtat.Size = new System.Drawing.Size(435, 153);
            this.dgvEtat.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAddNew);
            this.groupBox2.Controls.Add(this.btnDisplayAll);
            this.groupBox2.Location = new System.Drawing.Point(27, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Orange;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(335, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(230, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Editer";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Orange;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(129, 20);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Ajouter";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.BackColor = System.Drawing.Color.Orange;
            this.btnDisplayAll.FlatAppearance.BorderSize = 0;
            this.btnDisplayAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAll.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAll.Location = new System.Drawing.Point(20, 20);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayAll.TabIndex = 0;
            this.btnDisplayAll.Text = "Afficher tout";
            this.btnDisplayAll.UseVisualStyleBackColor = false;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // Form_EtatManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form_EtatManagment";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Gestion de l\'État";
            this.Activated += new System.EventHandler(this.Form_EtatManagment_Activated);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEtat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnDelete;
    }
}