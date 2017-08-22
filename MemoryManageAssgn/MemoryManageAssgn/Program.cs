using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MemoryManageAssgn
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // string path = @"D:\C#\temp.txt";

            //try
            //{
            //    if (File.Exists(path))
            //    {
            //        File.Delete(path);

            //    }
            //    using (FileStream fs =  File.Create(path))
            //    {
            //        Byte[] info = new UTF8Encoding(true).GetBytes("This is some text");
            //        fs.Write(info, 0, info.Length);
            //    }

            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        string content="";
            //        while ((content = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(content);
            //        }
            //        Console.ReadLine();
            //    }
            //    using (var writer = new StreamWriter(new FileStream(@"D:\C#\temp.txt", FileMode.Append)))
            //    {
            //        writer.WriteLine("Text 2");
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            FileIODemo f = new FileIODemo();
            f.write();
            
            f.read();
            f.Dispose();
        }

        
        
    }
}
