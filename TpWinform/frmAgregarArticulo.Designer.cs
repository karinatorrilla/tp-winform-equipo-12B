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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarArticulo));
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
            this.txtFrmUrlImagen = new System.Windows.Forms.TextBox();
            this.btnFrmGuardarArticulo = new System.Windows.Forms.Button();
            this.btnFrmCancelarArticulo = new System.Windows.Forms.Button();
            this.lblErrorCodigo = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorDescripcion = new System.Windows.Forms.Label();
            this.lblErrorPrecio = new System.Windows.Forms.Label();
            this.lblErrorCampoUrlImage = new System.Windows.Forms.Label();
            this.lblErrorCategoria = new System.Windows.Forms.Label();
            this.lblErrorMarca = new System.Windows.Forms.Label();
            this.chkboxMasImagenes = new System.Windows.Forms.CheckBox();
            this.lblMasImagenes = new System.Windows.Forms.Label();
            this.lblExplicativo2 = new System.Windows.Forms.Label();
            this.lblExplicativo1 = new System.Windows.Forms.Label();
            this.lblEjemploFormato = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.flpContenedorImagenes = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.flpContenedorImagenes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCrearArticulo
            // 
            this.lblCrearArticulo.AutoSize = true;
            this.lblCrearArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearArticulo.Location = new System.Drawing.Point(344, 9);
            this.lblCrearArticulo.Name = "lblCrearArticulo";
            this.lblCrearArticulo.Size = new System.Drawing.Size(138, 24);
            this.lblCrearArticulo.TabIndex = 0;
            this.lblCrearArticulo.Text = "Crear Artículo";
            // 
            // lblFrmNombreArticulo
            // 
            this.lblFrmNombreArticulo.AutoSize = true;
            this.lblFrmNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmNombreArticulo.Location = new System.Drawing.Point(24, 84);
            this.lblFrmNombreArticulo.Name = "lblFrmNombreArticulo";
            this.lblFrmNombreArticulo.Size = new System.Drawing.Size(69, 17);
            this.lblFrmNombreArticulo.TabIndex = 1;
            this.lblFrmNombreArticulo.Text = "Nombre:";
            // 
            // txtFrmCodigoArticulo
            // 
            this.txtFrmCodigoArticulo.Location = new System.Drawing.Point(112, 42);
            this.txtFrmCodigoArticulo.Name = "txtFrmCodigoArticulo";
            this.txtFrmCodigoArticulo.Size = new System.Drawing.Size(156, 20);
            this.txtFrmCodigoArticulo.TabIndex = 0;
            // 
            // lblFrmCodigoArticulo
            // 
            this.lblFrmCodigoArticulo.AutoSize = true;
            this.lblFrmCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmCodigoArticulo.Location = new System.Drawing.Point(27, 44);
            this.lblFrmCodigoArticulo.Name = "lblFrmCodigoArticulo";
            this.lblFrmCodigoArticulo.Size = new System.Drawing.Size(63, 17);
            this.lblFrmCodigoArticulo.TabIndex = 3;
            this.lblFrmCodigoArticulo.Text = "Código:";
            // 
            // lblFrmMarcaArticulo
            // 
            this.lblFrmMarcaArticulo.AutoSize = true;
            this.lblFrmMarcaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmMarcaArticulo.Location = new System.Drawing.Point(30, 122);
            this.lblFrmMarcaArticulo.Name = "lblFrmMarcaArticulo";
            this.lblFrmMarcaArticulo.Size = new System.Drawing.Size(57, 17);
            this.lblFrmMarcaArticulo.TabIndex = 4;
            this.lblFrmMarcaArticulo.Text = "Marca:";
            // 
            // lblFrmCategoriaArticulo
            // 
            this.lblFrmCategoriaArticulo.AutoSize = true;
            this.lblFrmCategoriaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmCategoriaArticulo.Location = new System.Drawing.Point(17, 158);
            this.lblFrmCategoriaArticulo.Name = "lblFrmCategoriaArticulo";
            this.lblFrmCategoriaArticulo.Size = new System.Drawing.Size(83, 17);
            this.lblFrmCategoriaArticulo.TabIndex = 5;
            this.lblFrmCategoriaArticulo.Text = "Categoría:";
            // 
            // lblFrmImagenArticulo
            // 
            this.lblFrmImagenArticulo.AutoSize = true;
            this.lblFrmImagenArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmImagenArticulo.Location = new System.Drawing.Point(404, 115);
            this.lblFrmImagenArticulo.Name = "lblFrmImagenArticulo";
            this.lblFrmImagenArticulo.Size = new System.Drawing.Size(85, 13);
            this.lblFrmImagenArticulo.TabIndex = 6;
            this.lblFrmImagenArticulo.Text = "Url Imagenes:";
            // 
            // lblFrmDescripcionArticulo
            // 
            this.lblFrmDescripcionArticulo.AutoSize = true;
            this.lblFrmDescripcionArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmDescripcionArticulo.Location = new System.Drawing.Point(123, 249);
            this.lblFrmDescripcionArticulo.Name = "lblFrmDescripcionArticulo";
            this.lblFrmDescripcionArticulo.Size = new System.Drawing.Size(98, 17);
            this.lblFrmDescripcionArticulo.TabIndex = 7;
            this.lblFrmDescripcionArticulo.Text = "Descripción:";
            // 
            // lblFrmPrecioArticulo
            // 
            this.lblFrmPrecioArticulo.AutoSize = true;
            this.lblFrmPrecioArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmPrecioArticulo.Location = new System.Drawing.Point(29, 199);
            this.lblFrmPrecioArticulo.Name = "lblFrmPrecioArticulo";
            this.lblFrmPrecioArticulo.Size = new System.Drawing.Size(59, 17);
            this.lblFrmPrecioArticulo.TabIndex = 8;
            this.lblFrmPrecioArticulo.Text = "Precio:";
            // 
            // txtFrmNombreArticulo
            // 
            this.txtFrmNombreArticulo.Location = new System.Drawing.Point(112, 82);
            this.txtFrmNombreArticulo.Name = "txtFrmNombreArticulo";
            this.txtFrmNombreArticulo.Size = new System.Drawing.Size(156, 20);
            this.txtFrmNombreArticulo.TabIndex = 1;
            // 
            // cboFrmMarcaArticulo
            // 
            this.cboFrmMarcaArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrmMarcaArticulo.FormattingEnabled = true;
            this.cboFrmMarcaArticulo.Location = new System.Drawing.Point(112, 120);
            this.cboFrmMarcaArticulo.Name = "cboFrmMarcaArticulo";
            this.cboFrmMarcaArticulo.Size = new System.Drawing.Size(156, 21);
            this.cboFrmMarcaArticulo.TabIndex = 2;
            // 
            // cboFrmCategoriaArticulo
            // 
            this.cboFrmCategoriaArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrmCategoriaArticulo.FormattingEnabled = true;
            this.cboFrmCategoriaArticulo.Location = new System.Drawing.Point(112, 156);
            this.cboFrmCategoriaArticulo.Name = "cboFrmCategoriaArticulo";
            this.cboFrmCategoriaArticulo.Size = new System.Drawing.Size(156, 21);
            this.cboFrmCategoriaArticulo.TabIndex = 3;
            // 
            // txtFrmPrecioArticulo
            // 
            this.txtFrmPrecioArticulo.Location = new System.Drawing.Point(112, 197);
            this.txtFrmPrecioArticulo.Name = "txtFrmPrecioArticulo";
            this.txtFrmPrecioArticulo.Size = new System.Drawing.Size(156, 20);
            this.txtFrmPrecioArticulo.TabIndex = 4;
            this.txtFrmPrecioArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrmPrecioArticulo_KeyPress);
            // 
            // txtFrmDescripcionArticulo
            // 
            this.txtFrmDescripcionArticulo.Location = new System.Drawing.Point(29, 290);
            this.txtFrmDescripcionArticulo.MinimumSize = new System.Drawing.Size(224, 72);
            this.txtFrmDescripcionArticulo.Multiline = true;
            this.txtFrmDescripcionArticulo.Name = "txtFrmDescripcionArticulo";
            this.txtFrmDescripcionArticulo.Size = new System.Drawing.Size(291, 161);
            this.txtFrmDescripcionArticulo.TabIndex = 5;
            // 
            // txtFrmUrlImagen
            // 
            this.txtFrmUrlImagen.BackColor = System.Drawing.SystemColors.Window;
            this.txtFrmUrlImagen.Location = new System.Drawing.Point(500, 110);
            this.txtFrmUrlImagen.Multiline = true;
            this.txtFrmUrlImagen.Name = "txtFrmUrlImagen";
            this.txtFrmUrlImagen.Size = new System.Drawing.Size(345, 22);
            this.txtFrmUrlImagen.TabIndex = 6;
            // 
            // btnFrmGuardarArticulo
            // 
            this.btnFrmGuardarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFrmGuardarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmGuardarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmGuardarArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFrmGuardarArticulo.Location = new System.Drawing.Point(468, 425);
            this.btnFrmGuardarArticulo.Name = "btnFrmGuardarArticulo";
            this.btnFrmGuardarArticulo.Size = new System.Drawing.Size(133, 32);
            this.btnFrmGuardarArticulo.TabIndex = 7;
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
            this.btnFrmCancelarArticulo.Location = new System.Drawing.Point(657, 425);
            this.btnFrmCancelarArticulo.Name = "btnFrmCancelarArticulo";
            this.btnFrmCancelarArticulo.Size = new System.Drawing.Size(133, 32);
            this.btnFrmCancelarArticulo.TabIndex = 8;
            this.btnFrmCancelarArticulo.Text = "Cancelar";
            this.btnFrmCancelarArticulo.UseVisualStyleBackColor = false;
            this.btnFrmCancelarArticulo.Click += new System.EventHandler(this.btnFrmCancelarArticulo_Click);
            // 
            // lblErrorCodigo
            // 
            this.lblErrorCodigo.AutoSize = true;
            this.lblErrorCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigo.Location = new System.Drawing.Point(274, 43);
            this.lblErrorCodigo.Name = "lblErrorCodigo";
            this.lblErrorCodigo.Size = new System.Drawing.Size(14, 18);
            this.lblErrorCodigo.TabIndex = 12;
            this.lblErrorCodigo.Text = "*";
            this.lblErrorCodigo.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(276, 83);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(14, 18);
            this.lblErrorNombre.TabIndex = 13;
            this.lblErrorNombre.Text = "*";
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorDescripcion
            // 
            this.lblErrorDescripcion.AutoSize = true;
            this.lblErrorDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDescripcion.Location = new System.Drawing.Point(59, 272);
            this.lblErrorDescripcion.Name = "lblErrorDescripcion";
            this.lblErrorDescripcion.Size = new System.Drawing.Size(229, 15);
            this.lblErrorDescripcion.TabIndex = 14;
            this.lblErrorDescripcion.Text = "¡Este campo solo admite 150 caracteres!";
            this.lblErrorDescripcion.Visible = false;
            // 
            // lblErrorPrecio
            // 
            this.lblErrorPrecio.AutoSize = true;
            this.lblErrorPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrecio.Location = new System.Drawing.Point(276, 198);
            this.lblErrorPrecio.Name = "lblErrorPrecio";
            this.lblErrorPrecio.Size = new System.Drawing.Size(14, 18);
            this.lblErrorPrecio.TabIndex = 15;
            this.lblErrorPrecio.Text = "*";
            this.lblErrorPrecio.Visible = false;
            // 
            // lblErrorCampoUrlImage
            // 
            this.lblErrorCampoUrlImage.AutoSize = true;
            this.lblErrorCampoUrlImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCampoUrlImage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorCampoUrlImage.Location = new System.Drawing.Point(418, 162);
            this.lblErrorCampoUrlImage.Name = "lblErrorCampoUrlImage";
            this.lblErrorCampoUrlImage.Size = new System.Drawing.Size(169, 12);
            this.lblErrorCampoUrlImage.TabIndex = 12;
            this.lblErrorCampoUrlImage.Text = "Tiene que ingresar URLS válidas";
            this.lblErrorCampoUrlImage.Visible = false;
            // 
            // lblErrorCategoria
            // 
            this.lblErrorCategoria.AutoSize = true;
            this.lblErrorCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCategoria.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCategoria.Location = new System.Drawing.Point(276, 157);
            this.lblErrorCategoria.Name = "lblErrorCategoria";
            this.lblErrorCategoria.Size = new System.Drawing.Size(14, 18);
            this.lblErrorCategoria.TabIndex = 17;
            this.lblErrorCategoria.Text = "*";
            this.lblErrorCategoria.Visible = false;
            // 
            // lblErrorMarca
            // 
            this.lblErrorMarca.AutoSize = true;
            this.lblErrorMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMarca.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMarca.Location = new System.Drawing.Point(276, 121);
            this.lblErrorMarca.Name = "lblErrorMarca";
            this.lblErrorMarca.Size = new System.Drawing.Size(14, 18);
            this.lblErrorMarca.TabIndex = 18;
            this.lblErrorMarca.Text = "*";
            this.lblErrorMarca.Visible = false;
            // 
            // chkboxMasImagenes
            // 
            this.chkboxMasImagenes.AutoSize = true;
            this.chkboxMasImagenes.Location = new System.Drawing.Point(485, 139);
            this.chkboxMasImagenes.Name = "chkboxMasImagenes";
            this.chkboxMasImagenes.Size = new System.Drawing.Size(15, 14);
            this.chkboxMasImagenes.TabIndex = 19;
            this.chkboxMasImagenes.UseVisualStyleBackColor = true;
            this.chkboxMasImagenes.Visible = false;
            this.chkboxMasImagenes.CheckedChanged += new System.EventHandler(this.chkboxMasImagenes_CheckedChanged);
            // 
            // lblMasImagenes
            // 
            this.lblMasImagenes.AutoSize = true;
            this.lblMasImagenes.Location = new System.Drawing.Point(396, 136);
            this.lblMasImagenes.Name = "lblMasImagenes";
            this.lblMasImagenes.Size = new System.Drawing.Size(83, 26);
            this.lblMasImagenes.TabIndex = 20;
            this.lblMasImagenes.Text = "¿Agregar mas\r\nde una imagen?";
            this.lblMasImagenes.Visible = false;
            this.lblMasImagenes.Click += new System.EventHandler(this.lblMasImagenes_Click);
            // 
            // lblExplicativo2
            // 
            this.lblExplicativo2.AutoSize = true;
            this.lblExplicativo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicativo2.Location = new System.Drawing.Point(519, 68);
            this.lblExplicativo2.Name = "lblExplicativo2";
            this.lblExplicativo2.Size = new System.Drawing.Size(259, 13);
            this.lblExplicativo2.TabIndex = 10;
            this.lblExplicativo2.Text = "Ejemplo: UrlImagen1,UrlImagen2,UrlImagen3";
            // 
            // lblExplicativo1
            // 
            this.lblExplicativo1.AutoSize = true;
            this.lblExplicativo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicativo1.Location = new System.Drawing.Point(459, 51);
            this.lblExplicativo1.Name = "lblExplicativo1";
            this.lblExplicativo1.Size = new System.Drawing.Size(378, 13);
            this.lblExplicativo1.TabIndex = 11;
            this.lblExplicativo1.Text = "Para cargar mas de una imagen debe separar las url por coma \",\"";
            // 
            // lblEjemploFormato
            // 
            this.lblEjemploFormato.AutoSize = true;
            this.lblEjemploFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemploFormato.Location = new System.Drawing.Point(497, 85);
            this.lblEjemploFormato.Name = "lblEjemploFormato";
            this.lblEjemploFormato.Size = new System.Drawing.Size(303, 13);
            this.lblEjemploFormato.TabIndex = 16;
            this.lblEjemploFormato.Text = "Admite estos formatos: \".jpg\", \".jpeg\", \".png\", \".gif\"";
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(3, 3);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(58, 54);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 0;
            this.pbxImagen.TabStop = false;
            // 
            // flpContenedorImagenes
            // 
            this.flpContenedorImagenes.AutoScroll = true;
            this.flpContenedorImagenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpContenedorImagenes.Controls.Add(this.pbxImagen);
            this.flpContenedorImagenes.Location = new System.Drawing.Point(404, 187);
            this.flpContenedorImagenes.Name = "flpContenedorImagenes";
            this.flpContenedorImagenes.Size = new System.Drawing.Size(534, 180);
            this.flpContenedorImagenes.TabIndex = 13;
            this.flpContenedorImagenes.WrapContents = false;
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 491);
            this.Controls.Add(this.lblMasImagenes);
            this.Controls.Add(this.txtFrmUrlImagen);
            this.Controls.Add(this.chkboxMasImagenes);
            this.Controls.Add(this.lblErrorMarca);
            this.Controls.Add(this.lblErrorCategoria);
            this.Controls.Add(this.lblEjemploFormato);
            this.Controls.Add(this.lblErrorPrecio);
            this.Controls.Add(this.lblErrorDescripcion);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.lblErrorCodigo);
            this.Controls.Add(this.flpContenedorImagenes);
            this.Controls.Add(this.lblErrorCampoUrlImage);
            this.Controls.Add(this.lblExplicativo1);
            this.Controls.Add(this.lblExplicativo2);
            this.Controls.Add(this.btnFrmCancelarArticulo);
            this.Controls.Add(this.btnFrmGuardarArticulo);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(969, 530);
            this.Name = "frmAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.flpContenedorImagenes.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtFrmUrlImagen;
        private System.Windows.Forms.Button btnFrmGuardarArticulo;
        private System.Windows.Forms.Button btnFrmCancelarArticulo;
        private System.Windows.Forms.Label lblErrorCampoUrlImage;
        private System.Windows.Forms.Label lblErrorCodigo;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblErrorDescripcion;
        private System.Windows.Forms.Label lblErrorPrecio;
        private System.Windows.Forms.Label lblErrorCategoria;
        private System.Windows.Forms.Label lblErrorMarca;
        private System.Windows.Forms.CheckBox chkboxMasImagenes;
        private System.Windows.Forms.Label lblMasImagenes;
        private System.Windows.Forms.Label lblExplicativo2;
        private System.Windows.Forms.Label lblExplicativo1;
        private System.Windows.Forms.Label lblEjemploFormato;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.FlowLayoutPanel flpContenedorImagenes;
    }
}