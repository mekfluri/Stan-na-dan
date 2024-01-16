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
    public class StanController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiStanove/{agencijaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetStanovi(int agencijaID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveStanoveAgencije(agencijaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiStanoveVlasnika/{vlasnikID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiStanoveVlasnika(int vlasnikID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveStanoveVlasnika(vlasnikID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajStan/{vlasnikID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajStan([FromBody] StanView stan, int vlasnikID)
        {
            try
            {
                var vlasnik = DataProvider.vratiVlasnika(vlasnikID);
                stan.vlasnik = vlasnik;
                DataProvider.sacuvajStan(stan);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmeniStan")]
        public IActionResult IzmeniStan([FromBody] StanView stan)
        {
            try
            {
                DataProvider.izmeniStan(stan);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiStan/{id}")]
        public IActionResult ObrisiStan(int id)
        {
            try
            {
                DataProvider.obrisiStan(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


    }
}

