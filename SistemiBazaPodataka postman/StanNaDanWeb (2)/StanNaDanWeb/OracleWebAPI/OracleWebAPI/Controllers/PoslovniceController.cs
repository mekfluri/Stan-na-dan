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
    public class PoslovniceController: ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPoslovnice/{idAgencije}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiPoslovnice(int idAgencije)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSvePoslovniceAgencije(idAgencije));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmeniPoslovnicu")]
        public IActionResult IzmeniPoslovnicu([FromBody] PoslovniceView poslovnica)
        {
            try
            {
                DataProvider.azurirajPoslovnicu(poslovnica);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        //ne radi
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiPoslovnicu/{id}")]
        public IActionResult ObrisiPoslovnicu(int id)
        {
            try
            {
                DataProvider.obrisiPoslovnicu(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


        [HttpPost]
        [Route("DodajPoslovnicu/{agencijaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajVlasnika([FromBody] PoslovniceView poslovnica, int agencijaID)
        {
            try
            {
                var agencija = DataProvider.vratiAgenciju(agencijaID);
                //vlasnik.AgencijaB = agencija;
                DataProvider.dodajPoslovnicu(poslovnica, agencija);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


    }
}
