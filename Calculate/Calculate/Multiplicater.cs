﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate
{
    class Multiplicater : IBinaryOperation
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument * secondArgument;
            return result.ToString();
        }
    }
}

