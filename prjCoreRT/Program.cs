using System;

namespace Net3Factorial
{
    class Program
    {

        static long Factorial(int x)
        {

            long result = 1;

            Console.ForegroundColor = ConsoleColor.Blue;

            for (int i = 1; i <= x; i++)

            {

                result = result * i;

                Console.WriteLine("Step {0}: {1}", i, result);

            }

            return result;

        }




        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine("Enter the Integer for the factorial calculation:");

            int num = Convert.ToInt32(Console.ReadLine());
            //Todo check number

            long f = Factorial(num);
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("The Factorial of {0} is: {1}\n", num, f);
        }
    }
}
