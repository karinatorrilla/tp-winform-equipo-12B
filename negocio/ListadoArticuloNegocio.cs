using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ListadoArticuloNegocio
    {

        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("select A.Id,A.Codigo,A.Nombre,A.Descripcion,M.Descripcion as 'Marca',C.Descripcion as 'Categoria',A.Precio,I.ImagenUrl from ARTICULOS as A ,MARCAS M ,CATEGORIAS C,IMAGENES I where A.IdMarca=M.Id and A.IdCategoria=C.Id and A.Id = I.IdArticulo");

                
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                   
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                  
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    aux.Precio = (float)(decimal)datos.Lector["Precio"];

                    aux.Imagen = new Imagen();
                    aux.Imagen.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }



                return lista;
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





        public List<Marca> ListarMarcas()
        {
            List<Marca> lista = new List<Marca>();

            AccesoDatos datos = new AccesoDatos();



            try
            {
                datos.setearConsulta("Select Id,Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();

                    marca.Id = (int)datos.Lector["Id"];
                    marca.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(marca);

                }
                return lista;
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
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id,Descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria();

                    categoria.Id = (int)datos.Lector["Id"];
                    categoria.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(categoria);

                }
                return lista;
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
