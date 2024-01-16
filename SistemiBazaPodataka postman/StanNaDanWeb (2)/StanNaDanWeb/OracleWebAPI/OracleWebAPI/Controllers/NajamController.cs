using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StanNaDanLibrary;
using StanNaDanLibrary.DTOs;
using StanNaDanv2;
using System;
using System.Collections.Generic;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class NajamController : ControllerBase
    {
        // GET: /Najam/SviNajmoviAgenta/{matbr_agenta}
        [HttpGet]
        [Route("SviNajmoviAgenta/{matbr_agenta}")]
        public IActionResult GetSviNajmoviAgenta(string matbr_agenta)
        {
            try
            {
                List<NajamView> najmovi = DataProvider.vratiNajmoveAgentaNotNull(matbr_agenta);
                return new JsonResult(najmovi);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        // GET: /Najam/SviNajmovi
        [HttpGet]
        [Route("SviNajmovi")]
        public IActionResult GetSviNajmovi()
        {
            try
            {
                List<NajamView> najmovi = DataProvider.vratiSveNajmove();
                return new JsonResult(najmovi);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // POST: /Najam/CreateNajam
        [HttpPost]
        [Route("CreateNajam/{agencijaID}/{agentMatBr}/{nekretninaID}/{poslovnicaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult CreateNajam([FromRoute(Name ="agencijaID")]int agencijaID,
            [FromRoute(Name ="agentMatBr")]string agentMatBr,
            [FromRoute(Name ="nekretninaID")]int nekretninaID,
            [FromRoute(Name ="poslovnicaID")]int poslovnicaID,
            [FromBody] NajamView najam)
        {
            try
            {
                var nekretnina = DataProvider.vratiNekretninu(nekretninaID);
                var poslovnica = DataProvider.vratiPoslovnicu(poslovnicaID);
                var agencija = DataProvider.vratiAgenciju(agencijaID);
                var agent = DataProvider.vratiAgenta(agentMatBr);
                najam.IznajmljenaNekretnina = nekretnina;
                najam.Agencija = agencija;
                najam.IznajmilaPoslovnica = poslovnica;
                najam.Agent = agent;
                DataProvider.dodajNajam(najam);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // PUT: /Najam/UpdateNajam
        [HttpPut]
        [Route("UpdateNajam/{najamID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult UpdateNajam([FromRoute(Name ="najamID")]int najamID, [FromBody] NajamView najam)
        {
            try
            {
                najam.NajamId = najamID;
                NajamView updatedNajam = DataProvider.azurirajNajam(najam);
                return Ok(updatedNajam);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // GET: /Najam/{id}
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetNajam(int id)
        {
            try
            {
                NajamView najam = DataProvider.vratiNajam(id);
                if (najam == null)
                    return NotFound();
                return Ok(najam);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // DELETE: /Najam/DeleteNajam/{id}
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpDelete]
        [Route("DeleteNajam/{id}")]
        public IActionResult DeleteNajam(int id)
        {
            try
            {
                DataProvider.obrisiNajamIzSistema(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // GET: /Najam/SviNajmoviAgencije/{agencijaId}

        [HttpGet]
        [Route("SviNajmoviPregledAgencije/{agencijaId}")]
        public IActionResult GetSviNajmoviAgencije(int agencijaId)
        {
            try
            {
                AgencijaView agencija = DataProvider.vratiAgenciju(agencijaId);
                if (agencija == null)
                    return NotFound();

                List<NajamView> najmovi = DataProvider.vratiSveNajmovePregledAgencije(agencija);
                return new JsonResult(najmovi);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
