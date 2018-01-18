using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamSourceControlProject.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult AddMember()
        {
            return View();
        }
    }
}