namespace InventoryManagment.PL
{
    partial class Form_DisplayImage
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
            this.PICIMAGE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PICIMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // PICIMAGE
            // 
            this.PICIMAGE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PICIMAGE.Location = new System.Drawing.Point(20, 60);
            this.PICIMAGE.Name = "PICIMAGE";
            this.PICIMAGE.Size = new System.Drawing.Size(410, 339);
            this.PICIMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICIMAGE.TabIndex = 0;
            this.PICIMAGE.TabStop = false;
            // 
            // Form_DisplayImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 419);
            this.Controls.Add(this.PICIMAGE);
            this.Name = "Form_DisplayImage";
            ((System.ComponentModel.ISupportInitialize)(this.PICIMAGE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PICIMAGE;
    }
}