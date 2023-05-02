using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public string Get(){
            return "Hello World";
        }
    }
}