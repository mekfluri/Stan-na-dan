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
    public class SefController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSefaAgencije/{agencijaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiSefaAgencije(int agencijaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveSefoveAgencije(agencijaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSefaPoslovnice/{poslovnicaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiSefaPoslovnice(int poslovnicaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveSefovePoslovice(poslovnicaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiSefa/{sefID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult VratiSefa(string sefID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSefa(sefID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajSefa/{poslovnicaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajSefa([FromBody] SefView sef, int poslovnicaID)
        {
            try
            {
                var poslovnica = DataProvider.vratiPoslovnicu(poslovnicaID);
                sef.Poslovnica = poslovnica;
                DataProvider.DodajSefa(sef);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmeniSefa")]
        public IActionResult IzmeniSefa([FromBody] SefView sef)
        {
            try
            {
                DataProvider.izmeniSefa(sef);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiSefa/{id}")]
        public IActionResult ObrisiSefa(string id)
        {
            try
            {
                DataProvider.obrisiSefa(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


    }
}
