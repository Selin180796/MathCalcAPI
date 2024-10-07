using Microsoft.AspNetCore.Mvc;
using MathCalculatorAPI.Interfaces;

namespace MathCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService<int> _calculatorService;

        public CalculatorController(ICalculatorService<int> calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet("add/{a}/{b}")]
        public IActionResult Add(int a, int b)
        {
            return Ok(_calculatorService.Add(a, b));
        }

        [HttpGet("subtract/{a}/{b}")]
        public IActionResult Subtract(int a, int b)
        {
            return Ok(_calculatorService.Subtract(a, b));
        }

        [HttpGet("multiply/{a}/{b}")]
        public IActionResult Multiply(int a, int b)
        {
            return Ok(_calculatorService.Multiply(a, b));
        }

        [HttpGet("divide/{a}/{b}")]
        public IActionResult Divide(int a, int b)
        {
            return Ok(_calculatorService.Divide(a, b));
        }
    }
}

