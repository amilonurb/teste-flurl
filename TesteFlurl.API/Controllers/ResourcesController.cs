using Microsoft.AspNetCore.Mvc;
using System.Net;
using TesteFlurl.Contracts.Services.Resources.GetList;

namespace TesteFlurl.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResourcesController : ControllerBase
    {
        private readonly IGetResourcesListService _getResourcesListService;

        public ResourcesController(IGetResourcesListService getResourcesListService) =>
            _getResourcesListService = getResourcesListService;

        /// <summary>
        /// Uso do Flurl por extension methods
        /// </summary>
        /// <param name="limit">Total de registros</param>
        [HttpGet("porExtensao")]
        [ProducesResponseType(typeof(NamedAPIResourceList), (int)HttpStatusCode.OK)]
        public IActionResult GetList([FromQuery] int limit) => Ok(_getResourcesListService.Execute(limit));
    }
}
