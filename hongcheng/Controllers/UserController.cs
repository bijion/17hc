using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hongcheng.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Summary()
        {
            return View();
        }

        public ActionResult ScoreHistory()
        {
            return View();
        }

        public ActionResult AllMember()
        {
            return View();
        }
        public ActionResult InfoList()
        {
            return View();
        }
    }
}