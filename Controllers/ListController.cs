using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {

        [HttpPost]
        public IActionResult ReceiveEmail([FromBody] EmailRequest request)
        {
            // Do something with the email address
            string emailAddress = request.Mail;
            JsonObject response = new JsonObject();
            response["mail"] = emailAddress; // set the 'mail' field in the JSON response

            return Ok(response);
        }
    }


    public class EmailRequest
    {
        public string Mail { get; set; }
    }
}