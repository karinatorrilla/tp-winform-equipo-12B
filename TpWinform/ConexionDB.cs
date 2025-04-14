using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace TpWinform
{
    class ConexionDB
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Codigo,A.Nombre,A.Descripcion,M.Descripcion as 'Marca',C.Descripcion as 'Categoria',A.Precio from ARTICULOS as A ,MARCAS M ,CATEGORIAS C where A.IdMarca=M.Id and A.IdCategoria=C.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();


                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.CodArticulo = (string)lector["Codigo"];
                    aux.NombreArticulo = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                   
                    aux.Marca = new Marca();
                    aux.Marca.NombreMarca = (string)lector["Marca"];
                   
                    aux.Categoria = new Categoria();
                    aux.Categoria.NombreCategoria = (string)lector["Categoria"];
                   
                    aux.PrecioArticulo = (float)(decimal)lector["Precio"];


                    lista.Add(aux);
                }



                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }
}
