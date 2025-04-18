using System;
using System.Collections;
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
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
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

        //Obtener el ID del último artículo creado
        public int obtenerUltimoArticuloCreado()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select MAX(Id) from ARTICULOS");
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    return datos.Lector.GetInt32(0);
                }
                return -1;
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

        public void crearImagenes(string urlImagen, int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into IMAGENES (IdArticulo, ImagenUrl) values (@IdArticulo, @ImagenUrl)");
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.setearParametro("@ImagenUrl", urlImagen);
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
                datos.setearConsulta("Update ARTICULOS set Codigo = '" + mod.Codigo + "' , Nombre = '" + mod.Nombre + "', Precio = '" + mod.Precio + "' , Descripcion = '" + mod.Descripcion + "' , IdMarca = '" + mod.Marca.Id + "', IdCategoria = '" + mod.Categoria.Id + "' Where Id = '" + mod.Id + "'");
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

        public void ActualizarImagen(Articulo mod)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Update IMAGENES set ImagenUrl = '" + mod.Imagen + "'  Where IdArticulo = '" + mod.Id + "'");
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

        public void EliminarImagenesArticulo(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //Elimino primero la imagen asociada a ese regstro de articulo
                datos.setearConsulta("Delete From IMAGENES Where IdArticulo = '" + id + "'");
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

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //Elimino el articulo con el id asociado
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
                string consulta = "select A.Codigo,A.Nombre,A.Descripcion,M.Descripcion as 'Marca',C.Descripcion as 'Categoria',A.Precio,I.ImagenUrl as 'ImagenUrl' from ARTICULOS as A ,MARCAS M ,CATEGORIAS C, IMAGENES I where A.Id=I.IdArticulo and A.IdMarca=M.Id and A.IdCategoria=C.Id and ( A.Codigo like '%" + buscar + "%' or A.Nombre like '%" + buscar + "%' or  A.Descripcion like '%" + buscar + "%' or M.Descripcion like '%" + buscar + "%' or C.Descripcion like '%" + buscar + "%' )";

                datos.setearConsulta(consulta);

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {


                    lista.Add(ArticuloFiltrado(datos));
                    /*
                    Articulo aux = new Articulo();

                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    aux.Precio = (float)(decimal)datos.Lector["Precio"];

                    ///Se agrega instancia de imagen para traer de base de datos al utilizar el buscador
                    aux.Imagen = new Imagen();
                    aux.Imagen.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    ///agregar a una lista de imagen si hay mas de una?
                    ///
                    lista.Add(aux);*/
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

        public List<Articulo> Filtrar(string tabla, string criterio)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Codigo,A.Nombre,A.Descripcion,M.Descripcion as 'Marca',C.Descripcion as 'Categoria',A.Precio,I.ImagenUrl as 'ImagenUrl' from ARTICULOS as A ,MARCAS M ,CATEGORIAS C, IMAGENES I where A.Id=I.IdArticulo and A.IdMarca=M.Id and A.IdCategoria=C.Id and ";

                switch (tabla)
                {
                    case "Marca":
                        consulta += "M.Descripcion ='" + criterio + "'";
                        break;
                    case "Categoria":
                        consulta += "C.Descripcion ='" + criterio + "'";
                        break;

                }


                datos.setearConsulta(consulta);

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    lista.Add(ArticuloFiltrado(datos));
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



        private Articulo ArticuloFiltrado(AccesoDatos datos)
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

            ///Se agrega instancia de imagen para traer de base de datos al utilizar el buscador
            aux.Imagen = new Imagen();
            aux.Imagen.ImagenUrl = (string)datos.Lector["ImagenUrl"];
            ///agregar a una lista de imagen si hay mas de una?
            ///
            return aux;
        }

    }
}
