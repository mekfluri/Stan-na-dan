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
    public class SajtController: ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSajtove/{idnekretnine}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiSajtove(int idnekretnine)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSajtove(idnekretnine));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiSajt/{naziv}")]
        public IActionResult ObrisiSajt(string naziv)
        {
            try
            {
                DataProvider.obrisiSajt(naziv);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


        
        [HttpPost]
        [Route("DodajSajt/{nekretninaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajSajt([FromBody] SajtNekretninaView sajt, int nekretninaID)
        {
            try
            {

                
                DataProvider.dodajSajt(nekretninaID, sajt);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


    }
}
