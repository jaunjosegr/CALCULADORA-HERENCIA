using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA_HERENCIA
{
    internal class MULTIPL : OP
    {

        public double mul() 
        { 
            return V1 * V2;
        }

        public double mul(double V1, double V2)
        {
            return V1 * V2;
        }


    }
}
