using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA_HERENCIA
{
    internal class DVSN : OP
    {

        public double dividir() 
        {
            return V1 / V2; 
        }

        public double dividir(double V1, double V2)
        {
            return V1 / V2;
        }
    }
}
