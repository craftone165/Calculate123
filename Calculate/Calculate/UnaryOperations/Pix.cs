﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class Pix : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Pow(Math.PI,firstArgument);
            return result;
        }
    }
}
