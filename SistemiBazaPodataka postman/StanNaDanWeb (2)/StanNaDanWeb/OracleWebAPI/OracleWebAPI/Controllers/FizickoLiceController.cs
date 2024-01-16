using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StanNaDanv2;
using StanNaDanLibrary;
using StanNaDanLibrary.DTOs;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class FizickoLiceController : ControllerBase
    {
       
        
        [HttpGet]
        [Route("PreuzmiFizickaLicaVlasnika/{idvlasnika}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetFizickaLica(int idvlasnika)
        {
            try
            {
                return new JsonResult(DataProvider.VratiFizickoLice(idvlasnika));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmeniFizickoLice")]
        public IActionResult IzmeniFizickoLice([FromBody] FizickoLiceView fizickolice)
        {
            try
            {
                DataProvider.azurirajFizickoLice(fizickolice);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [HttpPost]
        [Route("DodajFizickoLice/{vlasnikID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajFizickoLice([FromBody] FizickoLiceView fizikolice, int vlasnikID)
        {
            try
            {
                var vlasnik = DataProvider.vratiVlasnika(vlasnikID);
                DataProvider.dodajFizickoLice(fizikolice, vlasnik);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiFizickoLice/{id}")]
        public IActionResult ObrisiFizickolice(int id)
        {
            try
            {
                DataProvider.obrisiFizickoLice(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


    }
}
