using FindRectangle.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindRectangle.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthCheckController : ControllerBase
    {
        private readonly IHealthCheckService _healthCheckService;

        public HealthCheckController(IHealthCheckService healthCheckService)
        {
            _healthCheckService = healthCheckService;
        }

        [HttpGet("application")]
        public IActionResult CheckApplicationHealth()
        {
            var applicationHealth = _healthCheckService.CheckApplicationHealth();
            return Ok(applicationHealth);
        }

        [HttpGet("database")]
        public IActionResult CheckDatabaseHealth()
        {
            var databaseHealth = _healthCheckService.CheckDatabaseHealth();
            return Ok(databaseHealth);
        }
    }
}
