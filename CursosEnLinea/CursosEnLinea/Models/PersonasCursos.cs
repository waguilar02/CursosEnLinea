using System;
using System.Collections.Generic;

namespace CursosEnLinea.Models
{
    public partial class PersonasCursos
    {
        public long? IdPersona { get; set; }
        public int? IdCurso { get; set; }

        public virtual Cursos IdCursoNavigation { get; set; }
        public virtual Personas IdPersonaNavigation { get; set; }
    }
}
