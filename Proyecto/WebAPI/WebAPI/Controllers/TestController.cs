using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persistence;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly ILogger<TestController> _logger;
        private readonly RRHHContext _db;

        public TestController(ILogger<TestController> logger, RRHHContext db)
        {
            _db = db;
            _logger = logger;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var tiposContenidos = _db.TiposContenido.ToList();
            
            return Ok(tiposContenidos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [HttpGet]
        [Route("Error")]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}