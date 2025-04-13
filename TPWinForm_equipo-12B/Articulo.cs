using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_12B
{
    internal class Articulo
    {
        public int _codArticulo {  get; set; }
        public string _nombre { get; set; }
        public string _descripcion { get; set; }
        public Marca marca { get; set; }
        public Categoria categoria { get; set; }

        //public List<string> Imagenes { get; set; } = new List<string>();
        public float _precio {  get; set; }

    }
}
