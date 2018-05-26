namespace InventoryManagment.PL
{
    partial class Form_usersManangment
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvusers = new System.Windows.Forms.DataGridView();
            this.btncancel = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechercher";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(180, 70);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(259, 20);
            this.txtsearch.TabIndex = 1;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(445, 68);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(46, 23);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = ">>";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvusers);
            this.groupBox1.Location = new System.Drawing.Point(23, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 313);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les utilisateurs";
            // 
            // dgvusers
            // 
            this.dgvusers.AllowUserToAddRows = false;
            this.dgvusers.AllowUserToDeleteRows = false;
            this.dgvusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvusers.BackgroundColor = System.Drawing.Color.White;
            this.dgvusers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvusers.Location = new System.Drawing.Point(3, 16);
            this.dgvusers.MultiSelect = false;
            this.dgvusers.Name = "dgvusers";
            this.dgvusers.ReadOnly = true;
            this.dgvusers.RowHeadersVisible = false;
            this.dgvusers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvusers.Size = new System.Drawing.Size(895, 294);
            this.dgvusers.TabIndex = 0;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(747, 460);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(105, 32);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(519, 460);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 32);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(334, 460);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(105, 32);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Editer";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.BackColor = System.Drawing.Color.SteelBlue;
            this.btndisplay.FlatAppearance.BorderSize = 0;
            this.btndisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndisplay.ForeColor = System.Drawing.Color.White;
            this.btndisplay.Location = new System.Drawing.Point(112, 460);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(105, 32);
            this.btndisplay.TabIndex = 7;
            this.btndisplay.Text = "Afficher";
            this.btndisplay.UseVisualStyleBackColor = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // Form_usersManangment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 515);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Name = "Form_usersManangment";
            this.Resizable = false;
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.Form_usersManangment_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.DataGridView dgvusers;
    }
}