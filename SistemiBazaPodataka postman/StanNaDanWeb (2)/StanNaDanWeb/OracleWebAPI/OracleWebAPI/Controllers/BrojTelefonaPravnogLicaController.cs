using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StanNaDanLibrary.DTOs;
using StanNaDanv2;
using StanNaDanLibrary;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class BrojTelefonaPravnogLicaController: ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiBrTelPravnogLica/{idPravnogLica}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetBrTelPravnogLica(int idPravnogLica)
        {
            try
            {
                return new JsonResult(DataProvider.VratiBrojeveTelefonaP(idPravnogLica));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
      
        [HttpPost]
        [Route("DodajBrTelPravnogLica/{PravnoLiceID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajBrTelPravnogLica([FromBody] IDBrTelPLView brtel, int PravnoLiceID)
        {
            try
            {

                //prosledjuje mi nulu jer ne znam kroz query kako da napravim 
                var pravnoLice = DataProvider.vratiPravnoLice(PravnoLiceID);
                DataProvider.dodajbrojpl(pravnoLice, brtel);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiBrojevePravnogLica/{broj}")]
        public IActionResult ObrisiBrojevePravnogLica(int broj)
        {
            try
            {
                DataProvider.obrisibrojP(broj);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }

}

