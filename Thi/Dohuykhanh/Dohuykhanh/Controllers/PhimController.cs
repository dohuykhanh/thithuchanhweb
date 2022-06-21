using Dohuykhanh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dohuykhanh.Controllers
{
    public class PhimController : Controller
    {
        // GET: Phim
        Model1 data = new Model1();
        public ActionResult Index()
        {
            
            
            
                var all_phim = from s in data.Phims select s;
                return View(all_phim);
            
        }
    }
}