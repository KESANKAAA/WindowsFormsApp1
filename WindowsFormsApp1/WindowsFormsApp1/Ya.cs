using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Ya
    {
        public Ya((float,float)c11, (float, float)c12, (float, float) c21, (float, float) c22)
        {
            (float, float) st11 = c11;
            (float, float) st12 = c21;

            (float,float)st21 = c21;
            (float,float) st22 = c22;
        }
    }
}
