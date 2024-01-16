using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StanNaDanv2.Entiteti;
using StanNaDanv2;
using StanNaDanLibrary;
using StanNaDanLibrary.DTOs;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class SpoljniSaradnikController : ControllerBase
    {
        // GET: /SpoljniSaradnik/{matbr_agenta}/{broj_telefona}
        [HttpGet("VratiSpoljnogSardnika/{matbr_agenta}/{broj_telefona}")]
        public IActionResult GetSpoljniSaradnik(string matbr_agenta, string broj_telefona)
        {
            try
            {
                SpoljniSaradnikID id = new SpoljniSaradnikID
                {
                    UnajmioAgent = new Agent { maticni_broj_zaposlenog = matbr_agenta },
                    BrojTelefona = broj_telefona
                };

                SpoljniSaradnikView spoljniSaradnik = DataProvider.vratiSpoljnogSaradnika(id);
                if (spoljniSaradnik != null)
                    return new JsonResult(spoljniSaradnik);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // POST: /SpoljniSaradnik
        [HttpPost("AzurirajSaradnika/{matbr_agenta}/{broj_telefona}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult CreateSpoljniSaradnik([FromRoute (Name ="matbr_agenta")]string matbr_agenta,
            [FromRoute (Name ="broj_telefona")]string broj_telefona,
            [FromBody] SpoljniSaradnikView spoljniSaradnikView)
        {
            try
            {
                spoljniSaradnikView.Id.BrojTelefona = broj_telefona;
                spoljniSaradnikView.Id.UnajmioAgent = DataProvider.vratiAgentaNeBasic(matbr_agenta);
                DataProvider.dodajSpoljnogSaradnika(spoljniSaradnikView);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // PUT: /SpoljniSaradnik/{matbr_agenta}/{broj_telefona}
        [HttpPut("IzmeniSpoljnogSaradnika/{matbr_agenta}/{broj_telefona}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult UpdateSpoljniSaradnik([FromRoute (Name ="matbr_agenta")]string matbr_agenta,[FromRoute (Name ="broj_telefona")] string broj_telefona, [FromBody] SpoljniSaradnikView spoljniSaradnikBasic)
        {
            try
            {
                SpoljniSaradnikID id = new SpoljniSaradnikID
                {
                    UnajmioAgent = DataProvider.vratiAgentaNeBasic(matbr_agenta),
                    BrojTelefona = broj_telefona
                };

                spoljniSaradnikBasic.Id = id;

                SpoljniSaradnikView updatedSpoljniSaradnik = DataProvider.izmeniSpoljnogSaradnika(spoljniSaradnikBasic);
                if (updatedSpoljniSaradnik != null)
                    return Ok(updatedSpoljniSaradnik.Ime);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // DELETE: /SpoljniSaradnik/{matbr_agenta}/{broj_telefona}
        [HttpDelete("ObrisiSpoljnogSaradnika/{matbr_agenta}/{broj_telefona}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]      
        public IActionResult DeleteSpoljniSaradnik([FromRoute(Name="matbr_agenta")]string matbr_agenta
            ,[FromRoute(Name ="broj_telefona")]string broj_telefona)
        {
            try
            {
                SpoljniSaradnikID id = new SpoljniSaradnikID
                {
                    UnajmioAgent = DataProvider.vratiAgentaNeBasic(matbr_agenta),
                    BrojTelefona = broj_telefona
                };

                DataProvider.obrisiSpoljnogSaradnika(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // GET: /SpoljniSaradnik/SviSpoljniSaradniciAgenta/{matbr_agenta}
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        [Route("SviSpoljniSaradniciAgenta/{matbr_agenta}")]
        public IActionResult GetSviSpoljniSaradniciAgenta(string matbr_agenta)
        {
            try
            {
                
                List<SpoljniSaradnikView> saradnici = DataProvider.vratiSveSpoljneSaradnikeAgenta(matbr_agenta);
                List<string> imena = new List<string>(); 
                foreach(SpoljniSaradnikView v in saradnici)
                {
                    string ime = v.Ime;
                    string broj_tel = v.Id.BrojTelefona;
                    imena.Add(ime + "  "+ broj_tel);             
                };
                return new JsonResult(imena);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
