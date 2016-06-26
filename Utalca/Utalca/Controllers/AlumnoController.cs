using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Utalca.Controllers
{
    public class AlumnoController : Controller
    {
        
       
        public ActionResult Detalles(string nombre)
        {
            var alumno = new Models.Alumno();
            alumno.Nombre = nombre;
            return View(alumno);
        }
    }
}