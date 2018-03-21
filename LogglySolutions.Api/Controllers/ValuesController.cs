using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Collections.Generic;

namespace LogglySolutions.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Log.Information("Log: Log.Information");
            Log.Warning("Log: Log.Warning");
            Log.Error("Log: Log.Error");
            Log.Fatal("Log: Log.Fatal");

            return new [] { "value1", "value2" };
        }
    }
}
