using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class OperasBas
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Res { get; set; }   
        public int button { set; get; }

        public double Suma () 
        {
            return this.Num1 + this.Num2;
        }

        public double Resta()
        {
            return this.Num1 - this.Num2;
        }

        public double Mult()
        {
            return this.Num1 * this.Num2;
        }

        public double Dividir()
        {
            return this.Num1 / this.Num2;
        }
        public double operaciones()
        {
            double resul = 0;
            if (button == 1)
            {
                resul = Suma();
            }

            if (button == 2)
            {
                resul = Resta();
            }

            if (button == 3)
            {
                resul = Mult();
            }
            if (button == 4)
            {
                resul = Dividir();
            }
            return resul;
        }
    }
}