using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class StringBuilder1
    {
        private int length;

        public int Length { get { return length; } set { length = value; } }
        List<char> mystring = new List<char>();
        public StringBuilder1()
        {
            length = 0;
        }
        public StringBuilder1(string data)
        {
            mystring.AddRange(data.ToArray());
            length++;
        }
        public void append(string value)
        {
            mystring.AddRange(value);
            length += value.Length;
        }

        public void Insert(int index, string value)
        {
            for (int i = 0; i < mystring.Count; i++)
            {
                if (index == i)
                {
                    for (int k = 0; k < value.Length;k++)
                    {
                        mystring.Insert(index, value[k]);
                    }
                }
            }
        }
        public void RemoveAt(int index)
        {
            mystring.RemoveAt(index);
        }

        public override string ToString()
        {
            
            return new string(mystring.ToArray());
        }
    }
}
