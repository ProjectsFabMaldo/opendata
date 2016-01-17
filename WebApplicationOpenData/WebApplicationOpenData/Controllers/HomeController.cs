using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationOpenData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UsoApiEventos()
        {
            ViewBag.Message = "Consumimos la API de los proximos eventos del Ayuntamiento de Madrid.";

            return View();
        }

        public ActionResult UsoApiWfi()
        {
            ViewBag.Message = "Consumimos la API de los puntos wifis disponibles del Ayuntamiento de Madrid.";

            return View();
        }

        public ActionResult QueSonDatosAbiertos()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult CaracteristicasOD()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult AperturaOD()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}