using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MemoryManageAssgn
{
    class FileIODemo:IDisposable
    {
        public StreamReader reader { get; set; }
        public StreamWriter writer { get; set; }

        public void write()
        {
            writer = new StreamWriter(new FileStream(@"D:\C#\temp1.txt", FileMode.OpenOrCreate));
            writer.WriteLine("asdasd");
            writer.Close();
            Console.ReadLine();

        }

        public void read()
        {
            reader = new StreamReader(@"D:\C#\temp1.txt");
            Console.WriteLine(reader.ReadToEnd());
            Console.ReadLine();
        }

       
        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                GC.SuppressFinalize(this);
            }
            if (writer != null)
            {
                writer.Dispose();
            }
        } 
    }
}
