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
            btnFrmGuardarArticulo.Text = "Modificar";

        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            try
            {
                cboFrmMarcaArticulo.DataSource = marca.ListarMarca();
                cboFrmMarcaArticulo.ValueMember = "Id";
                cboFrmMarcaArticulo.DisplayMember = "Descripcion";
                
                cboFrmCategoriaArticulo.DataSource = categoria.ListarCategoria();
                cboFrmCategoriaArticulo.ValueMember = "Id";
                cboFrmCategoriaArticulo.DisplayMember = "Descripcion";

                //precarga de datos para modificar articulo!!!
                if (articulo != null)
                {
                    txtFrmCodigoArticulo.Text = articulo.Codigo;
                    txtFrmNombreArticulo.Text = articulo.Nombre;
                    cboFrmMarcaArticulo.SelectedValue = articulo.Marca.Id;
                    cboFrmCategoriaArticulo.SelectedValue = articulo.Categoria.Id;
                    txtFrmPrecioArticulo.Text = articulo.Precio.ToString();
                    txtFrmDescripcionArticulo.Text = articulo.Descripcion;
                    txtFrmUrlImagen.Text = articulo.Imagen.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnFrmGuardarArticulo_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtFrmCodigoArticulo.Text;
                articulo.Nombre = txtFrmNombreArticulo.Text;
                articulo.Precio = float.Parse(txtFrmPrecioArticulo.Text);
                articulo.Descripcion = txtFrmDescripcionArticulo.Text;
                articulo.Marca=(Marca)cboFrmMarcaArticulo.SelectedItem;
                articulo.Categoria=(Categoria)cboFrmCategoriaArticulo.SelectedItem;
                //Si el id de artículo es distinto de 0 lo modifica, si no, entiende que no hay artículo
                //cargado y lo agrega...
                if (articulo.Id != 0)
                {
                    negocio.Modificar(articulo);
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


    }
}
