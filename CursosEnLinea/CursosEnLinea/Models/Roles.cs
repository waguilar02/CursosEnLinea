using System;
using System.Collections.Generic;

namespace CursosEnLinea.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Personas = new HashSet<Personas>();
        }

        public int IdRol { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Personas> Personas { get; set; }
    }
}
