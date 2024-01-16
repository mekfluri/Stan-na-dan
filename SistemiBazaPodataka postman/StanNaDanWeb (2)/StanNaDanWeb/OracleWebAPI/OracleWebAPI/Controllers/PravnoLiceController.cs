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
    public class PravnoLiceController: ControllerBase
    {

        [HttpGet]
        [Route("PreuzmiPravnaLicaVlasnika/{idvlasnika}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPravnaLica(int idvlasnika)
        {
            try
            {
                return new JsonResult(DataProvider.VratiPravnoLice(idvlasnika));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmeniPravnoLice")]
        public IActionResult IzmeniPravnoLice([FromBody] PravnoLiceView pravnolice)
        {
            try
            {
                DataProvider.azurirajPravnoLice(pravnolice);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [HttpPost]
        [Route("DodajPravnoLice/{vlasnikID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajPravnoLice([FromBody] PravnoLiceView pravnolice, int vlasnikID)
        {
            try
            {
                var vlasnik = DataProvider.vratiVlasnika(vlasnikID);
                DataProvider.dodajPravnoLice(pravnolice, vlasnik);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiPravnoLice/{id}")]
        public IActionResult ObrisiPravnolice(int id)
        {
            try
            {
                DataProvider.obrisiPravnoLice(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }



    }


}
