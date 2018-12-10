using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQEjemplo.Models
{
    public class Registros
    {
        public string Carnet { get; set; }
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public int Promedio { get; set; }
        public string  Fecha { get; set; }

        public List<Registros> Alumnos()
        {
            var alumno1 = new Registros
            {
                Carnet = "CB17002",
                Nombre = "Angel",
                Materia = "Matemática",
                Promedio = 10,
                Fecha = "12/08/2018"
            };

            var alumno2 = new Registros
            {
                Carnet = "FA13012",
                Nombre = "Josue",
                Materia = "Ciencias",
                Promedio = 8,
                Fecha = "12/09/2017"
            };

            var alumno3 = new Registros
            {
                Carnet = "GF20893",
                Nombre = "Juana",
                Materia = "Sociales",
                Promedio = 6,
                Fecha = "15/09/2017"
            };

            return new List<Registros>(){
                alumno1, alumno2, alumno3
            };
        }
    }
}