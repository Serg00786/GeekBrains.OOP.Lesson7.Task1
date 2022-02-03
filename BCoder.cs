using GeekBrains.OOP.Lesson7.Task1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson7.Task1
{
    internal class BCoder : ICoder
    {
        public void Decode(string n)
        {
            throw new NotImplementedException();
        }

        public void Encode(string n)
        {
            char[] arr = new char[n.Length];
            arr = n.ToCharArray();
            for (int i =0; i<n.Length/2; i++)
            {
                char c = arr[i];
                arr[i] = arr[arr.Length - (i+1)];
                arr[arr.Length-(i+1)] = c;
            }

            Console.WriteLine(new string (arr));
        }
    }
}
