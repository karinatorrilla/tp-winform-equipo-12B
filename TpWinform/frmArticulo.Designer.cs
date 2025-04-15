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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenuMarcas = new System.Windows.Forms.Label();
            this.lblMenuArticulos = new System.Windows.Forms.Label();
            this.lblMenuCategorias = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblFiltarPor = new System.Windows.Forms.Label();
            this.cboTipoCategoria = new System.Windows.Forms.ComboBox();
            this.cboSubTipoCategoria = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
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
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sección Artículos";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblMenuMarcas);
            this.panel1.Controls.Add(this.lblMenuArticulos);
            this.panel1.Controls.Add(this.lblMenuCategorias);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 628);
            this.panel1.TabIndex = 1;
            // 
            // lblMenuMarcas
            // 
            this.lblMenuMarcas.AutoSize = true;
            this.lblMenuMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuMarcas.Location = new System.Drawing.Point(3, 183);
            this.lblMenuMarcas.Name = "lblMenuMarcas";
            this.lblMenuMarcas.Size = new System.Drawing.Size(58, 16);
            this.lblMenuMarcas.TabIndex = 5;
            this.lblMenuMarcas.Text = "Marcas";
            // 
            // lblMenuArticulos
            // 
            this.lblMenuArticulos.AutoSize = true;
            this.lblMenuArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuArticulos.Location = new System.Drawing.Point(3, 100);
            this.lblMenuArticulos.Name = "lblMenuArticulos";
            this.lblMenuArticulos.Size = new System.Drawing.Size(67, 16);
            this.lblMenuArticulos.TabIndex = 3;
            this.lblMenuArticulos.Text = "Artículos";
            this.lblMenuArticulos.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMenuCategorias
            // 
            this.lblMenuCategorias.AutoSize = true;
            this.lblMenuCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuCategorias.Location = new System.Drawing.Point(3, 142);
            this.lblMenuCategorias.Name = "lblMenuCategorias";
            this.lblMenuCategorias.Size = new System.Drawing.Size(83, 16);
            this.lblMenuCategorias.TabIndex = 4;
            this.lblMenuCategorias.Text = "Categorías";
            this.lblMenuCategorias.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnAgregarArticulo);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.lblBuscar);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 82);
            this.panel2.TabIndex = 2;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(746, 39);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(120, 35);
            this.btnAgregarArticulo.TabIndex = 5;
            this.btnAgregarArticulo.Text = "Agregar Artículo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(162, 54);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(329, 20);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            this.lblFiltarPor.Location = new System.Drawing.Point(110, 593);
            this.lblFiltarPor.Name = "lblFiltarPor";
            this.lblFiltarPor.Size = new System.Drawing.Size(53, 13);
            this.lblFiltarPor.TabIndex = 4;
            this.lblFiltarPor.Text = "Filtrar por:";
            // 
            // cboTipoCategoria
            // 
            this.cboTipoCategoria.FormattingEnabled = true;
            this.cboTipoCategoria.Location = new System.Drawing.Point(184, 590);
            this.cboTipoCategoria.Name = "cboTipoCategoria";
            this.cboTipoCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboTipoCategoria.TabIndex = 5;
            // 
            // cboSubTipoCategoria
            // 
            this.cboSubTipoCategoria.FormattingEnabled = true;
            this.cboSubTipoCategoria.Location = new System.Drawing.Point(323, 590);
            this.cboSubTipoCategoria.Name = "cboSubTipoCategoria";
            this.cboSubTipoCategoria.Size = new System.Drawing.Size(168, 21);
            this.cboSubTipoCategoria.TabIndex = 6;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(522, 590);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(98, 23);
            this.btnLimpiarFiltro.TabIndex = 7;
            this.btnLimpiarFiltro.Text = "Limpiar Filtros";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.Location = new System.Drawing.Point(101, 80);
            this.dgvArticulos.MaximumSize = new System.Drawing.Size(777, 495);
            this.dgvArticulos.MinimumSize = new System.Drawing.Size(777, 495);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(777, 495);
            this.dgvArticulos.TabIndex = 8;
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(878, 627);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.cboSubTipoCategoria);
            this.Controls.Add(this.cboTipoCategoria);
            this.Controls.Add(this.lblFiltarPor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(894, 666);
            this.MinimizeBox = false;
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
        private System.Windows.Forms.ComboBox cboTipoCategoria;
        private System.Windows.Forms.ComboBox cboSubTipoCategoria;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
    }
}

