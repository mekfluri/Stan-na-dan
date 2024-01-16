using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StanNaDanLibrary;
using StanNaDanLibrary.DTOs;
using StanNaDanv2;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class KrevetController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiKrevete")]
        public IActionResult GetKreveti()
        {
            try
            {
                return new JsonResult(DataProvider.vratiKrevete());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiKrevet/{krevetID}")]
        public IActionResult GetKrevet(int krevetID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiKrevet(krevetID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajKrevet/{nekretninaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddKrevetToNekretnina([FromRoute(Name = "nekretninaID")]int nekretninaID, [FromBody] KrevetView krevet)
        {
            try
            {
                var nekretnina = DataProvider.vratiNekretninu(nekretninaID);
                krevet.nekretnina = nekretnina;
                DataProvider.sacuvajKrevet(krevet);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmenaKreveta/{krevetID}")]
        public IActionResult UpdateKrevet([FromRoute(Name = "kuhinjaID")] int krevetID,[FromBody] KrevetView krevet)
        {
            try
            {
                krevet.KrevetId = krevetID;
                DataProvider.azurirajKrevet(krevet);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiKrevet/{id}")]
        public IActionResult DeleteKrevet(int id)
        {
            try
            {
                DataProvider.obrisiKrevet(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}
