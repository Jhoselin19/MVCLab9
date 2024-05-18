using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLab9.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        //Tiene por defecto [HHTO GET]
        //En layout esta el contenedor que sale en la pagina principal
        //@{
        //Layout = "";}, con esto puedes poner el layout que tu quieras para tu pagina

    public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
    }
}