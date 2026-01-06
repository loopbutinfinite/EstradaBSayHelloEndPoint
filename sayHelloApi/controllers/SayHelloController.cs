using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sayHelloApi.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpGet]
        [Route("Greeting/{userName}")]
        public string Greeting(string userName)
        {
            return $"Hello, {userName}!";
        }
    }
}