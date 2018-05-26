namespace InventoryManagment.PL
{
    partial class Form_Etat
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
            this.txtEtatName = new System.Windows.Forms.TextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Libele";
            // 
            // txtEtatName
            // 
            this.txtEtatName.Location = new System.Drawing.Point(118, 72);
            this.txtEtatName.Name = "txtEtatName";
            this.txtEtatName.Size = new System.Drawing.Size(260, 23);
            this.txtEtatName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(118, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 34);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(275, 123);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(103, 34);
            this.btncancel.Style = MetroFramework.MetroColorStyle.Blue;
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseSelectable = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Form_Etat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 193);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEtatName);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form_Etat";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "État du produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtEtatName;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btncancel;
    }
}