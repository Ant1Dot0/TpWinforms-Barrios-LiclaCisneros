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

                datos.setearQuery("SELECT a.Id as idarticulo, Codigo, Nombre, A.Descripcion as Descripcion, m.Descripcion AS MARCA,C.Descripcion AS CATEGORIA, ImagenUrl, Precio,m.id as idmarca,c.id as idcategoria from ARTICULOS A, Marcas M , CATEGORIAS C WHERE A.IdMarca = M.Id AND C.ID = A.IdCategoria");
                datos.EjecutarLectura(); 
                   

                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();

                    aux.id = datos.Lector.GetInt32(0);
                    aux.codigo = (string)datos.Lector.GetString(1);
                    aux.Nombre = (string)datos.Lector.GetString(2);
                    aux.Descripcion = (string)datos.Lector.GetString(3);
                    
                    aux.marca = new Marca();
                    aux.marca.descripcion = (string)datos.Lector.GetString(4);

                    aux.categoria = new Categoria();
                    aux.categoria.descripcion = (string)datos.Lector.GetString(5);
                    
                    //if(!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("ImagenUrl"))))
                    //  aux.UrlImagen = (string)datos.Lector.GetString(5);

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector.GetString(6);

                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.categoria.cod = (int)datos.Lector["idcategoria"];
                    aux.marca.id = (int)datos.Lector["idmarca"];

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

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("UPDATE ARTICULOS SET CODIGO=@codigo,NOMBRE=@Nombre,DESCRIPCION=@Descripcion,IDMARCA=@idmarca,IDCATEGORIA=@idcaegoria,IMAGENURL=@UrlImagen,PRECIO=@Precio WHERE ID=@id");
                datos.setearParametros("@id", modificar.id);
                datos.setearParametros("@codigo", modificar.codigo);
                datos.setearParametros("@Nombre", modificar.Nombre);
                datos.setearParametros("@Descripcion", modificar.Descripcion);
                datos.setearParametros("@idmarca", modificar.marca.id);
                datos.setearParametros("@idcaegoria", modificar.categoria.cod);
                datos.setearParametros("@UrlImagen", modificar.UrlImagen);
                datos.setearParametros("Precio", modificar.Precio);

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



        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.setearQuery("delete from ARTICULOS where id=@id");
                datos.setearParametros("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
