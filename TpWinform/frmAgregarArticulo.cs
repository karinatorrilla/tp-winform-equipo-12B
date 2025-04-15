using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TpWinform
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

       
        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            
        }

        private void lblFrmImagenArticulo_Click(object sender, EventArgs e)
        {

        }

        private void lblFrmCategoriaArticulo_Click(object sender, EventArgs e)
        {

        }

        private void txtFrmPrecioArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFrmGuardarArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                articulo.Codigo = txtFrmCodigoArticulo.Text;
                articulo.Nombre = txtFrmNombreArticulo.Text;
                articulo.Precio = float.Parse(txtFrmPrecioArticulo.Text);
                articulo.Descripcion = txtFrmDescripcionArticulo.Text;

                negocio.agregar(articulo);
                MessageBox.Show("Artículo agregado exitosamente!");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnFrmCancelarArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblFrmPrecioArticulo_Click(object sender, EventArgs e)
        {

        }

        private void cboFrmCategoriaArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboFrmMarcaArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
