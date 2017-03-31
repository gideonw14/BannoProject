using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult PullHtml()
    {
      ViewBag.Message = "Here you can pull the HTML from a site and view data about it. (Default is banno.com)";
      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Contact Me";

      return View();
    }
    
  }
}