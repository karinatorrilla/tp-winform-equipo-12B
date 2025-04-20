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
using static TpWinform.frmAdministrar;

namespace TpWinform
{
    public partial class frmAdminAgreModElim : Form
    {
        private Marca marca = null;
        private MarcaNegocio marcaNegocio;

        private Categoria categoria = null;
        private CategoriaNegocio categoriaNegocio;

       
        private bool esModificable = false;
        public enum Administrar { Marca, Categoria }
        //Constantes para definir que datasource mostrar si marca o categoria

        private frmAdministrar.Administrar tipo;

        //
        

        //

        public frmAdminAgreModElim(frmAdministrar.Administrar tipo)
        {
            InitializeComponent();
            this.tipo = tipo;

        }

        public frmAdminAgreModElim(Categoria seleccionado, bool modificar)
        {
            InitializeComponent();
            this.categoria = seleccionado;
            this.esModificable = modificar;
            this.tipo = frmAdministrar.Administrar.Categoria;
            if (esModificable)
            {
                Text = "Modificando";
                lblAdministrar.Text = "Categoria";
            }

        }

        public frmAdminAgreModElim(Marca seleccionado, bool modificar)
        {
            InitializeComponent();
            this.marca = seleccionado;
            this.esModificable = modificar;
            this.tipo = frmAdministrar.Administrar.Marca;
            if (esModificable)
            {
                Text = "Modificando";
                lblAdministrar.Text = "Marca";

            }

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {

                if (tipo == frmAdministrar.Administrar.Marca)
                {
                    marcaNegocio = new MarcaNegocio();

                    if (marca == null)
                        marca = new Marca();

                    if (marca.Id != 0)
                    {

                        marca.Descripcion = txtAdministrar.Text;
                        marcaNegocio.ModificarMarca(marca);
                        MessageBox.Show("Marca modificada exitosamente!");
                    }
                    else
                    {
                        marca.Descripcion = txtAdministrar.Text;
                        marcaNegocio.AgregarMarca(marca);
                        MessageBox.Show("Marca agregada exitosamente!");
                    }
                    Close();
                }

                if (tipo == frmAdministrar.Administrar.Categoria)
                {
                    categoriaNegocio = new CategoriaNegocio();

                    if (categoria == null)
                        categoria = new Categoria();

                    if (categoria.Id != 0)
                    {
                        categoria.Descripcion = txtAdministrar.Text;
                        categoriaNegocio.ModificarCategoria(categoria);
                        MessageBox.Show("Categoria modificada exitosamente!");                       
                    }
                    else
                    {
                        categoria.Descripcion = txtAdministrar.Text;
                        categoriaNegocio.AgregarCategoria(categoria);
                        MessageBox.Show("Categoria agregada exitosamente!");
                    }
                    Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void frmAdminAgreModElim_Load(object sender, EventArgs e)
        {
            if (esModificable)
            {
                if (marca != null)
                {
                    txtAdministrar.Text = marca.Descripcion;
                }
                else if (categoria != null)
                {
                    txtAdministrar.Text = categoria.Descripcion;
                }
            }
        }
    }
}
