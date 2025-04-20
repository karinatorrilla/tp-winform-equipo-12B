namespace TpWinform
{
    partial class frmAdministrar
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
            this.btnAgregarAdministrar = new System.Windows.Forms.Button();
            this.btnModificarAdministrar = new System.Windows.Forms.Button();
            this.btnEliminarAdministrar = new System.Windows.Forms.Button();
            this.dgvAdministrar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarAdministrar
            // 
            this.btnAgregarAdministrar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregarAdministrar.Location = new System.Drawing.Point(210, 107);
            this.btnAgregarAdministrar.Name = "btnAgregarAdministrar";
            this.btnAgregarAdministrar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAdministrar.TabIndex = 0;
            this.btnAgregarAdministrar.Text = "Agregar";
            this.btnAgregarAdministrar.UseVisualStyleBackColor = false;
            this.btnAgregarAdministrar.Click += new System.EventHandler(this.btnAgregarAdministrar_Click);
            // 
            // btnModificarAdministrar
            // 
            this.btnModificarAdministrar.BackColor = System.Drawing.Color.Yellow;
            this.btnModificarAdministrar.Location = new System.Drawing.Point(210, 174);
            this.btnModificarAdministrar.Name = "btnModificarAdministrar";
            this.btnModificarAdministrar.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAdministrar.TabIndex = 1;
            this.btnModificarAdministrar.Text = "Modificar";
            this.btnModificarAdministrar.UseVisualStyleBackColor = false;
            this.btnModificarAdministrar.Click += new System.EventHandler(this.btnModificarAdministrar_Click);
            // 
            // btnEliminarAdministrar
            // 
            this.btnEliminarAdministrar.BackColor = System.Drawing.Color.Red;
            this.btnEliminarAdministrar.Location = new System.Drawing.Point(210, 242);
            this.btnEliminarAdministrar.Name = "btnEliminarAdministrar";
            this.btnEliminarAdministrar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAdministrar.TabIndex = 2;
            this.btnEliminarAdministrar.Text = "Eliminar";
            this.btnEliminarAdministrar.UseVisualStyleBackColor = false;
            this.btnEliminarAdministrar.Click += new System.EventHandler(this.btnEliminarAdministrar_Click);
            // 
            // dgvAdministrar
            // 
            this.dgvAdministrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdministrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdministrar.Location = new System.Drawing.Point(12, 12);
            this.dgvAdministrar.Name = "dgvAdministrar";
            this.dgvAdministrar.Size = new System.Drawing.Size(166, 374);
            this.dgvAdministrar.TabIndex = 3;
            // 
            // frmAdministrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 394);
            this.Controls.Add(this.dgvAdministrar);
            this.Controls.Add(this.btnEliminarAdministrar);
            this.Controls.Add(this.btnModificarAdministrar);
            this.Controls.Add(this.btnAgregarAdministrar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 433);
            this.MinimumSize = new System.Drawing.Size(316, 433);
            this.Name = "frmAdministrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministrar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdministrar_FormClosed);
            this.Load += new System.EventHandler(this.frmAdministrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarAdministrar;
        private System.Windows.Forms.Button btnModificarAdministrar;
        private System.Windows.Forms.Button btnEliminarAdministrar;
        private System.Windows.Forms.DataGridView dgvAdministrar;
    }
}