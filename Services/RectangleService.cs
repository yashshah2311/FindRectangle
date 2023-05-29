using FindRectangle.Data;
using FindRectangle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindRectangle.Services
{
    public class RectangleService : IRectangleService
    {
        private readonly IDataRepository _dataRepository;

        public RectangleService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public List<Rectangle> SearchRectangles(Coordinate[] coordinates)
        {
            return _dataRepository.GetRectanglesWithinCoordinates(coordinates);
        }
    }
}
