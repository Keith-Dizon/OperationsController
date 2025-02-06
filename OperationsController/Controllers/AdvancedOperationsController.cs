using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [Route("AdvancedOperations")]
    public class AdvancedOperationsController : Controller
    {
        [HttpGet("Square/{num}")]
        public IActionResult Square(string num)
        {
            double number = double.TryParse(num, out double parsedNum) ? parsedNum : 0;
            double result = number * number;
            return Content($"Result: {result}");
        }

        [HttpGet("SquareRoot/{num}")]
        public IActionResult SquareRoot(string num)
        {
            double number = double.TryParse(num, out double parsedNum) ? parsedNum : 0;

            if (number < 0)
            {
                return Content("Error: Square root of a negative number is not allowed.");
            }

            double result = Math.Sqrt(number);
            return Content($"Result: {result}");
        }

        [HttpGet("Power/{baseNumber}/{exponent}")]
        public IActionResult Power(string baseNumber, string exponent)
        {
            double baseValue = double.TryParse(baseNumber, out double parsedBase) ? parsedBase : 0;
            double expValue = double.TryParse(exponent, out double parsedExp) ? parsedExp : 0;

            double result = Math.Pow(baseValue, expValue);
            return Content($"Result: {result}");
        }
    }
}
