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
    public partial class frmAdministrar : Form
    {


        public enum Administrar { Marca, Categoria }
        //Constantes para definir que datasource mostrar si marca o categoria

        private Administrar tipo;

        private frmArticulo frmArticulo;

        public frmAdministrar(Administrar tipo, frmArticulo frmArticulo)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.frmArticulo = frmArticulo;
        }

        private void frmAdministrar_Load(object sender, EventArgs e)
        {
            cargarInfo(tipo);
        }

        private void cargarInfo(Administrar tipo)
        {
            ListadoArticuloNegocio negocio = new ListadoArticuloNegocio();

            if (tipo == Administrar.Marca)
            {
                Text = "Administrar Marcas";
                dgvAdministrar.DataSource = negocio.ListarMarcas();
            }
            else if (tipo == Administrar.Categoria)
            {
                Text = "Administrar Categorías";
                dgvAdministrar.DataSource = negocio.ListarCategorias();
            }
            dgvAdministrar.Columns["Id"].Visible = false;
        }

        private void btnAgregarAdministrar_Click(object sender, EventArgs e)
        {
            frmAdminAgreModElim agregar = new frmAdminAgreModElim(tipo);
            agregar.ShowDialog();            
            cargarInfo(tipo);
        }

        private void btnModificarAdministrar_Click(object sender, EventArgs e)
        {
            if (tipo == Administrar.Marca)
            {
                Marca seleccionado = new Marca();
                try
                {

                    if (dgvAdministrar.CurrentRow != null)
                    {
                        seleccionado = (Marca)dgvAdministrar.CurrentRow.DataBoundItem;
                        frmAdminAgreModElim modificar = new frmAdminAgreModElim(seleccionado, true);
                        modificar.ShowDialog();
                        cargarInfo(tipo);
                    }
                    else
                    {
                        MessageBox.Show("¡Debe seleccionar un item de la lista!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"Error");
                }
            }
            else if (tipo == Administrar.Categoria)
            {
                Categoria seleccionado = new Categoria();
                try
                {

                    if (dgvAdministrar.CurrentRow != null)
                    {
                        seleccionado = (Categoria)dgvAdministrar.CurrentRow.DataBoundItem;
                        frmAdminAgreModElim modificar = new frmAdminAgreModElim(seleccionado, true);
                        modificar.ShowDialog();
                        cargarInfo(tipo);
                    }
                    else
                    {
                        MessageBox.Show("¡Debe seleccionar un item de la lista!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"Error");
                }
            }



        }

        private void frmAdministrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmArticulo.cargar();
        }

        private void btnEliminarAdministrar_Click(object sender, EventArgs e)
        {
            //ELIMINAR MARCAS. LAS IMAGENES Y ARTICULOS ASOCIADOS TAMBIÉN SE ELIMINAN...
            if (tipo == Administrar.Marca)
            {
                Marca seleccionado = new Marca();
                MarcaNegocio negocio = new MarcaNegocio();  
                try
                {

                    if (dgvAdministrar.CurrentRow != null)
                    {
                        DialogResult respuesta = MessageBox.Show("¿Estás seguro de que querés eliminar esta marca? Los artículos" +
                        " asociados a la misma se van a eliminar también...", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                            seleccionado = (Marca)dgvAdministrar.CurrentRow.DataBoundItem;
                            negocio.EliminarMarcaArticuloImagen(seleccionado.Id);
                            cargarInfo(tipo);
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡Debe seleccionar un item de la lista!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"Error");
                }
            }
            //ELIMINAR CATEGORIAS. LAS IMAGENES Y ARTICULOS ASOCIADOS TAMBIÉN SE ELIMINAN...
            else if (tipo == Administrar.Categoria)
            {
                Categoria seleccionado = new Categoria();
                CategoriaNegocio negocio = new CategoriaNegocio();                 
                try
                {

                    if (dgvAdministrar.CurrentRow != null)
                    {
                        DialogResult respuesta = MessageBox.Show("¿Estás seguro de que querés eliminar esta categoría? Los artículos" +
                        " asociados a la misma se van a eliminar también...", "Eliminar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                            seleccionado = (Categoria)dgvAdministrar.CurrentRow.DataBoundItem;
                            negocio.EliminarCategoriaArticuloImagen(seleccionado.Id);
                            cargarInfo(tipo);
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡Debe seleccionar un item de la lista!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"Error");
                }
            }
        }
    }
}
