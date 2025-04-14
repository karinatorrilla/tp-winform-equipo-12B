using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpWinform
{
    internal class Marca
    {
        public int CodMarca { get; set; }
        public string NombreMarca { get; set; }

        public override string ToString()
        {
            return NombreMarca;
        }

    }
}
