using FindRectangle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindRectangle.Data
{
    public interface IDataRepository
    {
        List<Rectangle> GetRectanglesWithinCoordinates(Coordinate[] coordinates);
        void SeedData();
    }
}
