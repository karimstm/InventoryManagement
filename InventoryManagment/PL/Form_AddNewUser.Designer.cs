namespace InventoryManagment.PL
{
    partial class Form_AddNewUser
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
            this.cmbPermission = new System.Windows.Forms.ComboBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.txtPasswrod = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPermission);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtPasswordConfirmation);
            this.groupBox1.Controls.Add(this.txtPasswrod);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(11, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "données de l\'utilisateur";
            // 
            // cmbPermission
            // 
            this.cmbPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermission.FormattingEnabled = true;
            this.cmbPermission.Location = new System.Drawing.Point(212, 243);
            this.cmbPermission.Name = "cmbPermission";
            this.cmbPermission.Size = new System.Drawing.Size(248, 21);
            this.cmbPermission.TabIndex = 19;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(212, 196);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(248, 23);
            this.txtFullName.TabIndex = 18;
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(212, 140);
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.PasswordChar = '*';
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(248, 23);
            this.txtPasswordConfirmation.TabIndex = 17;
            // 
            // txtPasswrod
            // 
            this.txtPasswrod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswrod.Location = new System.Drawing.Point(212, 85);
            this.txtPasswrod.Name = "txtPasswrod";
            this.txtPasswrod.PasswordChar = '*';
            this.txtPasswrod.Size = new System.Drawing.Size(248, 23);
            this.txtPasswrod.TabIndex = 16;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(212, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(248, 23);
            this.txtUsername.TabIndex = 15;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 246);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Autorisation";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 141);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(188, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Confirmation de mot de passe";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 196);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Nom complet";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Mot de passe";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Nom d\'utilisateur";
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.SteelBlue;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(58, 387);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(105, 32);
            this.btn.TabIndex = 1;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(366, 387);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(105, 32);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Form_AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 449);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form_AddNewUser";
            this.Resizable = false;
            this.Text = "Ajouter un utilisateur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPermission;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPasswordConfirmation;
        private System.Windows.Forms.TextBox txtPasswrod;
        private System.Windows.Forms.TextBox txtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btncancel;
    }
}