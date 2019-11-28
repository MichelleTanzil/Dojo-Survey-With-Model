using Microsoft.AspNetCore.Mvc;
using dojo_survey_with_model.Models;
namespace dojo_survey_with_model.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost("process")]
        public IActionResult Process (Survey survey)
        {
            
            if (ModelState.IsValid)
            {
                return RedirectToAction("Result", survey);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("result")]
        public IActionResult Result(Survey survey)
        {
            return View(survey);
        }
    }
}