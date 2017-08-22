using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message):base(message)
        {


        }
    }

    

    public class Temperature
    {
        int temp = 0;
        public void showtemp()
        {
          
                if (temp == 0)
                {
                    throw (new TempIsZeroException("Zero Temperature Exception found"));
                }
            
            
        }
    }
}
