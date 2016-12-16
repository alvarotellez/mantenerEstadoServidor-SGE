using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MantenerEstadoServidor_Cookies.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            if (!Request.Cookies.AllKeys.Contains("contador"))
            {
                HttpCookie miCookie = new HttpCookie("contador", "0");
                miCookie.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(miCookie);

                ViewBag.contador = 0;
            }else
            {
                HttpCookie miCookie = Request.Cookies["contador"];
            }
            return View();
        }

        [HttpPost, ActionName("Index")]
        public ActionResult IndexPost()
        {

            HttpCookie miCookie = Request.Cookies["contador"];

            int contador = Convert.ToInt32(miCookie.Value);
            //Aumentar el contador para pasarlo a la vista y meterlo en la cookie
            contador = contador + 1;
            ViewBag.contador = contador;

            //Incrementar el valor de la cookie en el navegador del usuario

            miCookie.Value = Convert.ToString(contador);
            miCookie.Expires = DateTime.Now.AddDays(7);
            Response.SetCookie(miCookie);
            return View();
        }
    }
}