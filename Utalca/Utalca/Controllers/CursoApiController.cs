using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Utalca.Controllers
{
    public class CursoApiController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Utalca.ControlAsistencia.Curso> Get()
        {
            var servicio = new ControlAsistencia.ControlAsistenciaClient();
            var cursos = servicio.Cursos();
            return cursos;
        }

        // GET api/<controller>/5
        public Utalca.ControlAsistencia.Curso Get(int id)
        {
            var servicio = new ControlAsistencia.ControlAsistenciaClient();
            var curso = servicio.Curso(id);
            return curso;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
            var servicio = new ControlAsistencia.ControlAsistenciaClient();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}