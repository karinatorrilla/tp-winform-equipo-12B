using System;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using dominio;
using negocio;
using System.Drawing;
using System.Text.RegularExpressions;

namespace TpWinform
{
    public partial class frmAgregarArticulo : Form
    {
        private Articulo articulo = null;
        private bool esModificable = false;
        public frmAgregarArticulo()
        {
            InitializeComponent();
            inicializaLabelsErrorOcultos();
        }

        //Constructor para modificar artículo!!!
        public frmAgregarArticulo(Articulo articulo, bool modificar)
        {
            InitializeComponent();
            inicializaLabelsErrorOcultos();
            this.articulo = articulo;
            this.esModificable = modificar;

            if (esModificable)
            {
                Text = "Modificar";
                lblCrearArticulo.Text = "Modificar Artículo";
                btnFrmGuardarArticulo.Text = "Modificar";
                if (articulo.Imagenes != null)
                {
                    txtFrmUrlImagen.Text = string.Join(",", articulo.Imagenes);
                }
            }
            else
            {
                Text = "Detalle";
                lblCrearArticulo.Text = "Detalle del Artículo";
                btnFrmGuardarArticulo.Visible = false;
                btnFrmCancelarArticulo.Text = "Volver";
                if (articulo.Imagenes != null)
                {
                    txtFrmUrlImagen.Text = string.Join(",", articulo.Imagenes);
                }
                BloquearCampos();
            }
            

        }


        private void inicializaLabelsErrorOcultos()
        {
            lblErrorCampoUrlImage.Visible = false;
        }

        private bool validacionUrlImagenes(Articulo articulo)
        {
            bool hayUrlInvalida = false;
            lblErrorCampoUrlImage.Visible = false;
            txtFrmUrlImagen.BackColor = System.Drawing.Color.White;

            string capturaUrls = txtFrmUrlImagen.Text;
            string[] urlsArray = capturaUrls.Split(','); // guardo las urls separadas


            List<Imagen> listaImagenes = new List<Imagen>();

            foreach (string url in urlsArray)
            {
                string validaEstaciosUrl = url.Trim();
                if (!string.IsNullOrEmpty(validaEstaciosUrl))
                {
                    if ((validaEstaciosUrl.ToUpper().StartsWith("HTTP") || validaEstaciosUrl.ToUpper().StartsWith("HTTPS")) &&
                        (validaEstaciosUrl.ToUpper().Contains("PNG") || validaEstaciosUrl.ToUpper().Contains("JPEG") ||
                         validaEstaciosUrl.ToUpper().Contains("JPG") || validaEstaciosUrl.ToUpper().Contains("GIF")))
                    {
                        // tiene que tener menor igual a 1000 caracteres
                        if (validaEstaciosUrl.Length <= 1000)
                        {
                            listaImagenes.Add(new Imagen { ImagenUrl = validaEstaciosUrl });
                        }
                        else
                        {
                            hayUrlInvalida = true;
                            break; // Con que encuentre una sola url invalida sale del foreacj
                        }
                    }
                    else
                    {
                        hayUrlInvalida = true;
                        break; // Con que encuentre una sola url invalida sale del foreacj
                    }

                }
                else if (urlsArray.Length > 1) // Si hay mas de un elemento como la ","
                {
                    hayUrlInvalida = true;
                    break;
                }

            }

            //Si existe urls invalidas muestra al usuario 
            if (hayUrlInvalida)
            {
                lblErrorCampoUrlImage.Visible = true;
                txtFrmUrlImagen.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                // Extraemos solo las URLs de la lista de objetos Imagen y se asgina a articulo.Imagenes
                articulo.Imagenes = listaImagenes.Select(img => img.ImagenUrl).ToList();
            }


            return hayUrlInvalida;
        }


        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

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

