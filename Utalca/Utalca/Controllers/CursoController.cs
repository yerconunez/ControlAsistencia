using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Utalca.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {
            var servicio = new ControlAsistencia.ControlAsistenciaClient();
            var cursos = servicio.Cursos();
            return View(cursos);
        }

        public ActionResult Details(long id)
        {
            var servicio = new ControlAsistencia.ControlAsistenciaClient();
            var curso = servicio.Curso(id);
            return View(curso);
        }
    }
}