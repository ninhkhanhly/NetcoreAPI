using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        // public IActionResult Index()
        // {
        //     return View();
        // }
        public IActionResult Index(Employee E1)
        {
            string strOutput = "xin chao " + E1.manhanvien + " - " + E1.Tennhanvien + " - " + E1.Tuoi + "-" + E1.luong;
            ViewBag.infoEmployee = strOutput;
            return View();
        }
    }
}