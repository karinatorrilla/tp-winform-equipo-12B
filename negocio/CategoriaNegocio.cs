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

        public void AgregarCategoria(Categoria nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO CATEGORIAS (Descripcion) values('" + nuevo.Descripcion + "')");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void ModificarCategoria(Categoria mod)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE CATEGORIAS SET Descripcion = @descripcion WHERE Id = @id");
                datos.setearParametro("@descripcion", mod.Descripcion);
                datos.setearParametro("@id", mod.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
