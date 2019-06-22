using FSE.Assignment21.MVCClient.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace FSE.Assignment21.MVCClient.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetJobs()
        {
            return View("Index", new List<Job>());
        }
        public ActionResult GetJobsByRole()
        {
            var role = Request.Form["role"];
            return View("Index", new List<Job>());
        }
    }
}