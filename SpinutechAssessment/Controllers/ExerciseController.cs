using Microsoft.AspNetCore.Mvc;

namespace SpinutechAssessment.Controllers
{
    public class ExerciseController : Controller
    {
        [Route("Exercise/1")]
        public IActionResult Prob1() => View();
        [Route("Exercise/2")]
        public IActionResult Prob2() => View();
        [Route("Exercise/3")]
        public IActionResult Prob3() => View();
        [Route("Exercise/4")]
        public IActionResult Prob4() => View();
        [Route("Exercise/5")]
        public IActionResult Prob5() => View();
        [Route("Exercise/6")]
        public IActionResult Prob6() => View();
    }
}
