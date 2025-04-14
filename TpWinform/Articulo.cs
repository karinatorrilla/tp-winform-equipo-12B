using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TpWinform
{
    internal class Articulo
    {

        public string CodArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }

        //public List<string> Imagenes { get; set; } = new List<string>();
        public float PrecioArticulo { get; set; }



    }


  
}
