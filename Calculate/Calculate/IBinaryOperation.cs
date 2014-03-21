using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate
{
   public interface IBinaryOperation
   {
       string Calculate(double firstArgument, double secondArgument);

   }
}
