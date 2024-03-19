using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(Person ps)
        {
            string strOutput = "xin chao" + ps.PersonId + "-" + ps.Fullname + "-" + ps.Address;
            ViewBag.infoPersion = strOutput;
            return View();
        }
    }
}