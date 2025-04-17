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

        //Agregar articulo
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Precio, Descripcion, idMarca, idCategoria)values('" + nuevo.Codigo + "', '" + nuevo.Nombre + "'," + nuevo.Precio + ", '" + nuevo.Descripcion + "',@IdMarca,@IdCategoria)");
                datos.setearParametro("@idMarca", nuevo.Marca.Id);
                datos.setearParametro("@idCategoria",nuevo.Categoria.Id);
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

        //Modificar articulo
        public void Modificar(Articulo mod)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Update ARTICULOS set Codigo = '" + mod.Codigo + "' , Nombre = '" + mod.Nombre + "', Precio = '" + mod.Precio + "' , Descripcion = '" + mod.Descripcion + "' , IdMarca = 1, IdCategoria = 1 Where Id = '" + mod.Id + "'");
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

        //Eliminar artículo (eliminación física)
        public void Eliminar (int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From ARTICULOS Where Id = '" + id + "'");
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

        //Filtro rapido del buscador
        public List<Articulo> Filtrar(string buscar)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Codigo,A.Nombre,A.Descripcion,M.Descripcion as 'Marca',C.Descripcion as 'Categoria',A.Precio from ARTICULOS as A ,MARCAS M ,CATEGORIAS C where A.IdMarca=M.Id and A.IdCategoria=C.Id and ( A.Codigo like '%" + buscar + "%' or A.Nombre like '%" + buscar + "%' or  A.Descripcion like '%" + buscar + "%' or M.Descripcion like '%" + buscar + "%' or C.Descripcion like '%" + buscar + "%' )";

                datos.setearConsulta(consulta);

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    aux.Precio = (float)(decimal)datos.Lector["Precio"];
                 

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            ;
        }
    }
}
