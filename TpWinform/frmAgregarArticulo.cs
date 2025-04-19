using System;
using System.Reflection;
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

        private bool SoloNumerosYLetras(string texto)
        {
            foreach (char caracter in texto)
            {
                if (!(char.IsNumber(caracter)) && !(char.IsLetter(caracter)))
                {
                    return false;
                }
            }
            return true;
        }

        private bool ValidarCampos(Articulo articulo)
        {
            try
            {
                //CODIGO
                articulo.Codigo = txtFrmCodigoArticulo.Text;
                if (!(SoloNumerosYLetras(txtFrmCodigoArticulo.Text)))
                {
                    MessageBox.Show("Error. El código solo admite números y letras.");                    
                }
                if (txtFrmCodigoArticulo.Text.Length > 50 || string.IsNullOrEmpty(txtFrmCodigoArticulo.Text))
                {
                    lblErrorCodigo.Visible = true;                    
                }

                //NOMBRE
                articulo.Nombre = txtFrmNombreArticulo.Text;
                if (txtFrmNombreArticulo.Text.Length > 50 || string.IsNullOrEmpty(txtFrmNombreArticulo.Text))
                {
                    lblErrorNombre.Visible = true;                   
                }

                //PRECIO
                articulo.Precio = float.Parse(txtFrmPrecioArticulo.Text);
                /*if (string.IsNullOrEmpty(txtFrmPrecioArticulo.Text))
                {
                    lblErrorPrecio.Visible = true;                  
                }
                float precio;
                if (!float.TryParse(txtFrmPrecioArticulo.Text, out precio))
                {
                    lblErrorPrecio.Visible = true;                    
                }*/

                //DESCRIPCION                              
                if (txtFrmDescripcionArticulo.Text.Length > 150)
                {
                    lblErrorDescripcion.Visible = true;
                    return false;
                }
                articulo.Descripcion = txtFrmDescripcionArticulo.Text;

                articulo.Marca = (Marca)cboFrmMarcaArticulo.SelectedItem;
                articulo.Categoria = (Categoria)cboFrmCategoriaArticulo.SelectedItem;
                articulo.Imagen.ImagenUrl = txtFrmUrlImagen.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("¡Primero complete los campos obligatorios!");
                return false;
            }
            return true;
        }

        private void btnFrmGuardarArticulo_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                articulo.Imagen = new Imagen();

                if (!(ValidarCampos(articulo)))
                {
                    return;
                }

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
                    if (ultimoId > 0)
                    {
                        negocio.crearImagenes(txtFrmUrlImagen.Text, ultimoId);
                    }

                    MessageBox.Show("¡Artículo agregado exitosamente!");

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

        private void lblErrorAgregarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void txtFrmPrecioArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //&& e.KeyChar != '.') <--- por si queremos decimales
            {
                e.Handled = true; // Cancela la tecla presionada
            }
        }
    }
}
