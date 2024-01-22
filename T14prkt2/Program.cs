using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14prkt2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mcl = new MyClass();
            Console.WriteLine(mcl.ToString());
            MyClass mcl1 = new MyClass(8,90);
            Console.WriteLine(mcl1.ToString());

            MyClass[] points = new MyClass[4];
            for(int i = 1;i<points.Length;i++)
            {
                Console.WriteLine($"Введите координаты {i} точки ");
                Console.Write("x= ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("y= ");
                double y = double.Parse(Console.ReadLine());
                
            }
            Console.Write(points.ToString());
            Console.ReadKey();
            

        }
        
    }
}
