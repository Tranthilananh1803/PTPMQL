using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTPMQL.Models;

namespace PTPMQL.Controllers
{
    public class KhachHangController : Controller
    {
        PTPMQLdbContext db = new PTPMQLdbContext();
        // GET: KhachHang
        public ActionResult Index()
        {
            return View(db.Khachhang.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}