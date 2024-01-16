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
    public class BrojTelefonaFizickogLicaController: ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiBrTelFizickaLicaVlasnika/{idFizLica}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetBrTelFizickaLica(int idFizLica)
        {
            try
            {
                return new JsonResult(DataProvider.VratiBrojeveTelefona(idFizLica));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        
        [HttpPost]
        [Route("DodajBrTrlFizickoLice/{FizLiceID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajBrTrlFizickoLice([FromBody] IDBrTelFLView brtel, int FizLiceID)
        {
            try
            {   
                
                //prosledjuje mi nulu jer ne znam kroz query kako da napravim 
                var fizickoLice = DataProvider.vratiFizickoLice(FizLiceID);
                DataProvider.dodajbrojfl(fizickoLice, brtel);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiBrojeveFizickogLica/{broj}")]
        public IActionResult ObrisiFizickolice(int broj)
        {
            try
            {
                DataProvider.obrisibrojF(broj);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}
