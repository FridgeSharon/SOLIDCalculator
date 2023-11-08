using Microsoft.AspNetCore.Mvc;
using SOLIDCalculator.Interfaces;
using SOLIDCalculator.Models;
using SOLIDCalculator.Services;

namespace SOLIDCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly InputDigesterService _inputDigester;
        private readonly ArithmeticCalculator _arithmeticCalculator;

        public CalculatorController(InputDigesterService inputDigester, ArithmeticCalculator arithmeticCalculator)
        {
            _inputDigester = inputDigester;
            _arithmeticCalculator = arithmeticCalculator;
        }


        [HttpPost(Name = "Calculate")]
        public IActionResult Calculate([FromBody] CalculationInputModel request)
        {
            IDigestedInput digestedInput = _inputDigester.DigestInput(request.Input);
            float answer = _arithmeticCalculator.Calculate(digestedInput);
            return Ok(answer);
        }
    }
}