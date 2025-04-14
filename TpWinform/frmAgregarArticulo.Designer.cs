namespace TpWinform
{
    partial class frmAgregarArticulo
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
            this.lblCrearArticulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCrearArticulo
            // 
            this.lblCrearArticulo.AutoSize = true;
            this.lblCrearArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearArticulo.Location = new System.Drawing.Point(12, 9);
            this.lblCrearArticulo.Name = "lblCrearArticulo";
            this.lblCrearArticulo.Size = new System.Drawing.Size(157, 25);
            this.lblCrearArticulo.TabIndex = 0;
            this.lblCrearArticulo.Text = "Crear Artículo";
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 484);
            this.Controls.Add(this.lblCrearArticulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 523);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 523);
            this.Name = "frmAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAgregarArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrearArticulo;
    }
}