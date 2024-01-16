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
    public class KuhinjaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiKuhinje")]
        public IActionResult GetKuhinje()
        {
            try
            {
                return new JsonResult(DataProvider.vratiKuhinje());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiKuhinju/{kuhinjaID}")]
        public IActionResult GetKuhinja(int kuhinjaID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiKuhinju(kuhinjaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajKuhinjuNekretnini/{nekretninaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddKuhinja([FromRoute (Name="nekretninaID")]int nekretninaID, [FromBody] KuhinjaView kuhinja)
        {
            try
            {
                var nekretnina = DataProvider.vratiNekretninu(nekretninaID);
                kuhinja.nekretnina = nekretnina;
                kuhinja.TipDodatka = "Kuhinja";
                DataProvider.sacuvajKuhinju(kuhinja);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmenaKuhinje/{kuhinjaID}")]
        public IActionResult UpdateKuhinja([FromRoute (Name ="kuhinjaID")]int kuhinjaID,[FromBody] KuhinjaView kuhinja)
        {
            try
            {
                kuhinja.KuhinjaId = kuhinjaID;
                DataProvider.azurirajKuhinju(kuhinja);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiKuhinju/{id}")]
        public IActionResult DeleteKuhinja(int id)
        {
            try
            {
                DataProvider.obrisiKuhinju(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}
