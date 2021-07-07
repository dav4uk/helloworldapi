using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        // GET
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"Hello World"};
        }
    }
}