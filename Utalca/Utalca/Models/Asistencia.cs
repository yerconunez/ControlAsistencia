using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utalca.Models
{
    public class Asistencia
    {
        public long IDParticipante { get; set; }
        public long IDCurso { get; set; }
        public long fechaClase { get; set; }
    }
}