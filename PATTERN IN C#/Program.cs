using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERN_IN_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers =  new int[3,3];

            for (int i = 0; i < 3  ; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                   
                }
                Console.WriteLine(); // MAKE NEW LINE
            }
            Console.ReadLine();
        }
    }
}
