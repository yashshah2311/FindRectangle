using FindRectangle.Models;
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
    public class RectanglesController : ControllerBase
    {
        private readonly IRectangleService _rectangleService;

        public RectanglesController(IRectangleService rectangleService)
        {
            _rectangleService = rectangleService;
        }

        [HttpPost]
        public IActionResult SearchRectangles([FromBody] Coordinate[] coordinates)
        {
            var rectangles = _rectangleService.SearchRectangles(coordinates);
            return Ok(rectangles);
        }
    }
}
