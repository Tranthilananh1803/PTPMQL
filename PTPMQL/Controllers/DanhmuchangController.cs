using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTPMQL.Models;
namespace PTPMQL.Controllers
{
    [Table("DMHs")]

    public class DanhmuchangController : Controller
    {
        PTPMQLdbContext db = new PTPMQLdbContext();
        // GET: Danhmuchang
        public ActionResult Index()
        {
            return View(db.Danhmuchang.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}