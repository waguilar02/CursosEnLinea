using System;
using System.Collections.Generic;

namespace CursosEnLinea.Models
{
    public partial class Cursos
    {
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public int? Modalidad { get; set; }
        public string Duracion { get; set; }
        public int? TipoCurso { get; set; }
        public int? Categoria { get; set; }
        public int? LineaCarrera { get; set; }

        public virtual Categorias CategoriaNavigation { get; set; }
        public virtual LineaCarrera LineaCarreraNavigation { get; set; }
        public virtual Modalidades ModalidadNavigation { get; set; }
        public virtual TiposDeCurso TipoCursoNavigation { get; set; }
    }
}
