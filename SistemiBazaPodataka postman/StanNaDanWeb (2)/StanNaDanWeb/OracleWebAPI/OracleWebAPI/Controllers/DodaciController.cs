using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StanNaDanLibrary;


namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class DodaciController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiDodatke")]
        public IActionResult GetDodaci()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveDodatkePregled());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiDodatak/{dodatakID}")]
        public IActionResult GetDodatak(int dodatakID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiDodatak(dodatakID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiDodatak/{id}")]
        public IActionResult DeleteDodatak(int id)
        {
            try
            {
                DataProvider.obrisiDodatak(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("VratiDodatkeNekretnine/{nekretninaID}")]
        public IActionResult GetDodaciForNekretnina(int nekretninaID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiDodatkeNekretnine(nekretninaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
