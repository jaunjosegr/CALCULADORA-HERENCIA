﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA_HERENCIA
{
    internal class SUMA : OP
    {
        public double operar(double V1, double V2)
        {
          
            return V1 + V2;
           
        }
        public double operar()
        {
            return V1 + V2;
        }

       
        

    }
}
