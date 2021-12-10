using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину сторон первого треугольника");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину сторон второго треугольника");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int z2 = Convert.ToInt32(Console.ReadLine());
                      
            CalcPlosh(x1, y1, z1, x2, y2, z2, out double s1, out double s2);
            if (s1 > s2) Console.WriteLine("Первый треугольник больше второго");

            else
            {
                Console.WriteLine("Второй треугольник больше первого");
            }
                

            Console.WriteLine("S1{0} ", s1);
            Console.WriteLine("S2{0} ", s2);

            Console.ReadKey();


        }
        


        


           static void CalcPlosh(int x1, int y1, int z1, int x2, int y2, int z2,  out double s1, out double s2)
        {
            double p1, p2;
            
            
            p1 = (double)(x1 + y1 + z1) / 2;
            p2 = (double)(x2 + y2 + z2) / 2;
            s1 = Math.Sqrt(p1 * (p1 - x1) * (p1 - y1) * (p1 - z1));
            s2 = Math.Sqrt(p2 * (p2 - x2) * (p2 - y2) * (p2 - z2));

        }











    }




 


}



