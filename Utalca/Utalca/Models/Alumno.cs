using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utalca.Models
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        public Alumno()
        {
            Biografia = "Sabio y sofisticado de gran fuerza y lealtad. También era un habilidoso mecánico. Chewbacca, como muchos wookiees, podía entender básico, pero no podía hablarlo debido a la estructura vocal de su especie. En vez de eso él hablaba en shyriiwook, el idioma wookiee principal, compuesto en su gran mayoría de gruñidos, a sus compañeros que no eran wookies, que normalmente hablaban básico. ";
        }

       
    }
}