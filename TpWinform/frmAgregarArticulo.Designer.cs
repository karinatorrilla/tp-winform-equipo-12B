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
            this.lblFrmNombreArticulo = new System.Windows.Forms.Label();
            this.txtFrmCodigoArticulo = new System.Windows.Forms.TextBox();
            this.lblFrmCodigoArticulo = new System.Windows.Forms.Label();
            this.lblFrmMarcaArticulo = new System.Windows.Forms.Label();
            this.lblFrmCategoriaArticulo = new System.Windows.Forms.Label();
            this.lblFrmImagenArticulo = new System.Windows.Forms.Label();
            this.lblFrmDescripcionArticulo = new System.Windows.Forms.Label();
            this.lblFrmPrecioArticulo = new System.Windows.Forms.Label();
            this.txtFrmNombreArticulo = new System.Windows.Forms.TextBox();
            this.cboFrmMarcaArticulo = new System.Windows.Forms.ComboBox();
            this.cboFrmCategoriaArticulo = new System.Windows.Forms.ComboBox();
            this.txtFrmPrecioArticulo = new System.Windows.Forms.TextBox();
            this.txtFrmDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnFrmGuardarArticulo = new System.Windows.Forms.Button();
            this.btnFrmCancelarArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCrearArticulo
            // 
            this.lblCrearArticulo.AutoSize = true;
            this.lblCrearArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearArticulo.Location = new System.Drawing.Point(12, 9);
            this.lblCrearArticulo.Name = "lblCrearArticulo";
            this.lblCrearArticulo.Size = new System.Drawing.Size(138, 24);
            this.lblCrearArticulo.TabIndex = 0;
            this.lblCrearArticulo.Text = "Crear Artículo";
            // 
            // lblFrmNombreArticulo
            // 
            this.lblFrmNombreArticulo.AutoSize = true;
            this.lblFrmNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmNombreArticulo.Location = new System.Drawing.Point(145, 104);
            this.lblFrmNombreArticulo.Name = "lblFrmNombreArticulo";
            this.lblFrmNombreArticulo.Size = new System.Drawing.Size(54, 13);
            this.lblFrmNombreArticulo.TabIndex = 1;
            this.lblFrmNombreArticulo.Text = "Nombre:";
            // 
            // txtFrmCodigoArticulo
            // 
            this.txtFrmCodigoArticulo.Location = new System.Drawing.Point(205, 63);
            this.txtFrmCodigoArticulo.Name = "txtFrmCodigoArticulo";
            this.txtFrmCodigoArticulo.Size = new System.Drawing.Size(156, 20);
            this.txtFrmCodigoArticulo.TabIndex = 2;
            // 
            // lblFrmCodigoArticulo
            // 
            this.lblFrmCodigoArticulo.AutoSize = true;
            this.lblFrmCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmCodigoArticulo.Location = new System.Drawing.Point(149, 66);
            this.lblFrmCodigoArticulo.Name = "lblFrmCodigoArticulo";
            this.lblFrmCodigoArticulo.Size = new System.Drawing.Size(50, 13);
            this.lblFrmCodigoArticulo.TabIndex = 3;
            this.lblFrmCodigoArticulo.Text = "Código:";
            // 
            // lblFrmMarcaArticulo
            // 
            this.lblFrmMarcaArticulo.AutoSize = true;
            this.lblFrmMarcaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmMarcaArticulo.Location = new System.Drawing.Point(153, 144);
            this.lblFrmMarcaArticulo.Name = "lblFrmMarcaArticulo";
            this.lblFrmMarcaArticulo.Size = new System.Drawing.Size(46, 13);
            this.lblFrmMarcaArticulo.TabIndex = 4;
            this.lblFrmMarcaArticulo.Text = "Marca:";
            // 
            // lblFrmCategoriaArticulo
            // 
            this.lblFrmCategoriaArticulo.AutoSize = true;
            this.lblFrmCategoriaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmCategoriaArticulo.Location = new System.Drawing.Point(132, 188);
            this.lblFrmCategoriaArticulo.Name = "lblFrmCategoriaArticulo";
            this.lblFrmCategoriaArticulo.Size = new System.Drawing.Size(67, 13);
            this.lblFrmCategoriaArticulo.TabIndex = 5;
            this.lblFrmCategoriaArticulo.Text = "Categoría:";
            this.lblFrmCategoriaArticulo.Click += new System.EventHandler(this.lblFrmCategoriaArticulo_Click);
            // 
            // lblFrmImagenArticulo
            // 
            this.lblFrmImagenArticulo.AutoSize = true;
            this.lblFrmImagenArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmImagenArticulo.Location = new System.Drawing.Point(114, 396);
            this.lblFrmImagenArticulo.Name = "lblFrmImagenArticulo";
            this.lblFrmImagenArticulo.Size = new System.Drawing.Size(85, 13);
            this.lblFrmImagenArticulo.TabIndex = 6;
            this.lblFrmImagenArticulo.Text = "Url Imagenes:";
            this.lblFrmImagenArticulo.Click += new System.EventHandler(this.lblFrmImagenArticulo_Click);
            // 
            // lblFrmDescripcionArticulo
            // 
            this.lblFrmDescripcionArticulo.AutoSize = true;
            this.lblFrmDescripcionArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmDescripcionArticulo.Location = new System.Drawing.Point(121, 273);
            this.lblFrmDescripcionArticulo.Name = "lblFrmDescripcionArticulo";
            this.lblFrmDescripcionArticulo.Size = new System.Drawing.Size(78, 13);
            this.lblFrmDescripcionArticulo.TabIndex = 7;
            this.lblFrmDescripcionArticulo.Text = "Descripción:";
            // 
            // lblFrmPrecioArticulo
            // 
            this.lblFrmPrecioArticulo.AutoSize = true;
            this.lblFrmPrecioArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmPrecioArticulo.Location = new System.Drawing.Point(152, 227);
            this.lblFrmPrecioArticulo.Name = "lblFrmPrecioArticulo";
            this.lblFrmPrecioArticulo.Size = new System.Drawing.Size(47, 13);
            this.lblFrmPrecioArticulo.TabIndex = 8;
            this.lblFrmPrecioArticulo.Text = "Precio:";
            this.lblFrmPrecioArticulo.Click += new System.EventHandler(this.lblFrmPrecioArticulo_Click);
            // 
            // txtFrmNombreArticulo
            // 
            this.txtFrmNombreArticulo.Location = new System.Drawing.Point(205, 97);
            this.txtFrmNombreArticulo.Name = "txtFrmNombreArticulo";
            this.txtFrmNombreArticulo.Size = new System.Drawing.Size(156, 20);
            this.txtFrmNombreArticulo.TabIndex = 9;
            // 
            // cboFrmMarcaArticulo
            // 
            this.cboFrmMarcaArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrmMarcaArticulo.FormattingEnabled = true;
            this.cboFrmMarcaArticulo.Location = new System.Drawing.Point(205, 141);
            this.cboFrmMarcaArticulo.Name = "cboFrmMarcaArticulo";
            this.cboFrmMarcaArticulo.Size = new System.Drawing.Size(156, 21);
            this.cboFrmMarcaArticulo.TabIndex = 10;
            this.cboFrmMarcaArticulo.SelectedIndexChanged += new System.EventHandler(this.cboFrmMarcaArticulo_SelectedIndexChanged);
            // 
            // cboFrmCategoriaArticulo
            // 
            this.cboFrmCategoriaArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrmCategoriaArticulo.FormattingEnabled = true;
            this.cboFrmCategoriaArticulo.Location = new System.Drawing.Point(205, 185);
            this.cboFrmCategoriaArticulo.Name = "cboFrmCategoriaArticulo";
            this.cboFrmCategoriaArticulo.Size = new System.Drawing.Size(156, 21);
            this.cboFrmCategoriaArticulo.TabIndex = 11;
            this.cboFrmCategoriaArticulo.SelectedIndexChanged += new System.EventHandler(this.cboFrmCategoriaArticulo_SelectedIndexChanged);
            // 
            // txtFrmPrecioArticulo
            // 
            this.txtFrmPrecioArticulo.Location = new System.Drawing.Point(205, 224);
            this.txtFrmPrecioArticulo.Name = "txtFrmPrecioArticulo";
            this.txtFrmPrecioArticulo.Size = new System.Drawing.Size(156, 20);
            this.txtFrmPrecioArticulo.TabIndex = 12;
            this.txtFrmPrecioArticulo.TextChanged += new System.EventHandler(this.txtFrmPrecioArticulo_TextChanged);
            // 
            // txtFrmDescripcionArticulo
            // 
            this.txtFrmDescripcionArticulo.Location = new System.Drawing.Point(124, 303);
            this.txtFrmDescripcionArticulo.MaximumSize = new System.Drawing.Size(246, 72);
            this.txtFrmDescripcionArticulo.MinimumSize = new System.Drawing.Size(224, 72);
            this.txtFrmDescripcionArticulo.Multiline = true;
            this.txtFrmDescripcionArticulo.Name = "txtFrmDescripcionArticulo";
            this.txtFrmDescripcionArticulo.Size = new System.Drawing.Size(237, 72);
            this.txtFrmDescripcionArticulo.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 393);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 14;
            // 
            // btnFrmGuardarArticulo
            // 
            this.btnFrmGuardarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFrmGuardarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmGuardarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmGuardarArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFrmGuardarArticulo.Location = new System.Drawing.Point(94, 474);
            this.btnFrmGuardarArticulo.Name = "btnFrmGuardarArticulo";
            this.btnFrmGuardarArticulo.Size = new System.Drawing.Size(133, 32);
            this.btnFrmGuardarArticulo.TabIndex = 15;
            this.btnFrmGuardarArticulo.Text = "Agregar";
            this.btnFrmGuardarArticulo.UseVisualStyleBackColor = false;
            this.btnFrmGuardarArticulo.Click += new System.EventHandler(this.btnFrmGuardarArticulo_Click);
            // 
            // btnFrmCancelarArticulo
            // 
            this.btnFrmCancelarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFrmCancelarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmCancelarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmCancelarArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFrmCancelarArticulo.Location = new System.Drawing.Point(269, 474);
            this.btnFrmCancelarArticulo.Name = "btnFrmCancelarArticulo";
            this.btnFrmCancelarArticulo.Size = new System.Drawing.Size(133, 32);
            this.btnFrmCancelarArticulo.TabIndex = 16;
            this.btnFrmCancelarArticulo.Text = "Cancelar";
            this.btnFrmCancelarArticulo.UseVisualStyleBackColor = false;
            this.btnFrmCancelarArticulo.Click += new System.EventHandler(this.btnFrmCancelarArticulo_Click);
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 533);
            this.Controls.Add(this.btnFrmCancelarArticulo);
            this.Controls.Add(this.btnFrmGuardarArticulo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtFrmDescripcionArticulo);
            this.Controls.Add(this.txtFrmPrecioArticulo);
            this.Controls.Add(this.cboFrmCategoriaArticulo);
            this.Controls.Add(this.cboFrmMarcaArticulo);
            this.Controls.Add(this.txtFrmNombreArticulo);
            this.Controls.Add(this.lblFrmPrecioArticulo);
            this.Controls.Add(this.lblFrmDescripcionArticulo);
            this.Controls.Add(this.lblFrmImagenArticulo);
            this.Controls.Add(this.lblFrmCategoriaArticulo);
            this.Controls.Add(this.lblFrmMarcaArticulo);
            this.Controls.Add(this.lblFrmCodigoArticulo);
            this.Controls.Add(this.txtFrmCodigoArticulo);
            this.Controls.Add(this.lblFrmNombreArticulo);
            this.Controls.Add(this.lblCrearArticulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 523);
            this.Name = "frmAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrearArticulo;
        private System.Windows.Forms.Label lblFrmNombreArticulo;
        private System.Windows.Forms.TextBox txtFrmCodigoArticulo;
        private System.Windows.Forms.Label lblFrmCodigoArticulo;
        private System.Windows.Forms.Label lblFrmMarcaArticulo;
        private System.Windows.Forms.Label lblFrmCategoriaArticulo;
        private System.Windows.Forms.Label lblFrmImagenArticulo;
        private System.Windows.Forms.Label lblFrmDescripcionArticulo;
        private System.Windows.Forms.Label lblFrmPrecioArticulo;
        private System.Windows.Forms.TextBox txtFrmNombreArticulo;
        private System.Windows.Forms.ComboBox cboFrmMarcaArticulo;
        private System.Windows.Forms.ComboBox cboFrmCategoriaArticulo;
        private System.Windows.Forms.TextBox txtFrmPrecioArticulo;
        private System.Windows.Forms.TextBox txtFrmDescripcionArticulo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnFrmGuardarArticulo;
        private System.Windows.Forms.Button btnFrmCancelarArticulo;
    }
}