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
                        MessageBox.Show("¡Debe seleccionar un item de la lista!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
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
                        MessageBox.Show("¡Debe seleccionar un item de la lista!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


          
        }

        private void btnEliminarAdminisitrar_Click(object sender, EventArgs e)
        {
            cargarInfo(tipo);
        }

        private void frmAdministrar_Leave(object sender, EventArgs e)
        {
            //frmArticulo.cargar();
        }

        private void frmAdministrar_FormClosed(object sender, FormClosedEventArgs e)
        {           
            frmArticulo.cargar();
        }
    }
}
