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

        public void agregar(Persona nuevo)
        {
            try
            {
                data.setearConsulta("insert into PERSONAS(DNI, Apellidos, Nombres, Edad, Descripcion, IdProfesion, Activo) values (@dni, @apellidos, @nombres, @edad, @descripcion, @idProfesion, 1)");
                data.limpiarParametros();
                data.setearParametro("@dni", nuevo.DNI);
                data.setearParametro("@apellidos", nuevo.Apellidos);
                data.setearParametro("@nombres", nuevo.Nombres);
                data.setearParametro("@edad", nuevo.Edad);
                data.setearParametro("@descripcion", nuevo.Descripcion);
                data.setearParametro("@idProfesion", nuevo.Profesion.Id);
                data.ejecutarAccion();
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
        public void modificar(Persona modifica)
        {
            try
            {
                data.setearConsulta("update PERSONAS set DNI = @dni, Apellidos = @apellidos, Nombres = @nombres, Edad = @edad, Descripcion = @desc, IdProfesion= @idProfesion where Id = @id");
                data.limpiarParametros();
                data.setearParametro("@dni", modifica.DNI);
                data.setearParametro("@apellidos", modifica.Apellidos);
                data.setearParametro("@nombres", modifica.Nombres);
                data.setearParametro("@edad", modifica.Edad);
                data.setearParametro("@desc", modifica.Descripcion);
                data.setearParametro("@idProfesion", modifica.Profesion.Id);
                data.ejecutarAccion();
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
