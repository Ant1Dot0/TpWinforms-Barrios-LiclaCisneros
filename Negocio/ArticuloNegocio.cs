using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = " server =.\\SQLEXPRESS; database =CATALOGO_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Codigo, Nombre, A.Descripcion,  ImagenUrl, Precio, m.Descripcion AS MARCA,C.Descripcion AS CATEGORIA from ARTICULOS A, Marcas M , CATEGORIAS C WHERE A.IdMarca = M.Id AND C.ID = A.IdCategoria";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();


                while (lector.Read())
                {

                    Articulo aux = new Articulo();

                    aux.codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["A.Descripcion"];

                    aux.marca = new Marca();
                    aux.marca.descripcion = (string)lector["Marca"];

                    aux.categoria = new Categoria();
                    aux.categoria.descripcion = (string)lector["Categoria"];
                    aux.UrlImagen = (String)lector["ImagenUrl"];
                    aux.Precio = (float)lector["Precio"];

                    lista.Add(aux);
                
                }

                return lista;
            }
            catch ( Exception ex)
            {

                throw;
            }

        }

    }
}
