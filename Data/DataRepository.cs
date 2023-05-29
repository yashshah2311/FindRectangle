using FindRectangle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindRectangle.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly RectangleDbContext _context;

        public DataRepository(RectangleDbContext context)
        {
            _context = context;
        }

        public List<Rectangle> GetRectanglesWithinCoordinates(Coordinate[] coordinates)
        {
            return _context.Rectangles
                .Where(rectangle =>
                    coordinates.Any(coord =>
                        coord.X >= rectangle.X &&
                        coord.X <= rectangle.X + rectangle.Width &&
                        coord.Y >= rectangle.Y &&
                        coord.Y <= rectangle.Y + rectangle.Height))
                .ToList();
        }

        public void SeedData()
        {
            // Seed data logic
            if (!_context.Rectangles.Any())
            {
                Random rnd = new Random();

                // Seed 200 rectangle entries into the database
                for (int i = 0; i < 200; i++)
                {
                    var rectangle = new Rectangle
                    {
                        X = rnd.Next(1, 100),
                        Y = rnd.Next(1, 100),
                        Width = rnd.Next(1, 10),
                        Height = rnd.Next(1, 10)
                    };

                    _context.Rectangles.Add(rectangle);
                }

                _context.SaveChanges();
            }
        }
    }
}