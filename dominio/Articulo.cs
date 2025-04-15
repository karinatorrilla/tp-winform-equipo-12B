﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }

        //public List<string> Imagenes { get; set; } = new List<string>();
        public float Precio { get; set; }

        public string Acciones { get; set; }



    }


  
}
