using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        private ListadoArticuloNegocio listadoArticuloNegocio = new ListadoArticuloNegocio();

        public List<Articulo> ListarArticulos()
        {
            return listadoArticuloNegocio.Listar();
        }

        public void agregar(Articulo nuevo)
        {
            Console.WriteLine("Agregar articulo");

        }
    }
}
