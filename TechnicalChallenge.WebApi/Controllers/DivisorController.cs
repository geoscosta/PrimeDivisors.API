using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DivisorLibrary;
using System.Threading.Tasks;

namespace TechnicalChallenge.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisorController : ControllerBase
    {
        private readonly ILogger<DivisorController> _logger;

        public DivisorController(ILogger<DivisorController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Technical Challenge
        /// </summary>
        /// <remarks>
        ///     {
        ///         "entryNumber": 45
        ///     }
        /// </remarks>
        /// <param name="entryNumber">number received and used to find its divisors and primes</param>
        /// <returns>List of divisors and primes</returns>
        /// <response code="200">Success</response>
        /// <response code="400">invalid parameter</response>
        [HttpPost]
        public ActionResult<DivisorParameter> Post([FromBody] DivisorParameter parameter)
        {
            if (ModelState.IsValid)
            {
                var result = Divisor.GetPrimesAndDivisorsNumbers(parameter);
                return result;
            }
            return BadRequest(ModelState);
        }
    }
}