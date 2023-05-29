using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindRectangle.Services
{
    public interface IHealthCheckService
    {
        string CheckApplicationHealth();
        string CheckDatabaseHealth();
    }
}
