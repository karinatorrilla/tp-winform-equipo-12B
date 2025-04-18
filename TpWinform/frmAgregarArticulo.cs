using System;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TpWinform
{
    public partial class frmAgregarArticulo : Form
    {
        private Articulo articulo = null;
        private bool esModificable = false;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        //Constructor para modificar artículo!!!
        public frmAgregarArticulo(Articulo articulo, bool modificar)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.esModificable = modificar;

            if (esModificable)
            {
                Text = "Modificar";
                lblCrearArticulo.Text = "Modificar Artículo";
                btnFrmGuardarArticulo.Text = "Modificar";
            }
            else
            {
                Text = "Detalle";
                lblCrearArticulo.Text = "Detalle del Artículo";
                btnFrmGuardarArticulo.Visible = false;
                btnFrmCancelarArticulo.Text = "Volver";
                BloquearCampos();
            }
            

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
                    cargarImagenFormArticulo(articulo.Imagen.ImagenUrl); //carga imagen
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagenFormArticulo(string imagen)
        {
            try
            {
                pictureBox1.Load(imagen);
            }
            catch (Exception)
            {
                pictureBox1.Load("https://t4.ftcdn.net/jpg/07/91/22/59/360_F_791225927_caRPPH99D6D1iFonkCRmCGzkJPf36QDw.jpg");
            }
        }

        private void BloquearCampos()
        {
            txtFrmCodigoArticulo.Enabled = false;
            txtFrmNombreArticulo.Enabled = false;
            cboFrmMarcaArticulo.Enabled = false;
            cboFrmCategoriaArticulo.Enabled = false;
            txtFrmPrecioArticulo.Enabled = false;
            txtFrmDescripcionArticulo.Enabled = false;
            txtFrmUrlImagen.Enabled = false;
        }
        private void btnFrmGuardarArticulo_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                articulo.Imagen = new Imagen();

                articulo.Codigo = txtFrmCodigoArticulo.Text;
                articulo.Nombre = txtFrmNombreArticulo.Text;
                articulo.Precio = float.Parse(txtFrmPrecioArticulo.Text);
                articulo.Descripcion = txtFrmDescripcionArticulo.Text;
                articulo.Marca=(Marca)cboFrmMarcaArticulo.SelectedItem;
                articulo.Categoria=(Categoria)cboFrmCategoriaArticulo.SelectedItem;
                articulo.Imagen.ImagenUrl = txtFrmUrlImagen.Text;
                
                //Si el id de artículo es distinto de 0 lo modifica, si no, entiende que no hay artículo
                //cargado y lo agrega...
                if (articulo.Id != 0)
                {
                    negocio.Modificar(articulo);
                    negocio.ActualizarImagen(articulo); //actualiza la imagen del articulo
                    MessageBox.Show("Artículo modificado exitosamente!");
                }
                else
                {
                    negocio.agregar(articulo);
                    //consulta a la db el ultimo ID del articulo creado
                    int ultimoId = negocio.obtenerUltimoArticuloCreado();
                    //Console.WriteLine("ULTIMO ID ARTICULO CREADO" + ultimoId);
                    if(ultimoId > 0)
                    {
                        negocio.crearImagenes(txtFrmUrlImagen.Text, ultimoId);
                    }
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
