using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LINQEjemplo.Models;

namespace LINQEjemplo.Controllers
{
    public class HomeController : Controller
    {
        Registros R  = new Registros();
        // GET: Home
        public ActionResult Index()
        {

            var Listado = from p in R.Alumnos()
                          select p;
           
            return View(Listado);
        }
        [HttpPost]
        public ActionResult Index(string Busqueda,string filtro )
        {
            var Listado = from p in R.Alumnos()
                          select p;

            switch (filtro)
                {
                case "Materia":
                    var Listado1 = from p in R.Alumnos()
                                  where p.Materia.Contains(Busqueda)
                                  select p;

                    return View(Listado1);

                case "Nombre":
                    var Listado2 = from p in R.Alumnos()
                                   where p.Nombre.Contains(Busqueda)
                                   select p;

                    return View(Listado2);  
            }

            return View(Listado);
        }
    }
}