using Microsoft.AspNetCore.Mvc;
using MathCalculatorAPI.Interfaces;

namespace MathCalculatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] CalculatorRequest request)
        {
            var result = _calculatorService.Add(request.a, request.b);
            return Ok(result);
        }

        [HttpPost("subtract")]
        public IActionResult Subtract([FromBody] CalculatorRequest request)
        {
            var result = _calculatorService.Subtract(request.a, request.b);
            return Ok(result);
        }

        [HttpPost("multiply")]
        public IActionResult Multiply([FromBody] CalculatorRequest request)
        {
            var result = _calculatorService.Multiply(request.a, request.b);
            return Ok(result);
        }

        [HttpPost("divide")]
        public IActionResult Divide([FromBody] CalculatorRequest request)
        {
            var result = _calculatorService.Divide(request.a, request.b);
            return Ok(result);
        }
    }

    public class CalculatorRequest
    {
        public int a { get; set; }
        public int b { get; set; }
    }
}
