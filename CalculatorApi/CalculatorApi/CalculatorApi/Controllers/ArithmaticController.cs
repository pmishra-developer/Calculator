using CalculatorApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ArithmaticController : ControllerBase
{
    private readonly ILogger<ArithmaticController> _logger;
    private readonly ICalculatorService _calculatorService;

    public ArithmaticController(ILogger<ArithmaticController> logger, ICalculatorService calculatorService)
    {
        _logger = logger;
        _calculatorService = calculatorService;
    }


    [HttpGet("Addition")]
    public IActionResult Add([FromQuery] int[] numbers)
    {
        var result = _calculatorService.AddNumbers(numbers);
        return Ok(new {Result = result});
    }

    [HttpGet("Subtraction")]
    public IActionResult Subtract([FromQuery] int[] numbers)
    {
        var result = _calculatorService.SubtractNumbers(numbers);
        return Ok(new { Result = result });
    }

    [HttpGet("Multiplication")]
    public IActionResult Multiply([FromQuery] int[] numbers)
    {
        var result = _calculatorService.MultiplyNumbers(numbers);
        return Ok(new { Result = result });
    }

    [HttpGet("Division")]
    public IActionResult Division([FromQuery] int[] numbers)
    {
        try
        {
            var result = _calculatorService.DivideNumbers(numbers);
            return Ok(new { Result = result });
        }
        catch (DivideByZeroException ex)
        {
            return BadRequest(new { Error = ex.Message });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { Error = ex.Message });
        }
    }

    [HttpGet("SquareRoot")]
    public IActionResult SquareRoot([FromQuery] int number)
    {
        try
        {
            var result = _calculatorService.SquareRoot(number);
            return Ok(new { Result = result });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { Error = ex.Message });
        }
    }

    [HttpGet("Power")]
    public IActionResult Power([FromQuery] int number, [FromQuery] int power)
    {
        var result = _calculatorService.Power(number, power);
        return Ok(new { Result = result });
    }

    [HttpGet("Factorial")]
    public IActionResult Factorial([FromQuery] int number)
    {
        try
        {
            var result = _calculatorService.Factorial(number);
            return Ok(new { Result = result });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { Error = ex.Message });
        }
    }

    [HttpGet("Percentage")]
    public IActionResult Percentage([FromQuery] int number, [FromQuery] int total)
    {
        try
        {
            var result = _calculatorService.Percentage(number, total);
            return Ok(new { Result = result });
        }
        catch (DivideByZeroException ex)
        {
            return BadRequest(new { Error = ex.Message });
        }
    }

    [HttpGet("Modulus")]
    public IActionResult Modulus([FromQuery] int number, [FromQuery] int divisor)
    {
        try
        {
            var result = _calculatorService.Modulus(number, divisor);
            return Ok(new { Result = result });
        }
        catch (DivideByZeroException ex)
        {
            return BadRequest(new { Error = ex.Message });
        }
    }

}