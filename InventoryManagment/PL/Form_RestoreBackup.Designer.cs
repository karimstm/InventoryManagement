namespace InventoryManagment.PL
{
    partial class Form_RestoreBackup
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
            this.btnpath = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnrestore = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnpath
            // 
            this.btnpath.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpath.FlatAppearance.BorderSize = 0;
            this.btnpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpath.ForeColor = System.Drawing.Color.White;
            this.btnpath.Location = new System.Drawing.Point(423, 73);
            this.btnpath.Name = "btnpath";
            this.btnpath.Size = new System.Drawing.Size(44, 20);
            this.btnpath.TabIndex = 10;
            this.btnpath.Text = "....";
            this.btnpath.UseVisualStyleBackColor = false;
            this.btnpath.Click += new System.EventHandler(this.btnpath_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(297, 122);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(100, 30);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnrestore
            // 
            this.btnrestore.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnrestore.FlatAppearance.BorderSize = 0;
            this.btnrestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestore.ForeColor = System.Drawing.Color.White;
            this.btnrestore.Location = new System.Drawing.Point(110, 122);
            this.btnrestore.Name = "btnrestore";
            this.btnrestore.Size = new System.Drawing.Size(100, 30);
            this.btnrestore.TabIndex = 8;
            this.btnrestore.Text = "Restaurer";
            this.btnrestore.UseVisualStyleBackColor = false;
            this.btnrestore.Click += new System.EventHandler(this.btnrestore_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(110, 73);
            this.txtpath.Name = "txtpath";
            this.txtpath.ReadOnly = true;
            this.txtpath.Size = new System.Drawing.Size(307, 20);
            this.txtpath.TabIndex = 7;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Répertoire";
            // 
            // Form_RestoreBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 176);
            this.Controls.Add(this.btnpath);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnrestore);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form_RestoreBackup";
            this.Resizable = false;
            this.Text = "Restauration de base de données";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpath;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnrestore;
        private System.Windows.Forms.TextBox txtpath;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}