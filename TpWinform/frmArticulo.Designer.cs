namespace TpWinform
{
    partial class frmArticulo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdministrar = new System.Windows.Forms.Label();
            this.lblMenuMarcas = new System.Windows.Forms.Label();
            this.lblMenuArticulos = new System.Windows.Forms.Label();
            this.lblMenuCategorias = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDetalleArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblFiltarPor = new System.Windows.Forms.Label();
            this.cboFiltroPrincipal = new System.Windows.Forms.ComboBox();
            this.cboListaFiltrada = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnBuscarFiltro = new System.Windows.Forms.Button();
            this.lblErrorFiltro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(110, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Sección Artículos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblAdministrar);
            this.panel1.Controls.Add(this.lblMenuMarcas);
            this.panel1.Controls.Add(this.lblMenuArticulos);
            this.panel1.Controls.Add(this.lblMenuCategorias);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 628);
            this.panel1.TabIndex = 1;
            // 
            // lblAdministrar
            // 
            this.lblAdministrar.AutoSize = true;
            this.lblAdministrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrar.Location = new System.Drawing.Point(3, 220);
            this.lblAdministrar.Name = "lblAdministrar";
            this.lblAdministrar.Size = new System.Drawing.Size(85, 16);
            this.lblAdministrar.TabIndex = 2;
            this.lblAdministrar.Text = "Administrar";
            // 
            // lblMenuMarcas
            // 
            this.lblMenuMarcas.AutoSize = true;
            this.lblMenuMarcas.BackColor = System.Drawing.Color.Salmon;
            this.lblMenuMarcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenuMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMenuMarcas.Location = new System.Drawing.Point(12, 278);
            this.lblMenuMarcas.Name = "lblMenuMarcas";
            this.lblMenuMarcas.Size = new System.Drawing.Size(56, 17);
            this.lblMenuMarcas.TabIndex = 1;
            this.lblMenuMarcas.Text = "Marcas";
            this.lblMenuMarcas.Click += new System.EventHandler(this.lblMenuMarcas_Click_1);
            // 
            // lblMenuArticulos
            // 
            this.lblMenuArticulos.AutoSize = true;
            this.lblMenuArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuArticulos.Location = new System.Drawing.Point(12, 100);
            this.lblMenuArticulos.Name = "lblMenuArticulos";
            this.lblMenuArticulos.Size = new System.Drawing.Size(67, 16);
            this.lblMenuArticulos.TabIndex = 0;
            this.lblMenuArticulos.Text = "Artículos";
            this.lblMenuArticulos.Visible = false;
            // 
            // lblMenuCategorias
            // 
            this.lblMenuCategorias.AutoSize = true;
            this.lblMenuCategorias.BackColor = System.Drawing.Color.Gold;
            this.lblMenuCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenuCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMenuCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuCategorias.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMenuCategorias.Location = new System.Drawing.Point(6, 248);
            this.lblMenuCategorias.Margin = new System.Windows.Forms.Padding(3);
            this.lblMenuCategorias.Name = "lblMenuCategorias";
            this.lblMenuCategorias.Size = new System.Drawing.Size(78, 17);
            this.lblMenuCategorias.TabIndex = 1;
            this.lblMenuCategorias.Text = "Categorías";
            this.lblMenuCategorias.Click += new System.EventHandler(this.lblMenuCategorias_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnDetalleArticulo);
            this.panel2.Controls.Add(this.btnEliminarArticulo);
            this.panel2.Controls.Add(this.btnModificarArticulo);
            this.panel2.Controls.Add(this.btnAgregarArticulo);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.lblBuscar);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 82);
            this.panel2.TabIndex = 0;
            // 
            // btnDetalleArticulo
            // 
            this.btnDetalleArticulo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDetalleArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold);
            this.btnDetalleArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDetalleArticulo.Location = new System.Drawing.Point(588, 39);
            this.btnDetalleArticulo.Name = "btnDetalleArticulo";
            this.btnDetalleArticulo.Size = new System.Drawing.Size(90, 35);
            this.btnDetalleArticulo.TabIndex = 2;
            this.btnDetalleArticulo.Text = "Detalle Artículo";
            this.btnDetalleArticulo.UseVisualStyleBackColor = false;
            this.btnDetalleArticulo.Click += new System.EventHandler(this.btnDetalleArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.Red;
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(780, 39);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(86, 35);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "Eliminar Artículo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.BackColor = System.Drawing.Color.Goldenrod;
            this.btnModificarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold);
            this.btnModificarArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarArticulo.Location = new System.Drawing.Point(684, 39);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(90, 35);
            this.btnModificarArticulo.TabIndex = 3;
            this.btnModificarArticulo.Text = "Modificar Artículo";
            this.btnModificarArticulo.UseVisualStyleBackColor = false;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(489, 39);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(93, 35);
            this.btnAgregarArticulo.TabIndex = 1;
            this.btnAgregarArticulo.Text = "Agregar Artículo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(162, 54);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(168, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(113, 57);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Buscar:";
            // 
            // lblFiltarPor
            // 
            this.lblFiltarPor.AutoSize = true;
            this.lblFiltarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltarPor.Location = new System.Drawing.Point(247, 598);
            this.lblFiltarPor.Name = "lblFiltarPor";
            this.lblFiltarPor.Size = new System.Drawing.Size(53, 13);
            this.lblFiltarPor.TabIndex = 6;
            this.lblFiltarPor.Text = "Filtrar por:";
            // 
            // cboFiltroPrincipal
            // 
            this.cboFiltroPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroPrincipal.FormattingEnabled = true;
            this.cboFiltroPrincipal.Location = new System.Drawing.Point(319, 594);
            this.cboFiltroPrincipal.Name = "cboFiltroPrincipal";
            this.cboFiltroPrincipal.Size = new System.Drawing.Size(121, 21);
            this.cboFiltroPrincipal.TabIndex = 2;
            this.cboFiltroPrincipal.SelectedIndexChanged += new System.EventHandler(this.cboFiltroPrincipal_SelectedIndexChanged);
            // 
            // cboListaFiltrada
            // 
            this.cboListaFiltrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboListaFiltrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboListaFiltrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListaFiltrada.FormattingEnabled = true;
            this.cboListaFiltrada.Location = new System.Drawing.Point(459, 594);
            this.cboListaFiltrada.Name = "cboListaFiltrada";
            this.cboListaFiltrada.Size = new System.Drawing.Size(125, 21);
            this.cboListaFiltrada.TabIndex = 3;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(697, 593);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(98, 23);
            this.btnLimpiarFiltro.TabIndex = 4;
            this.btnLimpiarFiltro.Text = "Limpiar Filtros";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(101, 80);
            this.dgvArticulos.MaximumSize = new System.Drawing.Size(777, 495);
            this.dgvArticulos.MinimumSize = new System.Drawing.Size(777, 495);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(777, 495);
            this.dgvArticulos.TabIndex = 3;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnBuscarFiltro
            // 
            this.btnBuscarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscarFiltro.Location = new System.Drawing.Point(603, 593);
            this.btnBuscarFiltro.Name = "btnBuscarFiltro";
            this.btnBuscarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFiltro.TabIndex = 7;
            this.btnBuscarFiltro.Text = "Filtrar";
            this.btnBuscarFiltro.UseVisualStyleBackColor = false;
            this.btnBuscarFiltro.Click += new System.EventHandler(this.btnBuscarFiltro_Click);
            // 
            // lblErrorFiltro
            // 
            this.lblErrorFiltro.AutoSize = true;
            this.lblErrorFiltro.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFiltro.Location = new System.Drawing.Point(541, 578);
            this.lblErrorFiltro.Name = "lblErrorFiltro";
            this.lblErrorFiltro.Size = new System.Drawing.Size(184, 13);
            this.lblErrorFiltro.TabIndex = 8;
            this.lblErrorFiltro.Text = "Aviso : Debes seleccionar como filtrar";
            this.lblErrorFiltro.Visible = false;
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(878, 627);
            this.Controls.Add(this.lblErrorFiltro);
            this.Controls.Add(this.btnBuscarFiltro);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.cboListaFiltrada);
            this.Controls.Add(this.cboFiltroPrincipal);
            this.Controls.Add(this.lblFiltarPor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(894, 666);
            this.MinimumSize = new System.Drawing.Size(894, 666);
            this.Name = "frmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Artículos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMenuArticulos;
        private System.Windows.Forms.Label lblMenuCategorias;
        private System.Windows.Forms.Label lblMenuMarcas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblFiltarPor;
        private System.Windows.Forms.ComboBox cboFiltroPrincipal;
        private System.Windows.Forms.ComboBox cboListaFiltrada;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnDetalleArticulo;
        private System.Windows.Forms.Button btnBuscarFiltro;
        private System.Windows.Forms.Label lblErrorFiltro;
        private System.Windows.Forms.Label lblAdministrar;
    }
}

