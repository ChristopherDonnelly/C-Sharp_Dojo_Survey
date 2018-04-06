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
            TempData["name"] = name;
            TempData["location"] = location;
            TempData["language"] = language;
            TempData["comment"] = comment;
            return RedirectToAction("result");
        }

        [HttpGet]
        [Route("result")]
        public IActionResult Result()
        {
			ViewBag.name = TempData["name"];
            ViewBag.location = TempData["location"];
            ViewBag.language = TempData["language"];
            ViewBag.comment = TempData["comment"];

            return View();
        }
    }
}