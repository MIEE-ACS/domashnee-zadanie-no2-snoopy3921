//За Хюи number 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    internal class Program
    {
        //A circle, D:[-10, -6], stt to skip typing R
        static string FirstSegment(double x, double R)
        {   

            double centerPoint = -8;
            
            if (Math.Abs(centerPoint - x) > R)
            {
                return "Undef";
            }
            else
            {
                double xInCircle = Math.Abs(centerPoint - x);
                double yInCircle = R - Math.Sqrt(Math.Pow(R, 2) - Math.Pow(xInCircle, 2));
                return (2 - yInCircle).ToString("F3");
            }
          
        }
        //y = 2, D:[-6, -4]
        static string SecondSegment(double x)
        {
            return 2.ToString("F3");
        }
        // y = -x/2, D:[-4, 2]
        static string ThirdSegment(double x)
        {
            return (-x/2).ToString("F3");
        }
        //y = x - 3, D:[2, 4]
        static string FourthSegment(double x)
        {
            return (x - 3).ToString("F3");
        }
        static void Main(string[] args)
        {
            double R; 
            do
            {
                Console.WriteLine("Type your value for R: ");
                R = Convert.ToDouble(Console.ReadLine());
                if (R <= 0)
                {
                    Console.WriteLine("Value R can't be smaller than 0!!!");
                }
                else if (R > 2)
                {
                    R = 2;
                    Console.WriteLine("Good job R = 2!");
                }
                else
                {
                    Console.WriteLine("Good job R = {0}!", R);
                }
            } while (R <= 0);
            Console.WriteLine("\n");
            for(double x = -10; x < 4; x += 0.2)
            {
                if(x>=-10 && x < -6)    Console.WriteLine("y({0:F3})\t=\t{1}", x, FirstSegment(x, R));
                if (x >= -6 && x < -4)  Console.WriteLine("y({0:F3})\t=\t{1}", x, SecondSegment(x));
                if (x >= -4 && x < 2)   Console.WriteLine("y({0:F3})\t=\t{1}", x, ThirdSegment(x));
                if (x >= 2 && x < 4)    Console.WriteLine("y({0:F3})\t=\t{1}", x, FourthSegment(x));
            }   
            
            Console.ReadKey();
        }
    }
}
