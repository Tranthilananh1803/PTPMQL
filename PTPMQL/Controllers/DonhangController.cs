using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTPMQL.Models;

namespace PTPMQL.Controllers
{
    [Table("Donhangs")]
    public class DonhangController : Controller
    {
        PTPMQLdbContext db = new PTPMQLdbContext();
        // GET: Donhang
        public ActionResult Index()
        {
            return View(db.Donhang.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}