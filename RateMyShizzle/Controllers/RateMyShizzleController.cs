using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.Core.Logging;
using log4net;

namespace RateMyShizzle.Controllers
{
    public class RateMyShizzleController : Controller
    {
        public static readonly ILog Logger = LogManager.GetLogger(typeof (RateMyShizzleController));
        //
        // GET: /RateMyShizzle/
        [Authorize]
        public ActionResult Index()
        {
            var name = User.Identity.Name;
            ViewBag.UserName = name;
            //Get user polls and add to viewbag
            Logger.InfoFormat("name: {0}",name);
            return View();
        }

    }
}
