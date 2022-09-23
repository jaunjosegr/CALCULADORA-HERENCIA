using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA_HERENCIA
{
    internal class OP
    {
        private double v1;
        private double v2;
        private double resultado;

        public double V1
        {
            get { return v1; }
            set { v1 = value; }
        }
        public double V2
        {
            get { return v2; }
            set { v2 = value; } 
        } 

        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }  
        }
    }
}
