using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProfesionNegocio
    {
        Conexiones data = new Conexiones();
        public List<Profesiones> listar()
        {
            List<Profesiones> lista = new List<Profesiones>();
            try
            {
                data.setearConsulta("Select Id, Descripcion from PROFESIONES");
                data.ejecutarLectura();
                while (data.Lector.Read())
                {
                    Profesiones aux = new Profesiones();
                    aux.Id = (int)data.Lector["Id"];
                    aux.Descripcion = (string)data.Lector["Descripcion"];
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
                data.cerrarConexion();
            }
        }
    }
}
