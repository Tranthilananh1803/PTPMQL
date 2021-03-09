using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTPMQL.Models;
namespace PTPMQL.Controllers
{
    [Table("Nhomhangs")]
    public class NhomhangController : Controller
    {
        PTPMQLdbContext db = new PTPMQLdbContext();
        // GET: Nhomhang
        public ActionResult Index()
        {
            return View(db.Nhomhang.ToList());
        }
        public ActionResult Create()
        {
            return View();


        }
    }
}