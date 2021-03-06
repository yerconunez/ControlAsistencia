﻿using System;
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
        public bool Get(Utalca.Models.Asistencia value)
        {
            var servicio = new ControlAsistencia.ControlAsistenciaClient();
            return servicio.RegistrarAsistencia(value.IDParticipante, value.IDCurso, value.fechaClase);           
        }

        // GET api/<controller>/5
        public Utalca.ControlAsistencia.Curso Get(int id)
        {
            var servicio = new ControlAsistencia.ControlAsistenciaClient();
            var curso = servicio.Curso(id);
            return curso;
        }

        // POST api/<controller>
        public void Post([FromBody]Utalca.Models.Asistencia value)
        {
            var servicio = new ControlAsistencia.ControlAsistenciaClient();
            servicio.RegistrarAsistencia(value.IDParticipante,value.IDCurso,value.fechaClase);
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