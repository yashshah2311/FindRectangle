using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using FindRectangle.Data;

namespace FindRectangle
{
    public static class DataSeeder
    {
        public static void SeedData(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<RectangleDbContext>();
                var dataRepository = scope.ServiceProvider.GetRequiredService<IDataRepository>();
                dataRepository.SeedData();
            }
        }
    }
}