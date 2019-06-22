using FSE.Assignment21.MVCClient.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FSE.Assignment21.MVCClient.Controllers
{
    public class JobController : Controller
    {
        public ActionResult Index()
        {
            var jobs = new List<Job>();
            return View(jobs);
        }
        public ActionResult GetJobs()
        {
            JobServiceReference.JobServiceClient client =
                new JobServiceReference.JobServiceClient("httpJobService");
            var result = client.OpeningJobs();
            var model = result.Select(x => new Job
            {
                Id = x.JobId,
                Role = x.JobRole,
                Description = x.JobDescription,
                Experience = x.Experience,
                Venue = x.Location

            }).ToList();

            return View("Index", model);
        }
        [HttpPost]
        public ActionResult GetJobsByRole()
        {
            var role = Request.Form["role"];
            JobServiceReference.JobServiceClient client =
                new JobServiceReference.JobServiceClient("tcpJobService");
            var result = client.OpeningJobsByRole(role);
            var model = result.Select(x => new Job
            {
                Id = x.JobId,
                Role = x.JobRole,
                Description = x.JobDescription,
                Experience = x.Experience,
                Venue = x.Location

            }).ToList();

            return View("Index", model);
        }
    }
}