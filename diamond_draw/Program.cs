
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlós
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(print(11));
            Console.ReadKey();
        }
        public static string print(int n)
        {
            if (n % 2 == 0 || n < 0)
            {
                return null;
            }
            string diamond = "";
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    int counter = i;
                    while (counter != n - 1 && counter < n)
                    {
                        if (counter % 2 != 0)
                        {
                            diamond += " ";
                        }
                        counter++;
                    }
                    for (int j = 0; j < i; j++)
                    {
                        diamond += "*";
                    }
                    diamond += "\n";
                }
            }
            for (int i = n - 1; i >= 1; i--)
            {
                if (i % 2 != 0)
                {
                    int counter = i;
                    while (counter != n - 1 && counter < n)
                    {
                        if (counter % 2 != 0)
                        {
                            diamond += " ";
                        }
                        counter++;
                    }
                    for (int j = 0; j < i; j++)
                    {
                        diamond += "*";
                    }
                    diamond += "\n";
                }
            }
            return diamond;
        }
    }
}
