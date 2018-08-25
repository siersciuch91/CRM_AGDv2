using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM_AGD.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      Startup.CheckModule = Enum.Module.None;

      return View();
    }

    public ActionResult About()
    {
      Startup.CheckModule = Enum.Module.None;

      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      Startup.CheckModule = Enum.Module.None;

      ViewBag.Message = "Your contact page.";

      return View();
    }

    public ActionResult ChangeSubMenu(Enum.Module module)
    {
      Startup.CheckModule = module;
      return View("Index");
    }
  }
}