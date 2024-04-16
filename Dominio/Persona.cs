using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public int DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos{ get; set; }
        public int Edad { get; set; }
        public string Descripcion { get; set; }
        public Profesiones Profesion { get; set; }
    }
}
