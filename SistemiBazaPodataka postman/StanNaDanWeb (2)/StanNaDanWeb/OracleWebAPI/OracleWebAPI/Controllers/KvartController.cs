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
    public class KvartController : ControllerBase
    {
        [HttpGet]
        [Route("VratiSveKvartove")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult VratiSveKvartove()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveKvartove());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("VratiKvart/{kvartID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult VratiKvart(int kvartID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiKvart(kvartID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajKvart/{poslovnicaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajKvart([FromBody] KvartView kvart,int poslovnicaID)
        {
            try
            {
                var poslovnica = DataProvider.vratiPoslovnicu(poslovnicaID);
                kvart.poslovnica = poslovnica;
               
                DataProvider.dodajKvart(kvart);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmeniKvart")]
        public IActionResult IzmeniKvart([FromBody] KvartView kvart)
        {
            try
            {
                DataProvider.izmeniKvart(kvart);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiKvart/{id}")]
        public IActionResult ObrisiKvart(int id)
        {
            try
            {
                DataProvider.obrisiKvart(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


    }
}
