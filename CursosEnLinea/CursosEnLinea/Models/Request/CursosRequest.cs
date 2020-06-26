using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursosEnLinea.Models.Request
{
    public class CursosRequest
    {

        //Tipo de solicitud y campos tabla cursos
        public int tiposolicitud { get; set; }
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public int? Modalidad { get; set; }
        public string Duracion { get; set; }
        public int? TipoCurso { get; set; }
        public int? Categoria { get; set; }
        public int? LineaCarrera { get; set; }


    }
}
