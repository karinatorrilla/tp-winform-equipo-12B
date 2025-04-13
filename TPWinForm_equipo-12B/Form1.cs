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

        }
    }
}
