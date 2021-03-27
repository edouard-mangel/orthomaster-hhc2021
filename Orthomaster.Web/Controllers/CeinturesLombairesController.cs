using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orthomaster.Web.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CeinturesLombairesController : ControllerBase
    {
        private readonly ILogger<CeinturesLombairesController> _logger;

        public CeinturesLombairesController(ILogger<CeinturesLombairesController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<JsonResult> Search([FromBody] CeintureLombaireQueryDTO ceintureLombaireQueryDTO)
        {
            _logger.LogInformation($"Received : {ceintureLombaireQueryDTO}");
            
            return new JsonResult(new { Name = "Nom du produit", Supplier = "Supplier", Rating = 5});
        }
    }
}
