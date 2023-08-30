using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana01
{
    public class Persona
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public int Edad { get; set; }

        public string RetornarNombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        public bool EsMayorEdad()
        {
            return Edad > 18;
        }
    }

    public class Empleado: Persona
    {
        public double sueldo { get; set; }

        public double CalcularImpuesto()
        {
            return sueldo * 0.08;
        }
    }
}
