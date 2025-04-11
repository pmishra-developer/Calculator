using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ArithmaticController : ControllerBase
{
    private readonly ILogger<ArithmaticController> _logger;

    public ArithmaticController(ILogger<ArithmaticController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet(Name = "Add")]
    public int Addition(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }
}