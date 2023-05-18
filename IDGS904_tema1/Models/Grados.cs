using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI.WebControls.WebParts;

namespace IDGS904_tema1.Models
{
    public class Grados
    {
        public double centigrados { get; set; }
        public double fahrenheit { get; set; }
        public int radio { get; set; }
        public double result { get; set; }

        //Para convertir grados Fahrenheit a grados Celsius, puedes usar la siguiente fórmula:
        //T(°C) = (T(°F) - 32) × 5/9
        //Por lo tanto, si deseas convertir 1 grado Fahrenheit a grados Celsius, la conversión sería:
        //1°F = -17.2222°C

        public double calcularGrados()
        {
            if (radio == 1) 
            { 
                this.result = ((this.fahrenheit - 32) * (1 / 1.8));
            }
            if (radio == 2)
            {
                this.result = ((this.centigrados * 1.8) + 32);
            }
            return this.result;
        }
    }
}