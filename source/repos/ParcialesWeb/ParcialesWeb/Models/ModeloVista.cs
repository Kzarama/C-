using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcialesWeb.Models
{
    public class EstPromAcumulado
    {
        public string Nombre { get; set; }
        public double Promedio { get; set; }
    }
    public class Lista
    {
        public string Materia { get; set; }
        public int Semestre { get; set; }
        public int Grupo { get; set; }
        public IEnumerable<string> Estudiantes { get; set; }
    }

}
