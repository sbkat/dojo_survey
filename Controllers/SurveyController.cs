using Microsoft.AspNetCore.Mvc;
using dojo_survey.Models;
using System.Diagnostics;

namespace survey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("Submit")]
        public IActionResult Submit(Survey yourSurvey)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result", yourSurvey);
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("result")]
        public ViewResult Result(Survey yourSurvey)
        {
            return View(yourSurvey);
        }
    }
}