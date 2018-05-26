namespace InventoryManagment.PL
{
    partial class Form_Category
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtCategoryName = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nom de catégorie";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtCategoryName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 13;
            this.metroPanel1.Location = new System.Drawing.Point(189, 94);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(275, 48);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 12;
            // 
            // txtCategoryName
            // 
            // 
            // 
            // 
            this.txtCategoryName.CustomButton.Image = null;
            this.txtCategoryName.CustomButton.Location = new System.Drawing.Point(239, 2);
            this.txtCategoryName.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryName.CustomButton.Name = "";
            this.txtCategoryName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCategoryName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCategoryName.CustomButton.TabIndex = 1;
            this.txtCategoryName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCategoryName.CustomButton.UseSelectable = true;
            this.txtCategoryName.CustomButton.Visible = false;
            this.txtCategoryName.Lines = new string[0];
            this.txtCategoryName.Location = new System.Drawing.Point(5, 9);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryName.MaxLength = 32767;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PasswordChar = '\0';
            this.txtCategoryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategoryName.SelectedText = "";
            this.txtCategoryName.SelectionLength = 0;
            this.txtCategoryName.SelectionStart = 0;
            this.txtCategoryName.ShortcutsEnabled = true;
            this.txtCategoryName.Size = new System.Drawing.Size(267, 30);
            this.txtCategoryName.TabIndex = 2;
            this.txtCategoryName.UseSelectable = true;
            this.txtCategoryName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCategoryName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(121)))), ((int)(((byte)(183)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(194, 166);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(121)))), ((int)(((byte)(183)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(377, 166);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 240);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Category";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une nouvelle catégorie";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtCategoryName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}