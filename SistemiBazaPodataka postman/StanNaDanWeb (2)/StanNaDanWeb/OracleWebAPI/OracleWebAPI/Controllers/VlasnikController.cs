using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StanNaDanv2;
using StanNaDanLibrary;
using StanNaDanLibrary.DTOs;
using StanNaDanLibrary;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class VlasnikController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiVlasnike")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVlasnici()
        {
            try
            {
                return new JsonResult(DataProvider.vratiVlasnike());
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiVlasnikaAgencije/{idagencije}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult vratiVlasnikaAgencije(int idagencije)
        {
            try
            {
                return new JsonResult(DataProvider.vratiVlasnika(idagencije));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmeniVlasnika")]
        public IActionResult IzmeniVlasnika([FromBody] VlasnikView vlasnik)
        {
            try
            {
                DataProvider.azurirajVlasnika(vlasnik);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


        [HttpPost]
        [Route("DodajVlasnika/{agencijaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajVlasnika([FromBody] VlasnikView vlasnik, int agencijaID)
        {
            try
            {
                var agencija = DataProvider.vratiAgenciju(agencijaID);
                //vlasnik.AgencijaB = agencija;
                DataProvider.dodajVlasnika(vlasnik, agencija);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiVlasnika/{id}")]
        public IActionResult ObrisiVlasnika(int id)
        {
            try
            {
                DataProvider.obrisiVlasnika(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }




    }
}
