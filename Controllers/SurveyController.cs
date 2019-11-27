using Microsoft.AspNetCore.Mvc;
using dojo_survey_with_model.Models;
namespace dojo_survey_with_model.Controllers
{
    public class SurveyController : Controller
    {
        [HttpPost("process")]
        public IActionResult Process (Survey survey)
        {
            return RedirectToAction("Result", survey);
        }

        [HttpGet("result")]
        public IActionResult Result(Survey survey)
        {
            return View(survey);
        }
    }
}