using AjaxMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AjaxMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataService service;

        public HomeController( DataService service)
        {
            this.service = service;
        }

        [HttpGet("")]
        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/{id}")]
        [HttpGet("index/{id}")]
        public IActionResult ResponsePage(int id)
        {
            var model = service.GetMovieById(id);

            return PartialView("_ResponsPartial", model);
        }

        [HttpGet("json/{id}")]
        [HttpGet("index/json/{id}")]
        public IActionResult ResponseJsonPage(int id)
        {
            var model = service.GetMovieById(id);

            return Json(model);
            return PartialView("_ResponsPartial", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}