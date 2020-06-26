using System;
using System.Collections.Generic;

namespace CursosEnLinea.Models
{
    public partial class Modalidades
    {
        public Modalidades()
        {
            Cursos = new HashSet<Cursos>();
        }

        public int IdModalidad { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cursos> Cursos { get; set; }
    }
}
