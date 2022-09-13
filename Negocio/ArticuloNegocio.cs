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
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearQuery("SELECT Codigo, Nombre, A.Descripcion,  ImagenUrl, Precio, m.Descripcion AS MARCA,C.Descripcion AS CATEGORIA from ARTICULOS A, Marcas M , CATEGORIAS C WHERE A.IdMarca = M.Id AND C.ID = A.IdCategoria");
                datos.EjecutarLectura(); 
                   

                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();

                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["A.Descripcion"];

                    aux.marca = new Marca();
                    aux.marca.descripcion = (string)datos.Lector["Marca"];

                    aux.categoria = new Categoria();
                    aux.categoria.descripcion = (string)datos.Lector["Categoria"];
                    aux.UrlImagen = (String)datos.Lector["ImagenUrl"];
                    aux.Precio = (float)datos.Lector["Precio"];

                    lista.Add(aux);
                
                }

                return lista;
            }
            catch ( Exception ex)
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
