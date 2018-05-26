namespace InventoryManagment.PL
{
    partial class Form_Marque
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtmarque = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nom de la marque";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtmarque);
            this.panel1.Location = new System.Drawing.Point(150, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 31);
            this.panel1.TabIndex = 1;
            // 
            // txtmarque
            // 
            this.txtmarque.Location = new System.Drawing.Point(3, 5);
            this.txtmarque.Name = "txtmarque";
            this.txtmarque.Size = new System.Drawing.Size(257, 22);
            this.txtmarque.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Teal;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(150, 156);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(96, 33);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Teal;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(314, 156);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(96, 33);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Form_Marque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 216);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "Form_Marque";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Ajouter une marque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtmarque;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
    }
}