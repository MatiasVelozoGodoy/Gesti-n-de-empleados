using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class PersonaNegocio
    {
        private Conexiones data = new Conexiones();

        public List<Persona> listar()
        {
            List<Persona> lista = new List<Persona>();
            try
            {
                data.setearConsulta("select P.Id, P.DNI, P.Nombres, P.Apellidos, P.Edad, P.Descripcion,P.IdProfesion, T.Descripcion Profesion, P.Activo from PERSONAS P, PROFESIONES T where P.IdProfesion = T.Id");
                data.ejecutarLectura();
                while (data.Lector.Read())
                {
                    Persona aux = new Persona();
                    aux.Id = (int)data.Lector["Id"];
                    aux.DNI = (int)data.Lector["DNI"];
                    aux.Nombres = (string)data.Lector["Nombres"];
                    aux.Apellidos = (string)data.Lector["Apellidos"];
                    aux.Edad = (int)data.Lector["Edad"];
                    aux.Descripcion = (string)data.Lector["Descripcion"];
                    aux.Profesion = new Profesiones();
                    aux.Profesion.Id = (int)data.Lector["IdProfesion"];
                    aux.Profesion.Descripcion = (string)data.Lector["Profesion"];

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
