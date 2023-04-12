using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // add get api that returns true
        [HttpGet]
        public bool Get()
        {
            return true;
        }



    }
}
