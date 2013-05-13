using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModel;

namespace RateMyShizzle.Controllers
{
    public class ControllerBase : Controller
    {
        public DatabaseDataContext DatabaseContext = new DatabaseDataContext();
    }
}