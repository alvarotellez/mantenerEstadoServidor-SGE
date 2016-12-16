using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MantenerEstadoServidor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

    
        [HttpPost]
        public ViewResult Index(String boton, String txtNombre)
        {
            switch (boton)
            {

                case ("+ 1"):
                    Session["contador"] = Convert.ToInt32(Session["contador"]) + 1;
                    break;
                case ("Entrar"):
                    Session["nombreUsuario"] = txtNombre;
                    break;
                case ("Cerrar Sesion"):
                    Session.Clear();
                    Session.Abandon();
                    break;                    
            }
            return View();
        }
    }
}