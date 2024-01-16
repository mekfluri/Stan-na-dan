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
    public class AgentController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiAgenteAgencije/{agencijaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiAgenteAgencije(int agencijaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveAgenteAgencije(agencijaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiAgentePoslovnice/{poslovnicaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiAgentePoslovnice(int poslovnicaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveAgentePoslovice(poslovnicaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
      
        [HttpGet]
        [Route("VratiAgenta/{agentID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult VratiAgenta(string agentID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiAgenta(agentID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajAgenta/{poslovnicaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajAgenta([FromBody] AgentView agent, int poslovnicaID)
        {
            try
            {
                var poslovnica = DataProvider.vratiPoslovnicu(poslovnicaID);
               agent.Poslovnica = poslovnica;
                DataProvider.DodajAgenta(agent);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("IzmeniAgenta")]
        public IActionResult IzmeniAgenta([FromBody] AgentView agent)
        {
            try
            {
                DataProvider.izmeniAgenta(agent);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiAgenta/{id}")]
        public IActionResult ObrisiAgenta(string id)
        {
            try
            {
                DataProvider.obrisiAgenta(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


    }
}
