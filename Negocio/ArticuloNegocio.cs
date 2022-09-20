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

                datos.setearQuery("SELECT A.ID, A.IDMARCA, A.IDCATEGORIA,A.DESCRIPCION AS DESCRIPCION,CODIGO,NOMBRE, M.DESCRIPCION AS MARCADESCRIPCION, C.DESCRIPCION AS CATEGORIAC,IMAGENURL,PRECIO,M.ID AS IDMARC,C.ID AS IDCAT FROM ARTICULOS AS A LEFT JOIN MARCAS M ON A.IdMarca = M.ID LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.ID ");
                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();

                    aux.id = datos.Lector.GetInt32(0);
                    if (!(datos.Lector["CODIGO"] is DBNull))
                    {
                        aux.codigo = (string)datos.Lector["CODIGO"];
                    }

                    if (!(datos.Lector["NOMBRE"] is DBNull))
                        aux.Nombre = (string)datos.Lector["NOMBRE"];
                    if (!(datos.Lector["DESCRIPCION"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.marca = new Marca();
                    if (!(datos.Lector["MARCADESCRIPCION"] is DBNull))
                        aux.marca.descripcion = (string)datos.Lector["MARCADESCRIPCION"];
                    else
                        aux.marca.descripcion = "Sin marca";

                    aux.categoria = new Categoria();
                    if (!(datos.Lector["CATEGORIAC"] is DBNull))
                        aux.categoria.descripcion = (string)datos.Lector["CATEGORIAC"];
                    else
                        aux.categoria.descripcion = "Sin categoria";
                    
                    //if(!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("ImagenUrl"))))
                    //  aux.UrlImagen = (string)datos.Lector.GetString(5);

                    if (!(datos.Lector["IMAGENURL"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector.GetString(8);

                    if (!(datos.Lector["PRECIO"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["PRECIO"];
                    if (!(datos.Lector["IDCAT"] is DBNull) )
                    {
                        aux.categoria.cod = (int)datos.Lector["IDCAT"];
                    }
                    else
                    {
                        aux.categoria.cod = 0;
                    }

                    if (!(datos.Lector["IDMARC"] is DBNull))
                        aux.marca.id = (int)datos.Lector["IDMARC"];
                    else
                        aux.marca.id = 0;

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
                string consulta = "SELECT A.ID, A.IDMARCA,A.IDCATEGORIA,A.DESCRIPCION AS DESCRIPCION,CODIGO,NOMBRE,M.DESCRIPCION,C.DESCRIPCION,IMAGENURL,PRECIO,M.ID AS IDMARC,C.ID AS IDCAT FROM ARTICULOS AS A LEFT JOIN MARCAS M ON A.IdMarca = M.ID LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.ID WHERE ";

                switch (campo)
                {

                    case "Marca":////////////////////////////////////////////
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "M.DESCRIPCION like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "M.DESCRIPCION like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "M.DESCRIPCION like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Categoria"://///////////////////////////////////////////
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "C.DESCRIPCION like '" + filtro + "%'";
                                break;
                            case "Termina con":

                                
                                consulta += "C.DESCRIPCION like '%" + filtro + "'";
                                
                                break;
                            default:
                                consulta += "C.DESCRIPCION like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Precio":////////////////////////////////////////
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "PRECIO > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "PRECIO < " + filtro;
                                break;
                            default:
                                consulta += "PRECIO = " + filtro;
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
                    if (!(datos.Lector["CODIGO"] is DBNull))
                    {
                        aux.codigo = (string)datos.Lector["CODIGO"];
                    }

                    if (!(datos.Lector["NOMBRE"] is DBNull))
                        aux.Nombre = (string)datos.Lector["NOMBRE"];
                    if (!(datos.Lector["DESCRIPCION"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.marca = new Marca();
                    if (!(datos.Lector.GetString(6) is DBNull))
                        aux.marca.descripcion = (string)datos.Lector.GetString(6);
                    else
                        aux.marca.descripcion = "Sin marca";

                    aux.categoria = new Categoria();
                    if (!(datos.Lector.GetString(7) is DBNull))
                        aux.categoria.descripcion = (string)datos.Lector.GetString(7);
                    else
                        aux.categoria.descripcion = "Sin categoria";

                    //if(!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("ImagenUrl"))))
                    //  aux.UrlImagen = (string)datos.Lector.GetString(5);

                    if (!(datos.Lector["IMAGENURL"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector.GetString(8);

                    if (!(datos.Lector["PRECIO"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["PRECIO"];
                    if (!(datos.Lector["IDCAT"] is DBNull))
                    {
                        aux.categoria.cod = (int)datos.Lector["IDCAT"];
                    }
                    else
                    {
                        aux.categoria.cod = 0;
                    }

                    if (!(datos.Lector["IDMARC"] is DBNull))
                        aux.marca.id = (int)datos.Lector["IDMARC"];
                    else
                        aux.marca.id = 0;

                    //datos.cerrarConexion();
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
