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

                datos.setearQuery("SELECT A.ID, A.IDMARCA, A.IDCATEGORIA,A.DESCRIPCION AS DESCRIPCION,CODIGO,NOMBRE, M.DESCRIPCION AS MARCADESCRIPCION, C.DESCRIPCION AS CATEGORIAC,IMAGENURL,PRECIO,M.ID AS IDMARC,C.ID AS IDCAT FROM ARTICULOS AS A LEFT JOIN MARCAS M ON A.IdMarca = M.ID LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.ID");
                datos.EjecutarLectura(); 
                   

                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();

                    aux.id = datos.Lector.GetInt32(0);
                    aux.codigo = (string)datos.Lector["CODIGO"];
                    aux.Nombre = (string)datos.Lector["NOMBRE"];
                    if (!(datos.Lector["DESCRIPCION"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    
                    aux.marca = new Marca();
                    aux.marca.descripcion = (string)datos.Lector["MARCADESCRIPCION"];

                    aux.categoria = new Categoria();
                    aux.categoria.descripcion = (string)datos.Lector["CATEGORIAC"];
                    
                    //if(!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("ImagenUrl"))))
                    //  aux.UrlImagen = (string)datos.Lector.GetString(5);

                    if (!(datos.Lector["IMAGENURL"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector.GetString(8);

                    if (!(datos.Lector["PRECIO"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["PRECIO"];
                    if (!(datos.Lector["IDCAT"] is DBNull))
                        aux.categoria.cod = (int)datos.Lector["IDCAT"];
                    if (!(datos.Lector["IDMARC"] is DBNull))
                        aux.marca.id = (int)datos.Lector["IDMARC"];

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


        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT A.ID, A.IDMARCA, A.IDCATEGORIA,A.DESCRIPCION,CODIGO,NOMBRE, M.DESCRIPCION, C.DESCRIPCION,IMAGENURL,PRECIO,M.ID,C.ID FROM ARTICULOS AS A LEFT JOIN MARCAS M ON A.IdMarca = M.ID LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.ID AND ";
                
                switch(campo)
                {

                    case "Marca":////////////////////////////////////////////
                        switch(criterio)
                        {
                            case "Comienza con":
                                consulta += "M.descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "M.descripcion like '%" + filtro + "' ";
                                break;
                            default:
                                consulta += "M.descripcion like '%" + filtro + "%' ";
                                break;
                        }
                        break;
                    case "Categoria"://///////////////////////////////////////////
                        switch(criterio)
                        {
                            case "Comienza con":
                                consulta += "C.descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "C.descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "c.descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Precio":////////////////////////////////////////
                        switch(criterio)
                        {
                            case "Mayor a":
                                consulta += "Precio > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "Precio < " + filtro;
                                break;
                            default:
                                consulta += "Precio = " + filtro;
                                break;
                        }

                        break;

                    default:
                        break;
                }
                
                datos.setearQuery(consulta);
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


                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector.GetString(6);

                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.categoria.cod = (int)datos.Lector["idcategoria"];
                    aux.marca.id = (int)datos.Lector["idmarca"];

                    lista.Add(aux);

                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
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
