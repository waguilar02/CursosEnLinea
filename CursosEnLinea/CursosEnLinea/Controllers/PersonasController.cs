using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CursosEnLinea.Models;
using CursosEnLinea.Models.Response;
using CursosEnLinea.Models.Request;
using Microsoft.EntityFrameworkCore;

namespace CursosEnLinea.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {

            Respuesta oRespuesta = new Respuesta();

            try
            {
                using (CursosOnlineContext db = new CursosOnlineContext())
                {



                    var lst = db.Personas.ToList();
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
        public IActionResult GetAdd(PersonasRequest oModel) /* interface para consulta parametrizada e inserción de datos nuevos*/
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

                            oRespuesta.Data = db.Personas.ToList();
                            oRespuesta.Mensaje = "Lista sin ordenar";
                            break;
                        case 2:
                            oRespuesta.Data = db.Personas.OrderBy(l => l.Nombres).ToList();//lst
                            oRespuesta.Mensaje = "Lista de Personas ordenada por Nombre.";
                            break;
                        case 3:
                            Personas oPersonas3 = new Personas();
                            oPersonas3 = db.Personas.Find(oModel.NumeroIdentificacion);
                            oRespuesta.Data = db.Personas.Find(oModel.NumeroIdentificacion);
                            if (oRespuesta.Data == null)
                            {
                                oRespuesta.Mensaje = "Registro No existe";

                            }
                            else
                            {
                                oRespuesta.Mensaje = "Registro por Numero de Identificacion";
                            }

                            break;


                        case 4:
                            Personas oPersonas4 = new Personas();
                            var lst = db.Personas.FromSqlRaw("EXEC SP_RANGO_PERSONAS_POR_EDAD").ToList();
                            // oRespuesta.Data = lst;
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

                            Personas oPersonas = new Personas(); /*Creamos un objeto de la (clase-Tabla) Alumnos */
                            oPersonas.NumeroIdentificacion = oModel.NumeroIdentificacion;
                            oPersonas.Rol = oModel.Rol;

                            oPersonas.Nombres = oModel.Nombres;
                            oPersonas.Apellidos = oModel.Apellidos;
                            oPersonas.Genero = oModel.Genero;
                            oPersonas.LugarNacimiento = oModel.LugarNacimiento;
                            oPersonas.Edad = oModel.Edad;
                            oPersonas.Hobbies = oModel.Hobbies;
                            db.Personas.Add(oPersonas); /*agregamos el objeto oAlumnos a la Base de datos*/
                            db.SaveChanges(); /*Guardamos los cambios realizados*/
                            oRespuesta.Mensaje = "Registro ingresado correctamente";
                            break;

                        case 6:
                            oRespuesta.Data = db.Personas.OrderBy(l => l.Edad).ToList();//lst
                            oRespuesta.Mensaje = "Lista de Personas ordenada por Edad.";

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

        [HttpPut]
        public IActionResult Edit(PersonasRequest oModel) /* interface para consulta parametrizada e inserción de datos nuevos*/
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



                            Personas oPersonas = db.Personas.Find(oModel.NumeroIdentificacion);

                            oPersonas.NumeroIdentificacion = oModel.NumeroIdentificacion;
                            oPersonas.Rol = oModel.Rol;

                            oPersonas.Nombres = oModel.Nombres;
                            oPersonas.Apellidos = oModel.Apellidos;
                            oPersonas.Genero = oModel.Genero;
                            oPersonas.LugarNacimiento = oModel.LugarNacimiento;
                            oPersonas.Edad = oModel.Edad;
                            oPersonas.Hobbies = oModel.Hobbies;
                            db.Entry(oPersonas).State = Microsoft.EntityFrameworkCore.EntityState.Modified; /*agregamos el objeto oAlumnos a la Base de datos*/
                            db.SaveChanges(); /*Guardamos los cambios realizados*/
                            oRespuesta.Mensaje = "Registro Modificado correctamente";

                            break;

                        case 2:



                            Personas oPersonas2 = db.Personas.Find(oModel.NumeroIdentificacion);

                            oPersonas2.NumeroIdentificacion = oModel.NumeroIdentificacion;
                            oPersonas2.Rol = oModel.Rol;

                            oPersonas2.Nombres = oModel.Nombres;
                            oPersonas2.Apellidos = oModel.Apellidos;
                            oPersonas2.Genero = oModel.Genero;
                            oPersonas2.LugarNacimiento = oModel.LugarNacimiento;
                            oPersonas2.Edad = oModel.Edad;
                            oPersonas2.Hobbies = oModel.Hobbies;
                            oPersonas2.Estado = "Borrado";//oModel.Estado;
                            db.Entry(oPersonas2).State = Microsoft.EntityFrameworkCore.EntityState.Modified; /*agregamos el objeto oAlumnos a la Base de datos*/
                            db.SaveChanges(); /*Guardamos los cambios realizados*/
                            oRespuesta.Mensaje = "Registro Borrado correctamente";

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
