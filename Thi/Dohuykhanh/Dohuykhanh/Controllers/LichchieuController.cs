using Dohuykhanh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dohuykhanh.Controllers
{
    public class LichchieuController : Controller
    {
        // GET: Lichchieu
        Model1 data = new Model1();
        public ActionResult Khanh()
        {
            var all_phim = from s in data.LichChieux select s;
            return View(all_phim);
        }
    }
}