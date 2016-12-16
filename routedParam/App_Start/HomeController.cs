using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace routedParam.App_Start
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? id)
        {
            
            ViewBag.contador = id;
            return View();
        }

        /// <summary>
        /// Coge el contador de la ruta y saca el contador y nos lo muestra en el route data
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Index")]
        public ActionResult IndexPost(int? id)
        {
            int contador = 1;
            if (id != null)
            {
                contador = (int)id + 1;
            }
            return RedirectToAction("Index", new { id = contador });
        }
    }
}