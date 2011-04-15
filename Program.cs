using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernMedical
{
    class Program
    {
        static void Main(string[] args)
        {
            int current = 1;
            string outMsg = string.Empty;

            while (current <= 100)
            {
                outMsg = string.Empty;
                outMsg += DivisableByThree(current);
                outMsg += DivisableByFive(current);

                if (outMsg == string.Empty)
                {
                    outMsg = current.ToString();
                }

                Console.WriteLine(outMsg);

                current++;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static string DivisableByThree(int number)
        {
            if (number % 3 == 0)
            {
               return "Modern";
            }
            return string.Empty;
        }

        private static string DivisableByFive(int number)
        {
            if (number % 5 == 0)
            {
                return "Medical";
            }
            return string.Empty;
        }
    }
}
