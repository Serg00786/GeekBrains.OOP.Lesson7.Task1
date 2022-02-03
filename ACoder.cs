using GeekBrains.OOP.Lesson7.Task1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson7.Task1
{
    internal class ACoder : ICoder
    {
        public void Decode(string n)
        {
            throw new NotImplementedException();
        }

        public void Encode(string n)
        {
            int strlencth=n.Length;
            char[] arr = new char[strlencth];
            for (int i = 0; i < strlencth; i++)
            {
                arr[i] = Convert.ToChar(n[i] + 1);
            }
            Console.WriteLine(new String (arr));
        }
    }
}
