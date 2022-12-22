using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebsite.Controllers
{
    public class CalculatorController : Controller
    {
        
        public IActionResult Index(string firstNum, string secondNum, string Cal)
        {
            int a = Convert.ToInt32(firstNum);
            int b = Convert.ToInt32(secondNum);
            int c = 0;
            switch (Cal)
            {
                case "Add":
                    c = a + b;
                    break;
                case "Sub":
                    c = a - b;
                    break;
                case "Mul":
                    c = a * b;
                    break;
                case "Div":
                    c = a / b;
                    break;
            }
            ViewBag.Result = c;
            return View();

        }
       
    }
}
