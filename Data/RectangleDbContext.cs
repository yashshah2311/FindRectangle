using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FindRectangle.Models;

namespace FindRectangle.Data
{
    public class RectangleDbContext : DbContext
    {
        public RectangleDbContext(DbContextOptions<RectangleDbContext> options) : base(options)
        {
        }

        public DbSet<Rectangle> Rectangles { get; set; }
    }

}