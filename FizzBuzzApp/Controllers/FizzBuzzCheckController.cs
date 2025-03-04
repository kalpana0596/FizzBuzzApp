using FizzBuzzApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzCheckController : ControllerBase
    {
        IFizzBuzzService fizzBuzzServices = null;
        public FizzBuzzCheckController(IFizzBuzzService _fizzBuzzServices)
        {
            fizzBuzzServices = _fizzBuzzServices;
        }

        [HttpPost]
        public IActionResult CheckFizzBuzz([FromBodyAttribute] object[] inputValues)
        {
            var result = fizzBuzzServices.CheckFizzBuzz(inputValues);
            return Ok(result);
        }
    }
}
