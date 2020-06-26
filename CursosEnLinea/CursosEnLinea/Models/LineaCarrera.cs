using System;
using System.Collections.Generic;

namespace CursosEnLinea.Models
{
    public partial class LineaCarrera
    {
        public LineaCarrera()
        {
            Cursos = new HashSet<Cursos>();
        }

        public int IdLineaCarrera { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cursos> Cursos { get; set; }
    }
}
