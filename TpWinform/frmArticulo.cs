using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace TpWinform
{
    public partial class frmArticulo : Form
    {
        private List<Articulo> listaArticulo;
        private List<Marca> listaMarca;
        private List<Categoria> listaCategorias;
        private int tamLetra = 8;
        public frmArticulo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboFiltroPrincipal.Items.Add("Marca");
            cboFiltroPrincipal.Items.Add("Categoria");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("¡Gracias por usar el programa!","Equipo 12B");
        }

        // Carga el listado de lista Articulos
        public void cargar()
        {

            try
            {
                ListadoArticuloNegocio negocio = new ListadoArticuloNegocio();
                listaArticulo = negocio.Listar();
                dgvArticulos.DataSource = listaArticulo;
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //para alionear el precio a la derecha

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error");
            }

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                ///Selecciona articulo en las filas 
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            }

        }


        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {

            frmAgregarArticulo alta = new frmAgregarArticulo();
            alta.ShowDialog();

            cargar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string buscar = txtBuscar.Text;
                if (buscar.Length >= 3) // se cambia de nuevo a 3, ya no es optimo para la  DB  estar a cada rato haciendo una consulta por una sola letra
                {
                    dgvArticulos.DataSource = negocio.Filtrar(buscar);
                }
                else
                {
                    dgvArticulos.DataSource = null; // limpia el dataSource
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //List<Articulo> listaFiltrada;


            //string buscar = txtBuscar.Text;

            //if (buscar.Length >= 3)
            //{
            //    listaFiltrada = listaArticulo.FindAll(a => a.Nombre.ToUpper().Contains(buscar.ToUpper()));
            //}
            //else
            //{
            //    listaFiltrada = listaArticulo;
            //}

            //dgvArticulos.DataSource = null; // limpia el dataSource
            //dgvArticulos.DataSource = listaFiltrada;

        }

        //Botón de modificar artículo...
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            //Console.WriteLine("HOLA.. "+ dgvArticulos.CurrentRow);
            try
            {

                if (dgvArticulos.CurrentRow != null)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmAgregarArticulo modificar = new frmAgregarArticulo(seleccionado, true);
                    modificar.ShowDialog();
                    cargar();
                }
                else
                {
                    MessageBox.Show("¡Debe seleccionar un artículo de la lista!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            txtBuscar.Text = "";
        }

        //Botón de ELIMINAR artículo... (Eliminación física)
        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Estás seguro de que querés eliminar el artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.EliminarImagenesArticulo(seleccionado.Id);
                        negocio.Eliminar(seleccionado.Id);
                        cargar();
                    }
                }
                else
                {
                    MessageBox.Show("¡Debe seleccionar un artículo de la lista!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void btnDetalleArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            {

                if (dgvArticulos.CurrentRow != null)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmAgregarArticulo detalle = new frmAgregarArticulo(seleccionado, false);
                    detalle.ShowDialog();
                    cargar();
                }
                else
                {
                    MessageBox.Show("¡Debe seleccionar un artículo de la lista!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            txtBuscar.Text = "";
        }

        private void cboFiltroPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrorFiltro.Visible = false;
            ListadoArticuloNegocio negocio = new ListadoArticuloNegocio();

            string opcion = "";

            if (cboFiltroPrincipal.SelectedItem != null)
            {
                opcion = cboFiltroPrincipal.SelectedItem.ToString();
            }

            if (opcion != "")
            {
                if (opcion == "Marca")
                {
                    listaMarca = negocio.ListarMarcas();
                    cboListaFiltrada.DataSource = listaMarca;
                }
                else
                {
                    listaCategorias = negocio.ListarCategorias();
                    cboListaFiltrada.DataSource = listaCategorias;
                }
            }
        }

        private void btnBuscarFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            string tabla, criterio;

            try
            {
                if (cboFiltroPrincipal.SelectedItem != null || cboListaFiltrada.SelectedItem != null)
                {
                    tabla = cboFiltroPrincipal.SelectedItem.ToString();
                    criterio = cboListaFiltrada.SelectedItem.ToString();
                    dgvArticulos.DataSource = negocio.Filtrar(tabla, criterio);
                }
                else
                {
                    // MessageBox.Show("Por favor, seleccioná una opción en ambos filtros.", "Error de filtro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblErrorFiltro.Visible = true;
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            cboFiltroPrincipal.SelectedIndex = -1;/// seleccionamos un item fuera de la lista para que no muestre nada
            cboListaFiltrada.DataSource = null;/// borra la lista de marca/categoria
            dgvArticulos.DataSource = null; // limpia el dataSource
            cargar();
        }

        private void lblMenuCategorias_Click(object sender, EventArgs e)
        {
            frmAdministrar opcCategoria = new frmAdministrar(frmAdministrar.Administrar.Categoria, this);
            opcCategoria.ShowDialog();
        }

        private void lblMenuMarcas_Click_1(object sender, EventArgs e)
        {
            frmAdministrar opcMarca = new frmAdministrar(frmAdministrar.Administrar.Marca, this);
            opcMarca.ShowDialog();
        }


        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            ///para formato de precio con $ al principio.
            if (dgvArticulos.Columns[e.ColumnIndex].Name == "Precio" && e.Value != null)
            {
                e.Value = $"$ {e.Value:N2}"; // $ precio.00   

                e.FormattingApplied = true;
            }
        }

        private void btnMaxLetra_Click(object sender, EventArgs e)
        {

            tamLetra += 2;
            dgvArticulos.DefaultCellStyle.Font = new Font(" ", tamLetra);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tamLetra -= 2;
            dgvArticulos.DefaultCellStyle.Font = new Font(" ", tamLetra);
        }

        private void btnLetraInicial_Click(object sender, EventArgs e)
        {
            tamLetra = 8;
            dgvArticulos.DefaultCellStyle.Font = new Font(" ", tamLetra);
        }
    }
}

