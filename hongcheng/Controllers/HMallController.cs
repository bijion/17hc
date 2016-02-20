using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hongcheng.Controllers
{
    public class HMallController : Controller
    {
        // GET: HMall
        public ActionResult Index()
        {
            return View();
        }

        // GET: HMall
        public ActionResult NewApply()
        {
            return View();
        }
    }
}