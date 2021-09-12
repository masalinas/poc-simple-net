using System;
using System.Threading;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;

using poc_net_simple.Models;

namespace poc_net_simple.Controllers
{
    [ApiController]    
    public class GreetingController : ControllerBase
    {
        private readonly ILogger<GreetingController> _logger;

        public GreetingController(ILogger<GreetingController> logger)
        {
            _logger = logger;
        }

        [HttpGet("greeting/{name}")]
        public Greeting Get(String name = "World")
        {            
            return new Greeting(1, name);
        }
    }
}