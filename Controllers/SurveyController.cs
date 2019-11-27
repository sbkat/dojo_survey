using Microsoft.AspNetCore.Mvc;
using dojo_survey.Models;

namespace survey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("submit")]
        public IActionResult SubmitForm(Survey yourSurvey)
        {
            return RedirectToAction("Result", yourSurvey);
        }
        [HttpGet("result")]
        public ViewResult Result(Survey yourSurvey)
        {
            return View(yourSurvey);
        }
    }
}