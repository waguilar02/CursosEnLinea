using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursosEnLinea.Models;
using CursosEnLinea.Models.Request;
using CursosEnLinea.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CursosEnLinea.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasSPController : ControllerBase
    {


        [HttpPut]
        public IActionResult Edit(ConsultasSPRequest oModel) /* interface para consulta parametrizada e inserción de datos nuevos*/
        {

            Respuesta oRespuesta = new Respuesta();

            try
            {


                using (CursosOnlineContext db = new CursosOnlineContext())
                {   /*Creacion del contexto*/
                    // var lst = db.Personas.ToList(); //
                    // lst = null;

                    oRespuesta.Exito = 1;

                    switch (oModel.tiposolicitud)
                    {
                        case 1:

                            ConsultasSPRequest oConsulta = new ConsultasSPRequest();
                            // oRespuesta.Data = db.Personas.FromSqlRaw("EXEC SP_RANGO_PERSONAS_POR_EDAD").ToList();
                          
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

                        case 2:


                            ConsultasSPRequest oConsulta2 = new ConsultasSPRequest();
                           // oRespuesta.Data = db.Personas.FromSqlRaw("EXEC SP_RANGO_PERSONAS_POR_GENERO").ToList();
                            oRespuesta.Data = db.Database.ExecuteSqlCommand("EXEC SP_RANGO_PERSONAS_POR_GENERO");
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
                        default:
                            oRespuesta.Mensaje = "tiposolicitud Inválido";
                            oRespuesta.Exito = 0;
                            break;

                    }


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