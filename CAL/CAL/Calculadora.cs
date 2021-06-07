using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAL
{
    class Calculadora
    {
        private double numero1;
        private double numero2;

        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }


        public double Sumar()
        {
            return Numero1 + Numero2;
        }

        public double Restar()
        {
            return Numero1 - Numero2;
        }

        public double Multiplicar ()
        {
            return Numero1 * Numero2;
        }

        public double Dividir()
        {
           
                return Numero1 / Numero2;
       

        }
           



    }





}
