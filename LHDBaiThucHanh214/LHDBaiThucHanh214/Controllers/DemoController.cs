using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LHDBaiThucHanh214.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Demo()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult Demo(string Masinhvien, string HoTenSinhVien)
        {
            ViewBag.Thongtin = Masinhvien + " " + HoTenSinhVien;
            return View();
        }
    }
}