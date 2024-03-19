using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class SinhVienController : Controller
    {
        public IActionResult dulieu()
        {
            return View();
        }
        public IActionResult dulieu(SinhVien sv)
        {
            string strOutput = "xin chao" + sv.Hoten + "-" + sv.Diachi + "-" + sv.Tuoi + "-" + sv.Sodienthoai;
            ViewBag.dulieu = strOutput;
            return View();
        }
    }
}