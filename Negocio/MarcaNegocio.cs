using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List <Marca> listar()
        {
            List <Marca> lista = new List<Marca> ();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("Select Descripcion, Id from MARCAS");
                datos.EjecutarLectura();

                while(datos.Lector.Read())
                {
                    Marca aux = new Marca();

                    aux.id = (int)datos.Lector["Id"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];

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

    }
}
