using Microsoft.AspNetCore.Mvc;
using Wati.Api.Models;

namespace Wati.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddController : ControllerBase
    {
        private readonly AddContext _context;
        public AddController(AddContext addContext)
        {
            _context = addContext;
            _context.Database.EnsureCreated();
        }
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
            Addition data = new Addition{
                Num1= num1,
                Num2= num2,
                Sum= sum 
            };
            _context.AddNumbers.Add(data);
            _context.SaveChanges();
            return Ok(sum);
        }
    }
}
