using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers{
    public class HeloworldController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}