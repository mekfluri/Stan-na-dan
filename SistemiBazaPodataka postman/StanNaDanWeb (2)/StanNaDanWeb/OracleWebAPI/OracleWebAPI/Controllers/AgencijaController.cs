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
    public class AgencijaController:ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiAgencije")]
        public IActionResult GetAgencije()
        {
            try
            {
                return new JsonResult(DataProvider.vratiAgencije());
            }catch(Exception ex) {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiAgenciju/{agencijaID}")]
        public IActionResult VratiAgenciju(int agencijaID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiAgenciju(agencijaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajAgenciju")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajAgenciju([FromBody]AgencijaView agencija)
        {
            try
            {
                DataProvider.dodajAgenciju(agencija);
                return Ok();
            }catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmenaAgencije")]
        public IActionResult IzmenaAgencije([FromBody] AgencijaView agencija)
        {
            try
            {
                DataProvider.azurirajAgenciju(agencija);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiAgenciju/{id}")]
        public IActionResult ObrisiAgenciju(int id)
        {
            try
            {
                DataProvider.obrisiAgenciju(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }



    }
}
