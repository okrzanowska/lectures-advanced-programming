using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CalculatorController : ControllerBase
{
    [HttpGet("add")]
    public ActionResult<int> Add(int a, int b)
    {
        return Ok(a + b);
    }
}
