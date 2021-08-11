using System;

namespace Intervalo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int contInt = 0;
            int contExt = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    contInt = contInt + 1;
                }
                else
                {
                    contExt = contExt + 1;
                }
 
            }
            Console.WriteLine(contInt + " in");
            Console.WriteLine(contExt + " out");

        }
    }
}
