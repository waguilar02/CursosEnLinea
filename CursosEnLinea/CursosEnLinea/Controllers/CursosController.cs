using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CursosEnLinea.Models.Request;
using CursosEnLinea.Models.Response;
using CursosEnLinea.Models;
using Microsoft.EntityFrameworkCore;

namespace CursosEnLinea.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {

            Respuesta oRespuesta = new Respuesta();

            try
            {
                using (CursosOnlineContext db = new CursosOnlineContext())
                {

                    var lst = db.Cursos.ToList();
                    oRespuesta.Exito = 1;
                    oRespuesta.Data = lst;

                }


            }
            catch (Exception ex)
            {

                oRespuesta.Mensaje = ex.Message;

            }
            return Ok(oRespuesta);


        }


        [HttpPost]
        public IActionResult GetAdd(CursosRequest oModel) /* interface para consulta parametrizada e inserción de datos nuevos*/
        {

            Respuesta oRespuesta = new Respuesta();

            try
            {


                using (CursosOnlineContext db = new CursosOnlineContext())
                {   /*Creacion del contexto*/
                    // var lst = db.Personas.ToList(); //
                    // lst = null;



                    switch (oModel.tiposolicitud)
                    {
                        case 1:

                            oRespuesta.Data = db.Cursos.ToList();
                            oRespuesta.Mensaje = "Lista Cursos sin ordenar";
                            break;
                        case 2:
                            oRespuesta.Data = db.Cursos.OrderBy(l => l.NombreCurso).ToList();//lst
                            oRespuesta.Mensaje = "Lista de Cursos ordenada por Nombre Curso";
                            break;
                        case 3:
                            Cursos oCursos3 = new Cursos();
                            oCursos3 = db.Cursos.Find(oModel.IdCurso);
                            oRespuesta.Data = db.Personas.Find(oModel.IdCurso);
                            if (oRespuesta.Data == null)
                            {
                                oRespuesta.Mensaje = "Registro Curso No existe";

                            }
                            else
                            {
                                oRespuesta.Mensaje = "Registro por Id de Curso";
                            }

                            break;


                        case 4:
                            
                            var lst = db.Rangos_Edad.FromSqlRaw("EXEC SP_RANGO_PERSONAS_POR_EDAD").ToList();
                            
                             oRespuesta.Data = lst;
                            if (oRespuesta.Data == null)
                            {
                                oRespuesta.Mensaje = "Proc alm No existe";

                            }
                            else
                            {
                                oRespuesta.Mensaje = "Proc ALm Ejecutado";
                            }

                            break;

                        case 5:

                            Cursos oCursos5 = new Cursos(); /*Creamos un objeto de la (clase-Tabla) Alumnos */
                            oCursos5.IdCurso = oModel.IdCurso;
                            oCursos5.NombreCurso = oModel.NombreCurso;
                            oCursos5.Modalidad = oModel.Modalidad;
                            oCursos5.Duracion = oModel.Duracion;
                            oCursos5.TipoCurso = oModel.Categoria;
                            oCursos5.Categoria = oModel.LineaCarrera;
                            db.Cursos.Add(oCursos5); /*agregamos el objeto oAlumnos a la Base de datos*/
                            db.SaveChanges(); /*Guardamos los cambios realizados*/
                            oRespuesta.Mensaje = "Registro Curso ingresado correctamente";
                            break;

                        case 6:
                            oRespuesta.Data = db.Cursos.OrderBy(l => l.TipoCurso).ToList();//lst
                            oRespuesta.Mensaje = "Lista de Cursos ordenada por Edad.";

                            break;


                        case 7:

                            var lst2 = db.Rangos_Genero.FromSqlRaw("EXEC SP_RANGO_PERSONAS_POR_GENERO").ToList();

                            oRespuesta.Data = lst2;
                            if (oRespuesta.Data == null)
                            {
                                oRespuesta.Mensaje = "Proc alm No existe";

                            }
                            else
                            {
                                oRespuesta.Mensaje = "Proc ALm Ejecutado";
                            }

                            break;
                        default:
                            oRespuesta.Mensaje = "tiposolicitud Inválido";
                            break;

                    }

                    oRespuesta.Exito = 1;
                    //  oRespuesta.Data = lst;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);



        }








    }
}