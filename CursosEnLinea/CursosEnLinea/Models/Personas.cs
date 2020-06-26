using System;
using System.Collections.Generic;

namespace CursosEnLinea.Models
{
    public partial class Personas
    {
        public long NumeroIdentificacion { get; set; }
        public int? Rol { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int? Genero { get; set; }
        public string LugarNacimiento { get; set; }
        public int? Edad { get; set; }
        public string Hobbies { get; set; }

        public string Estado { get; set; }
        public virtual Genero GeneroNavigation { get; set; }
        public virtual Roles RolNavigation { get; set; }
    }
}
