using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LHDBaiThucHanh214.Models;

namespace LHDBaiThucHanh214.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Demo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Demo(Student5 std)
        {
            ViewBag.Thongtin = "Hello" + std.Student5ID + "-" + std.Student5Name;
            return View();
        }
    }
}