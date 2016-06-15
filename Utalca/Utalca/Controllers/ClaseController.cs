using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Utalca.Controllers
{
    public class ClaseController : Controller
    {
        // GET: Clase
        public ActionResult Index(long idCurso, DateTime fechaClase)
        {
            var servicio = new ControlAsistencia.ControlAsistenciaClient();
            var curso = servicio.Curso(idCurso);
            foreach(var clase in curso.Horario)
            {
                if (clase.Fecha.Equals(fechaClase)) { return View(clase); }
            }
            return View();
        }
    }
}
