using System;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using dominio;
using negocio;
using System.Drawing;

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
                if (validaEstaciosUrl.ToUpper().Contains("HTTP") || validaEstaciosUrl.ToUpper().Contains("HTTPS"))
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
                //articulo.Imagen.ImagenUrl = txtFrmUrlImagen.Text;
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
                articulo.Imagenes = new List<string>();

                //articulo.Codigo = txtFrmCodigoArticulo.Text;
                //articulo.Nombre = txtFrmNombreArticulo.Text;
                //articulo.Precio = float.Parse(txtFrmPrecioArticulo.Text);
                //articulo.Descripcion = txtFrmDescripcionArticulo.Text;
                //articulo.Marca=(Marca)cboFrmMarcaArticulo.SelectedItem;
                //articulo.Categoria=(Categoria)cboFrmCategoriaArticulo.SelectedItem;

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

        private void btnFrmCancelarArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
