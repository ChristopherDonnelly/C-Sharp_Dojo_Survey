using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace DojoSurvey.Controllers
{
    public class DojoSurveyController : Controller
    {

	    [HttpGet]
        [Route("")]
        [Route("index")]
        [Route("home")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("SubmitMessage")]
        public IActionResult SubmitMessage(string name, string location, string language, string comment)
        {
            return RedirectToAction("result", new { name = name, location = location, language = language, comment = comment });
        }

        [HttpGet]
        [Route("result")]
        public IActionResult Result(string name, string location, string language, string comment)
        {
			ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;

            return View();
        }
    }
}