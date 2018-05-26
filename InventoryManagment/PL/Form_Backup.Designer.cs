namespace InventoryManagment.PL
{
    partial class Form_Backup
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
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnbackup = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnpath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Répertoire";
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(117, 81);
            this.txtpath.Name = "txtpath";
            this.txtpath.ReadOnly = true;
            this.txtpath.Size = new System.Drawing.Size(307, 20);
            this.txtpath.TabIndex = 1;
            // 
            // btnbackup
            // 
            this.btnbackup.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnbackup.FlatAppearance.BorderSize = 0;
            this.btnbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbackup.ForeColor = System.Drawing.Color.White;
            this.btnbackup.Location = new System.Drawing.Point(117, 130);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(100, 30);
            this.btnbackup.TabIndex = 3;
            this.btnbackup.Text = "Sauvegarde";
            this.btnbackup.UseVisualStyleBackColor = false;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(304, 130);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(100, 30);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnpath
            // 
            this.btnpath.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpath.FlatAppearance.BorderSize = 0;
            this.btnpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpath.ForeColor = System.Drawing.Color.White;
            this.btnpath.Location = new System.Drawing.Point(430, 81);
            this.btnpath.Name = "btnpath";
            this.btnpath.Size = new System.Drawing.Size(44, 20);
            this.btnpath.TabIndex = 5;
            this.btnpath.Text = "....";
            this.btnpath.UseVisualStyleBackColor = false;
            this.btnpath.Click += new System.EventHandler(this.btnpath_Click);
            // 
            // Form_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 183);
            this.Controls.Add(this.btnpath);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnbackup);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "Form_Backup";
            this.Resizable = false;
            this.Text = "Sauvegarder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnbackup;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnpath;
    }
}