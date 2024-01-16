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
    public class KucaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiKuce/{agencijaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiKuce(int agencijaID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveKuceAgencije(agencijaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiKuceVlasnika/{vlasnikID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiKuceVlasnika(int vlasnikID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveKuceVlasnika(vlasnikID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajKucu/{vlasnikID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajKucu([FromBody]KucaView kuca,int vlasnikID)
        {
            try
            {
                var vlasnik = DataProvider.vratiVlasnika(vlasnikID);
                kuca.vlasnik = vlasnik;
                DataProvider.sacuvajKucu(kuca);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmeniKucu")]
        public IActionResult IzmeniKucu([FromBody] KucaView kuca)
        {
            try
            {
                DataProvider.izmeniKucu(kuca);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiKucu/{id}")]
        public IActionResult ObrisiKucu(int id)
        {
            try
            {
                DataProvider.obrisiKucu(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


    }
}
