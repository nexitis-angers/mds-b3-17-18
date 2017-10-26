using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereApplication
{
    public static class MathHelper
    {

        public static int Additionner(this int a, int b)
        {
            return a + b;
        }

        public static int Additionner(params int[] values)
        {
            int total = 0;

            foreach (var item in values)
            {
                total += item;
            }

            return total;
        }



    }
}
