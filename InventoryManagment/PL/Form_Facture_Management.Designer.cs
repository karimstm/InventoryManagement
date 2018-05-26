namespace InventoryManagment.PL
{
    partial class Form_Facture_Management
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
            this.dgvFacture = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnSEarch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnCAncel = new System.Windows.Forms.Button();
            this.btnPrintSelected = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFacture);
            this.groupBox1.Location = new System.Drawing.Point(23, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvFacture
            // 
            this.dgvFacture.AllowUserToAddRows = false;
            this.dgvFacture.AllowUserToDeleteRows = false;
            this.dgvFacture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacture.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacture.Location = new System.Drawing.Point(3, 16);
            this.dgvFacture.MultiSelect = false;
            this.dgvFacture.Name = "dgvFacture";
            this.dgvFacture.ReadOnly = true;
            this.dgvFacture.RowHeadersVisible = false;
            this.dgvFacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacture.Size = new System.Drawing.Size(842, 249);
            this.dgvFacture.TabIndex = 0;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(319, 64);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(248, 23);
            this.txtsearch.TabIndex = 1;
            // 
            // btnSEarch
            // 
            this.btnSEarch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSEarch.FlatAppearance.BorderSize = 0;
            this.btnSEarch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEarch.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEarch.ForeColor = System.Drawing.Color.White;
            this.btnSEarch.Location = new System.Drawing.Point(576, 60);
            this.btnSEarch.Name = "btnSEarch";
            this.btnSEarch.Size = new System.Drawing.Size(42, 30);
            this.btnSEarch.TabIndex = 2;
            this.btnSEarch.Text = ">>";
            this.btnSEarch.UseVisualStyleBackColor = false;
            this.btnSEarch.Click += new System.EventHandler(this.btnSEarch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(245, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDisplay.FlatAppearance.BorderSize = 0;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Location = new System.Drawing.Point(45, 374);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(128, 25);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Afficher";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnCAncel
            // 
            this.btnCAncel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCAncel.FlatAppearance.BorderSize = 0;
            this.btnCAncel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAncel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAncel.ForeColor = System.Drawing.Color.White;
            this.btnCAncel.Location = new System.Drawing.Point(721, 374);
            this.btnCAncel.Name = "btnCAncel";
            this.btnCAncel.Size = new System.Drawing.Size(128, 25);
            this.btnCAncel.TabIndex = 5;
            this.btnCAncel.Text = "Annuler";
            this.btnCAncel.UseVisualStyleBackColor = false;
            this.btnCAncel.Click += new System.EventHandler(this.btnCAncel_Click);
            // 
            // btnPrintSelected
            // 
            this.btnPrintSelected.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintSelected.FlatAppearance.BorderSize = 0;
            this.btnPrintSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSelected.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSelected.ForeColor = System.Drawing.Color.White;
            this.btnPrintSelected.Location = new System.Drawing.Point(445, 374);
            this.btnPrintSelected.Name = "btnPrintSelected";
            this.btnPrintSelected.Size = new System.Drawing.Size(204, 25);
            this.btnPrintSelected.TabIndex = 6;
            this.btnPrintSelected.Text = "Imprimer facture selectioner";
            this.btnPrintSelected.UseVisualStyleBackColor = false;
            this.btnPrintSelected.Click += new System.EventHandler(this.btnPrintSelected_Click);
            // 
            // Form_Facture_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 422);
            this.Controls.Add(this.btnPrintSelected);
            this.Controls.Add(this.btnCAncel);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSEarch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Facture_Management";
            this.Resizable = false;
            this.Text = "Gestion Des Facture";
            this.Activated += new System.EventHandler(this.Form_Facture_Management_Activated);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFacture;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnSEarch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnCAncel;
        private System.Windows.Forms.Button btnPrintSelected;
    }
}