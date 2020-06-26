using System;
using System.Collections.Generic;

namespace CursosEnLinea.Models
{
    public partial class Categorias
    {
        public Categorias()
        {
            Cursos = new HashSet<Cursos>();
        }

        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cursos> Cursos { get; set; }
    }
}
