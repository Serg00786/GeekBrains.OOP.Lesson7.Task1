using GeekBrains.OOP.Lesson7.Task1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson7.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoder coder = new ACoder();
            ICoder coder1 = new BCoder();
            string n = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            Console.WriteLine(n);
            coder.Encode(n);
            coder1.Encode(n);
            Console.ReadLine();
        }
    }
}
