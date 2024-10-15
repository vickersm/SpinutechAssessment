using Microsoft.AspNetCore.Mvc;

namespace SpinutechAssessment.Controllers
{
    public class NumericConverterController : Controller
    {
        [HttpGet]
        public IActionResult OnGet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnPost()
        {
            throw new System.NotImplementedException();
        }
    }
}