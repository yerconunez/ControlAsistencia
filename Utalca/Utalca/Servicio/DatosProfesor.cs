using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utalca.Servicio
{
    public class DatosProfesor
    {
        public static List<Models.Profesor> Profesores()
        {
            var profesores = new List<Models.Profesor>();
            profesores.Add(new Models.Profesor() { ID = 1, Nombre = "Edgardo", Apellido = "Ortiz", Biografia = "Construyo software hace mas de 6 años en distintas empresas del sector privado en Chile.  Actualmente soy profesor de “Diseño de Software” y “Emprendimiento en la industria del software” en la Universidad de Talca. Paralelamente trabajo en proyectos de Lintu, ya sea mejorando las soluciones existentes o creando nuevas que ayuden a la comunidad. Si quieres ver más acerca de mi corta carrera profesional te invito a que revises mi perfil en LinkedIn. Profesor de: Diseño de Software, Metodologías de Desarrollo de Software, Tecnologías Web.", SitioWeb = "www.utalca.cl" , Rol = "Académico", Foto = "EO.jpg"});
            profesores.Add(new Models.Profesor() { ID = 2, Nombre = "Renzo", Apellido = "Anglez Rojas", Biografia = "Renzo Angles recibió su grado de Bachelor en Sistemas de Ingeniería de la Universidad Católica de Santa María (Arequipa, Perú) y su Ph.D. en Ciencias de la Computación de la Universidad de Chile. Desde el año 2010 es profesor asistente en el Departamento de Ciencias de la Computación de la Universidad de Talca (Chile). Su principal área de interés son la intersección entre bases de datos y Web Semántica, en particular grafos y bases de datos RDF.", SitioWeb = "www.utalca.cl", Rol = "Director de Departamento", Foto = "Renzo Angles.jpg" });
            profesores.Add(new Models.Profesor() { ID = 3, Nombre = "Rodolfo", Apellido = "Allendes", Biografia = "Ingeniero civil en Computación Universidad de Talca - Chile Integrated PhD and MSc in Multidisciplinary Informatics University of Leeds - United Kingdom", SitioWeb = "www.utalca.cl", Rol = "Académico", Foto = "Rodolfo Allendes.jpg" });
            profesores.Add(new Models.Profesor() { ID = 4, Nombre = "Matthew", Apellido = "Bardeen", Biografia = "Matthew Bardeen is the founder of the Aerial Robotics Lab. He graduated magna cum laude from Virginia Commonwealth University with a Bachelor of Science in Computer Science. He obtained his MSc. in Evolutionary and Adaptive Systems and his DPhil in Computer Science and Artificial Intelligence from University of Sussex in Brighton, England.", SitioWeb = "www.utalca.cl", Rol = "Académico", Foto = "Matthew Bardeen.jpg" });
            return profesores;
        }

    }
}