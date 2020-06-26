using System;
using System.Collections.Generic;

namespace CursosEnLinea.Models
{
    public partial class Genero
    {
        public Genero()
        {
            Personas = new HashSet<Personas>();
        }

        public int TipoGenero { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Personas> Personas { get; set; }
    }
}
