using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCompilationDemo
{
    public static  class HelloUtil
    {
        [SqlFunction]
        public static string AppendHello(string msg)
        {
            return msg + "::Hello:)";
        }
    }

}
