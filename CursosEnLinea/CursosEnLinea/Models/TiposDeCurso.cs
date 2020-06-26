using System;
using System.Collections.Generic;

namespace CursosEnLinea.Models
{
    public partial class TiposDeCurso
    {
        public TiposDeCurso()
        {
            Cursos = new HashSet<Cursos>();
        }

        public int IdTipoCurso { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cursos> Cursos { get; set; }
    }
}
