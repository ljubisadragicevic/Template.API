using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Template.Logic.Interface;
using Template.Logic.Model;

namespace Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly IClientLogic _clientLogic;

        public ClientController(
            ILogger<ClientController> logger,
            IClientLogic clientLogic)
        {
            _logger = logger;
            _clientLogic = clientLogic;
        }

        [HttpGet]
        [Route("Details")]
        [ProducesResponseType(typeof(ClientResponse), (int)HttpStatusCode.OK)]
        public IActionResult GetClient(int id)
        {
            return Ok(_clientLogic.GetClient(id));
        }
    }
}
