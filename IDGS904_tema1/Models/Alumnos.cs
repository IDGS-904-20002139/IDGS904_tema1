using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Alumnos
    {
        public String nombre { get; set; }
        public int edad { get; set; }
        public bool activo { get; set; }
        public DateTime inscripto { get; set; }
    }
}