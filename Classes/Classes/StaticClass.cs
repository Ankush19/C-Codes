using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class StaticClass
    {
        public static float pi = 3.14f;
        public static  float area(float radius)
        {
            float area1 = pi * radius * radius;
            return area1;
        }
    }
}
