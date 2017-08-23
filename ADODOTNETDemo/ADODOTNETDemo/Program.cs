using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace ADODOTNETDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var student = new Student();
                //student.SaveData();
                //student.doUpdate();
                ///student.update();
                //student.getDataSet();
                student.doDelete();

                student.GetData();
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
