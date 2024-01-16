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
    public class ZaposleniController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiZaposleneAgencije/{agencijaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiZaposleneAgencije(int agencijaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveZaposleneAgencije(agencijaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiZaposlenePoslovnice/{poslovnicaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiZaposlenePoslovnice(int poslovnicaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveZaposlenePoslovice(poslovnicaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("VratiZaposlene")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult VratiZaposlene()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveZaposlene());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("VratiZaposlenog/{zaposleniID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult VratiZaposlenog(string zaposleniID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiZaposlenog(zaposleniID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajZaposlenog/{poslovnicaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajZaposlenog([FromBody] SamoZaposleniView zaposleni, int poslovnicaID)
        {
            try
            {
                var poslovnica = DataProvider.vratiPoslovnicu(poslovnicaID);
                zaposleni.Poslovnica = poslovnica;
                DataProvider.dodajZaposlenog(zaposleni);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmeniZaposlenog")]
        public IActionResult IzmeniZaposlenog([FromBody] SamoZaposleniView zaposleni)
        {
            try
            {
                DataProvider.azurirajZaposlenog(zaposleni);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiZaposlenog/{id}")]
        public IActionResult ObrisiZaposlenog(string id)
        {
            try
            {
                DataProvider.obrisiZaposlenog(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


    }
}
