using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Utalca.Controllers
{
    public class ProfesorController : Controller
    {
        // GET: Profesor
        public ActionResult Index()
        {
            var profesores = Servicio.DatosProfesor.Profesores();
            return View(profesores);
        }


        public ActionResult Detalles(long id)
        {
            var servicio = new ControlAsistencia.ControlAsistenciaClient();
            var profesores = Servicio.DatosProfesor.Profesores();
            var profesor = profesores[0];
            if (id%2==0)
            {
                profesor = profesores[0];
            }
            else if(id % 3 == 0)
            {
                profesor = profesores[1];
            }
            else if (id % 5 == 0)
            {
                profesor = profesores[2];
            }
            else
            {
                profesor = profesores[3];
            }
            profesor.Cursos = servicio.CursosPorProfesor(id);
            if (profesor != null)
            {
                return View("Detalles", profesor);
            }
            else
            {
                return View("ProfesorNoEncontrado", "Profesor");
            }
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Models.Profesor p)
        {
            var profesores = Servicio.DatosProfesor.Profesores();
            if(profesores.Any(m => m.Nombre == p.Nombre))
            {
                Utils.MensajesUI.SetError("Ya existe un usuario con ese nombre");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Servicio.DatosProfesor.Profesores().Add(p);
                return RedirectToAction("Index", "Profesor");
            }
            
        }
    }
}