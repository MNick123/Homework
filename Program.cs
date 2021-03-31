using System;

namespace Quad
{
    class Program
    {
        static void Main(string[] args)
        {

            int user = 1;

            while (user < 2)
            {


                Console.WriteLine("Quadratic Formual");

                Console.WriteLine("Enter a value then b then c");

                Console.WriteLine("enter a");

                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter b");

                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter c");


                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("maths");

                double newb = Math.Pow(b, 2);

                Console.WriteLine(newb);

               

                double pt1 = newb - 4 * a * c;

                double pt2 = Math.Sqrt(pt1);

                Console.WriteLine("square");

                Console.WriteLine(pt2);
                    
                //negative / pos roots

                double pt3 = -b + pt2;
                double pt4 = -b - pt2;

                // this is bottom fracation work
                int bottom = 2 * a;

                //prints stuff

                Console.WriteLine($"{pt3} is the positive root");

                Console.WriteLine($"{pt4} is the negative root");

                Console.WriteLine($"then divide by the bottom number ({bottom})");

                

                Console.WriteLine($"{pt3 / bottom} positive answer");
                Console.WriteLine($"{pt4 / bottom} negative answer");

               
                
                    Console.WriteLine("another problem? 1= yes 2= no");
                    user = Convert.ToInt32(Console.ReadLine());
                
            }
        }
    }
}
