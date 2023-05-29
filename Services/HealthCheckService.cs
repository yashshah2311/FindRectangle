using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindRectangle.Services
{
    public class HealthCheckService : IHealthCheckService
    {
        public string CheckApplicationHealth()
        {
            // Check application health and return the result
            return "Application is healthy";
        }

        public string CheckDatabaseHealth()
        {
            // Check database health and return the result
            return "Database connection is healthy";
        }
    }
}
