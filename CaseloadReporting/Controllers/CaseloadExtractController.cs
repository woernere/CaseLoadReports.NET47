using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Threading.Tasks;
using CaseloadReporting.Controllers;

namespace CaseloadReporting.Controllers
{
    public class CaseloadExtractController : Controller
    {
        // GET: CaseloadExtract
        public ActionResult Index()
        {
            return View();
        }
    }
}