using FindRectangle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindRectangle.Services
{
    public interface IRectangleService
    {
        List<Rectangle> SearchRectangles(Coordinate[] coordinates);
    }
}
