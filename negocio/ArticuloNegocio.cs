using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
			List<Articulo> lista = new List<Articulo>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
                datos.setearConsulta("Select Codigo, Nombre From ARTICULOS");
                datos.ejecutarLectura();
                while (datos.SqlDataReader.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codigo = (string)datos.SqlDataReader["Codigo"];
                    aux.nombre = (string)datos.SqlDataReader["Nombre"];

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
