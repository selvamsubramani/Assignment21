using FSE.Assignment21.MVCClient.Models;
using System.Web.Mvc;

namespace FSE.Assignment21.MVCClient.Controllers
{
    public class SelfHostController : Controller
    {
        public ActionResult Index(SelfHost host)
        {
            if (host == null)
                host = new SelfHost();
            return View(host);
        }
        public ActionResult GetService(int id)
        {
            var host = new SelfHost { Source = "Self host Service call" };
            if (id == 1)
            {
                host.Source = "Http Call";
                using (var client = new SelfHostedServiceReference.SelfHostingServiceClient("BasicHttpBinding_ISelfHostingService"))
                {
                    host.SayHello = client.SayHello("Selvam");
                    host.TodayProgram = client.TodayProgram("Selvam");
                }
            }
            if (id == 2)
            {
                using (var client = new SelfHostedServiceReference.SelfHostingServiceClient("NetTcpBinding_ISelfHostingService"))
                {
                    host.SayHello = client.SayHello("Subramani");
                    host.TodayProgram = client.TodayProgram("Subramani");
                }
                host.Source = "Tcp Call";
            }
            return RedirectToAction("Index", host);
        }
    }
}