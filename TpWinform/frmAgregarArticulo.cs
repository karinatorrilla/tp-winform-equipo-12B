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
        private Articulo articulo = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        //Constructor para modificar artículo!!!
        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar";
            lblCrearArticulo.Text = "Modificar Artículo";
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            try
            {

                //precarga de datos para modificar articulo!!!
                if(articulo != null)
                {
                    txtFrmCodigoArticulo.Text = articulo.Codigo;
                    txtFrmNombreArticulo.Text = articulo.Nombre;
                    txtFrmPrecioArticulo.Text = articulo.Precio.ToString();
                    //txtFrmMarca
                    //txtFrmCategoria
                    txtFrmDescripcionArticulo.Text = articulo.Descripcion;
                    //txtFrmImagen
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
 
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtFrmCodigoArticulo.Text;
                articulo.Nombre = txtFrmNombreArticulo.Text;
                articulo.Precio = float.Parse(txtFrmPrecioArticulo.Text);
                articulo.Descripcion = txtFrmDescripcionArticulo.Text;

                //Si el id de artículo es distinto de 0 lo modifica, si no, entiende que no hay artículo
                //cargado y lo agrega...
                if(articulo.Id != 0)
                {
                negocio.modificar(articulo);
                MessageBox.Show("Artículo modificado exitosamente!");
                }
                else
                {
                negocio.agregar(articulo);
                MessageBox.Show("Artículo agregado exitosamente!");
                }
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
