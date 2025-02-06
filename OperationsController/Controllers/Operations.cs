using Microsoft.AspNetCore.Mvc;
using OperationsController.Models;
using System.Security.Cryptography.X509Certificates;

namespace OperationsController.Controllers
{
    public class Operations : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(int num1, int num2)
        {
            var model = new Parameters
            {
                Result = num1 + num2
            };
            return View("index",model);
        }
        public IActionResult Subtract(int num1, int num2)
        {
            var model = new Parameters
                { Result = num1 - num2 };
            return View("index",model);
        }

        public IActionResult Multiply(int num1, int num2)
        {
            var model =new Parameters
            { Result = num1 * num2 };
            return View("index", model);
        }

        public IActionResult Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                ModelState.AddModelError("Num2", "Error: Division by zero is not allowed.");
                return View("Index", new Parameters { Result = null });
            }

            var model = new Parameters { Result = num1 / num2 };
            return View("Index", model);
        }

    }
}
