using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_1.Helpers
{
    public class Invertir
    {
        public static int nuevo(int b)
        {

            String B = null;
            B += b.ToString()[1];
            B += b.ToString()[0];

            return Convert.ToInt32(B);
        }
    }
}
