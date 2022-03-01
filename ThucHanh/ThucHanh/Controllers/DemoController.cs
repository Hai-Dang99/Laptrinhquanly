using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThucHanh.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            ViewBag.Message = "";
            return View();
        }
        public ActionResult Demo()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Masinhvien, string HoTenSinhVien)
        {
            ViewBag.Thongtin = Masinhvien + " " + HoTenSinhVien;
            return View();
        }
    }
}