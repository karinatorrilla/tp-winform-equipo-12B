using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_12B
{
    public partial class ventanaPrincipal : Form
    {
        public ventanaPrincipal()
        {
            InitializeComponent();
        }
        private void ventanaPrincipal_Close(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("¡Gracias por usar el programa!");
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            FormAgregar ventana = new FormAgregar();
            ventana.ShowDialog();

        }

        private void ventanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            FormModificar ventana = new FormModificar();
            ventana.ShowDialog();
        }

        private void btnBusquedaArticulos_Click(object sender, EventArgs e)
        {
            FormBuscar ventana = new FormBuscar();
            ventana.ShowDialog();
        }

        private void btnListadoArticulos_Click(object sender, EventArgs e)
        {
            FormListado ventana = new FormListado();
            ventana.ShowDialog();
        }

        private void btnDetalleArticulo_Click(object sender, EventArgs e)
        {
            FormDetalle ventana = new FormDetalle();
            ventana.ShowDialog();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            FormEliminar ventana = new FormEliminar();
            ventana.ShowDialog();
        }
    }
}
