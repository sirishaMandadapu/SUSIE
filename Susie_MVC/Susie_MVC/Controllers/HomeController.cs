using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Susie_MVC.Models;
namespace Susie_MVC.Controllers
{
    public class HomeController : Controller
    {
        MVCEntities objMvc = new MVCEntities();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string name,string pwd,string gender)
        {
           
            name = Request.Form[0].ToString();
            pwd = Request.Form[1].ToString();
            gender = Request.Form[2].ToString();
           int i= objMvc.SpInsert(name, pwd);
            return View();
        }

        public ActionResult Registeration()
        {
            return View();
        }
    }
}
