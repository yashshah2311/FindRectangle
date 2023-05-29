using FindRectangle.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindRectangle.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ConfigurationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public IActionResult SetConfiguration([FromBody] ConfigurationModel configuration)
        {
            // Validate and process the configuration object
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Update the configuration values
            _configuration[configuration.Key] = configuration.Value;

            return Ok();
        }
    }
}
