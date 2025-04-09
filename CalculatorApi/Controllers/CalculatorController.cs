using Microsoft.AspNetCore.Mvc;

namespace Calculator.RestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public IActionResult Add(int a, int b) => Ok(a + b);

        [HttpGet("subtract")]
        public IActionResult Subtract(int a, int b) => Ok(a - b);
    }
}
