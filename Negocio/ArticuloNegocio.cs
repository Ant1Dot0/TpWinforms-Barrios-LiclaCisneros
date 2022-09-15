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

                datos.setearQuery("SELECT Codigo, Nombre, A.Descripcion as Descripcion, m.Descripcion AS MARCA,C.Descripcion AS CATEGORIA, ImagenUrl, Precio from ARTICULOS A, Marcas M , CATEGORIAS C WHERE A.IdMarca = M.Id AND C.ID = A.IdCategoria");
                datos.EjecutarLectura(); 
                   

                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();


                    aux.codigo = (string)datos.Lector.GetString(0);
                    aux.Nombre = (string)datos.Lector.GetString(1);
                    aux.Descripcion = (string)datos.Lector.GetString(2);
                    
                    aux.marca = new Marca();
                    aux.marca.descripcion = (string)datos.Lector.GetString(3);

                    aux.categoria = new Categoria();
                    aux.categoria.descripcion = (string)datos.Lector.GetString(4);

                    //if(!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("ImagenUrl"))))
                    //  aux.UrlImagen = (string)datos.Lector.GetString(5);

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector.GetString(5);

                    aux.Precio = (decimal)datos.Lector["Precio"];


                    lista.Add(aux);
                
                }

                datos.cerrarConexion();
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

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Insert into ARTICULOS (codigo, nombre, descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values ('"+ nuevo.codigo + "' ,'" + nuevo.Nombre+"','"+ nuevo.Descripcion +"',"+ nuevo.marca.id+","+ nuevo.categoria.cod+",'"+nuevo.UrlImagen+"',"+ nuevo.Precio+")");

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo modificar)
        {

        }

    }
}
