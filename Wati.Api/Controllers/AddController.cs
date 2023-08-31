using Microsoft.AspNetCore.Mvc;
using Wati.Api.Models;

namespace Wati.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddController : ControllerBase
    {
        /// <summary>
        /// Adds two numbers
        /// </summary>
        /// <param name="request">Two integer numbers</param>
        /// <returns>Sum of the input</returns>
        [HttpPost]
        public IActionResult Add([FromBody] RequestData request)
        {
            int num1 = request.Num1;
            int num2 = request.Num2;
            int sum = num1 + num2;
            return Ok(sum);
        }
    }
}
