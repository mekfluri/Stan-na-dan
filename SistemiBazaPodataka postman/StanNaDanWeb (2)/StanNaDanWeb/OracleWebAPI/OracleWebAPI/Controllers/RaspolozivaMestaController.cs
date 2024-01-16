using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StanNaDanv2;
using StanNaDanLibrary.DTOs;
using StanNaDanLibrary;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class RaspolozivaMestaController: ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiMesta/{idnekretnine}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiMesta(int idnekretnine)
        {
            try
            {
                return new JsonResult(DataProvider.vratiMesta(idnekretnine));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiMesto/{naziv}")]
        public IActionResult ObrisiMesto(string naziv)
        {
            try
            {
                DataProvider.obrisiMesto(naziv);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


       
        [HttpPost]
        [Route("DodajMesto/{nekretninaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajMesto([FromBody] RaspolozivaMestaNekretnineView mesto, int nekretninaID)
        {
            try
            {

                
                DataProvider.dodajRaspolozivoMesto(nekretninaID, mesto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

    }
}
