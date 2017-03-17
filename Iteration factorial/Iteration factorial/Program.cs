using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            long iterative_factorial (int n)
            {
                long factorial = 1;

                for (int i = 2; i <= n; i++) factorial = factorial * i;

                return factorial;
            }

            string str = Console.ReadLine();

            int num = Convert.ToInt32(str);

            Console.WriteLine(iterative_factorial(num));

            Console.ReadKey();
        }
    }
}
