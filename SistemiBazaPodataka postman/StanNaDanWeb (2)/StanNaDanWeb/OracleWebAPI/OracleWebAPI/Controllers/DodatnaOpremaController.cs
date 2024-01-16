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
    public class DodatnaOpremaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiDodatnuOpremu")]
        public IActionResult GetDodatnaOprema()
        {
            try
            {
                return new JsonResult(DataProvider.vratiDodatnuOpremu());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiDodatnuOpremu/{opremaID}")]
        public IActionResult GetDodatnaOprema(int opremaID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiDodatnuOpremu(opremaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajDodatnuOpremuNekretnini/{nekretninaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddDodatnaOprema([FromRoute(Name ="nekretninaID")]int nekretninaID, [FromBody] DodatnaOpremaView oprema)
        {
            try
            {
                var nekretnina = DataProvider.vratiNekretninu(nekretninaID);
                oprema.nekretnina = nekretnina;
                DataProvider.sacuvajDodatnuOpremu(oprema);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmenaDodatneOpreme/{dodatnaOpremaID}")]
        public IActionResult UpdateDodatnaOprema([FromRoute(Name = "dodatnaOpremaID")] int dodatnaOpremaID, [FromBody] DodatnaOpremaView oprema)
        {
            try
            {
                oprema.DodatnaOpremaId = dodatnaOpremaID;
                DataProvider.azurirajDodatnuOpremu(oprema);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiDodatnuOpremu/{id}")]
        public IActionResult DeleteDodatnaOprema(int id)
        {
            try
            {
                DataProvider.obrisiDodatnuOpremu(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}
