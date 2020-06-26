using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursosEnLinea.Models.Request
{
    public class PersonasRequest
    {
        //Tipo de solicitud y campos tabla personas
        public int tiposolicitud { get; set; }
        public long NumeroIdentificacion { get; set; }
        public int? Rol { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int? Genero { get; set; }
        public string LugarNacimiento { get; set; }
        public int? Edad { get; set; }
        public string Hobbies { get; set; }
        public string Estado { get; set; }
    }
}
