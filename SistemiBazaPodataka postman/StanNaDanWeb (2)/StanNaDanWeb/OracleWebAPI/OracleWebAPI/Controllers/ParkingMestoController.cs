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
    public class ParkingMestoController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiParkingMesta")]
        public IActionResult GetParkingMesta()
        {
            try
            {
                return new JsonResult(DataProvider.vratiParkingMesta());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiParkingMesto/{mestoID}")]
        public IActionResult GetParkingMesto(int mestoID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiParkingMesto(mestoID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajParkingMestoNekretnini/{nekretninaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddParkingMesto([FromRoute(Name ="nekretninaID")]int nekretninaID,[FromBody] ParkingMestoView mesto)
        {
            try
            {
                var nekretnina = DataProvider.vratiNekretninu(nekretninaID);
                mesto.TipDodatka = "ParkingMesto";
                mesto.nekretnina = nekretnina;
                DataProvider.sacuvajParkingMesto(mesto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmenaParkingMesta/{parkingID}")]
        public IActionResult UpdateParkingMesto([FromRoute(Name ="parkingID")]int parkingID, [FromBody] ParkingMestoView mesto)
        {
            try
            {
                mesto.ParkingMestoId = parkingID;
                DataProvider.azurirajParkingMesto(mesto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiParkingMesto/{id}")]
        public IActionResult DeleteParkingMesto(int id)
        {
            try
            {
                DataProvider.obrisiParkingMesto(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}
