using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ServiceReference1.StudentClient();
            try
            {
                client.Open();
                var students = client.GetStudents();
                
                foreach (var student in students)
                {
                    Console.WriteLine(string.Format("Name:{0},ID:{1}", student.Name, student.Id));
                }
                Console.ReadLine();

            }
            catch (Exception e)
            {

            }

            finally
            {
                client.Close();
            }
            
        }
    }
}