                    // Obtener solo las imágenes del artículo seleccionado
                    List<Imagen> imagenes = articuloNegocio.ObtenerImagenesPorIdArticulo(articulo.Id);
                    articulo.Imagenes = imagenes.Select(img => img.ImagenUrl).ToList();

                    if (imagenes != null)
                    {
                        txtFrmUrlImagen.Text = string.Join(",", imagenes.Select(img => img.ImagenUrl));


                        for (int i = 0; i < imagenes.Count; i++)
                        {
                            PictureBox nuevaPictureBox = new PictureBox();
                            nuevaPictureBox.Name = "pbxImagen" + (i == 0 ? "" : i.ToString());
                            nuevaPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            nuevaPictureBox.Width = 100;
                            nuevaPictureBox.Height = 100;

                            cargarImagenFormArticulo(nuevaPictureBox, imagenes[i].ImagenUrl);
                            flpContenedorImagenes.Controls.Add(nuevaPictureBox);

                        }
                    }
                    else
                    {
                        txtFrmUrlImagen.Text = "";                       
                    }
                }
                else
                {
                    //INICIALIZAR COMBO BOX VACIOS
                    cboFrmMarcaArticulo.SelectedItem = null;
                    cboFrmCategoriaArticulo.SelectedItem = null;
                }
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }


        private void cargarImagenFormArticulo(PictureBox pbxImagen, string urlImagen)
        {
            try
            {
                pbxImagen.Load(urlImagen);
            }
            catch (Exception)
            {
                pbxImagen.Load("https://t4.ftcdn.net/jpg/07/91/22/59/360_F_791225927_caRPPH99D6D1iFonkCRmCGzkJPf36QDw.jpg");
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
        private bool NombreTieneLetra(string texto)
        {
            foreach (char caracter in texto)
            {
                if (char.IsLetter(caracter))
                    return true;
            }
            return false;
        }
        private bool SoloNumerosYLetrasJuntos(string texto)
        {
            bool tieneLetra = false;
            bool tieneNumero = false;

            foreach (char caracter in texto)
            {               
                if (char.IsLetter(caracter))
                {
                    tieneLetra = true;
                }
                else if (char.IsNumber(caracter))
                {
                    tieneNumero = true;
                }
                else
                {
                    return false;
                }
            }
            return tieneLetra && tieneNumero;
        }

        private bool ValidarCampos(Articulo articulo)
        {
            
            try
            {    
                //CAMPOS OBLIGATORIOS VACIOS
                if(string.IsNullOrEmpty(txtFrmCodigoArticulo.Text) || 
                    string.IsNullOrEmpty(txtFrmNombreArticulo.Text) || 
                    string.IsNullOrEmpty(txtFrmPrecioArticulo.Text) ||
                    cboFrmCategoriaArticulo == null ||
                    cboFrmMarcaArticulo == null)
                {
                    MessageBox.Show("¡Primero complete los campos obligatorios!");
                    lblErrorCodigo.Visible = true;
                    lblErrorNombre.Visible = true;
                    lblErrorPrecio.Visible = true;
                    lblErrorMarca.Visible = true;
                    lblErrorCategoria.Visible = true;
                    return false;
                }

                //DESCRIPCION
                if(txtFrmDescripcionArticulo.Text.Length > 150)
                {
                    lblErrorDescripcion.Visible = true;
                    lblErrorCodigo.Visible = false;
                    lblErrorPrecio.Visible = false;
                    lblErrorCodigo.Visible = false;
                    return false;
                }

                //CODIGO
                if (SoloNumerosYLetrasJuntos(txtFrmCodigoArticulo.Text) == false)
                {
                    MessageBox.Show("Error al agregar. El código solo admite números y letras juntos.");
                    lblErrorCodigo.Visible = true;
                    lblErrorNombre.Visible = false;
                    lblErrorPrecio.Visible = false;
                    lblErrorDescripcion.Visible = false;
                    return false;
                }

                if(txtFrmCodigoArticulo.Text.Length > 50)
                {
                    MessageBox.Show("Error al agregar. El código no puede superar los 50 caracteres.");
                    lblErrorCodigo.Visible = true;
                    lblErrorNombre.Visible = false;
                    lblErrorPrecio.Visible = false;
                    lblErrorDescripcion.Visible = false;
                    return false;
                }

                //NOMBRE
                if(NombreTieneLetra(txtFrmNombreArticulo.Text) == false)
                {
                    MessageBox.Show("Error al agregar. El nombre no puede tener solo números.");
                    lblErrorNombre.Visible = true;
                    lblErrorCodigo.Visible = false;                    
                    lblErrorPrecio.Visible = false;
                    lblErrorDescripcion.Visible = false;
                    return false;
                }

                if(txtFrmNombreArticulo.Text.Length > 50)
                {
                    MessageBox.Show("Error al agregar. El nombre no puede superar los 50 caracteres.");
                    lblErrorCodigo.Visible = false;
                    lblErrorNombre.Visible = true;
                    lblErrorPrecio.Visible = false;
                    lblErrorDescripcion.Visible = false;
                    return false;
                }
                
                //CATEGORIA
                if(cboFrmCategoriaArticulo.SelectedItem == null)
                {
                    MessageBox.Show("Error al agregar. Debe seleccionar una categoría primero.");
                    lblErrorCodigo.Visible = false;
                    lblErrorNombre.Visible = false;
                    lblErrorPrecio.Visible = false;
                    lblErrorDescripcion.Visible = false;
                    lblErrorMarca.Visible = false;
                    lblErrorCategoria.Visible = true;
                    return false;
                }

                //MARCA
                if (cboFrmMarcaArticulo.SelectedItem == null)
                {
                    MessageBox.Show("Error al agregar. Debe seleccionar una marca primero.");
                    lblErrorCodigo.Visible = false;
                    lblErrorNombre.Visible = false;
                    lblErrorPrecio.Visible = false;
                    lblErrorDescripcion.Visible = false;
                    lblErrorCategoria.Visible = false;
                    lblErrorMarca.Visible = true;
                    return false;
                }

                articulo.Codigo = txtFrmCodigoArticulo.Text;                
                articulo.Nombre = txtFrmNombreArticulo.Text;                                
                articulo.Precio = float.Parse(txtFrmPrecioArticulo.Text);                                                             
                articulo.Descripcion = txtFrmDescripcionArticulo.Text;               
                articulo.Marca = (Marca)cboFrmMarcaArticulo.SelectedItem;
                articulo.Categoria = (Categoria)cboFrmCategoriaArticulo.SelectedItem;                                                                                  
            }
            catch (Exception)
            {               
                MessageBox.Show("Ocurrió un error inesperado.");                
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
                articulo.Imagenes = new List<string>();

                
                if (!(ValidarCampos(articulo)))
                {
                    return;
                }


                if (validacionUrlImagenes(articulo))
                {
                    return;
                }

                //Si el id de artículo es distinto de 0 lo modifica, si no, entiende que no hay artículo
                //cargado y lo agrega...
                if (articulo.Id != 0)
                {
                    negocio.Modificar(articulo);
                    //Voy a eliminar primero las imagenes asociadas a ese articulo y luego las voy a crear "simulando que se actualizaron"
                    negocio.EliminarImagenesArticulo(articulo.Id);
                    foreach (string urlImagen in articulo.Imagenes)
                    {
                        negocio.crearImagenes(urlImagen, articulo.Id);
                    }
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
                        // Recorro sobre la lista de URLs y por cada una llamo a crearImagenes
                        foreach (string urlImagen in articulo.Imagenes)
                        {
                            negocio.crearImagenes(urlImagen, ultimoId);
                        }
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
      
        private void txtFrmPrecioArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                
                e.Handled = true; // Cancela la tecla presionada
            }
        }

        private void btnFrmCancelarArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }
     
    }
}
