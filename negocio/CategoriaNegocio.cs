﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {


        private ListadoArticuloNegocio listadoArticuloNegocio = new ListadoArticuloNegocio();

        public List<Categoria> ListarCategoria()
        {

            return listadoArticuloNegocio.ListarCategorias();

        }
    }
}
