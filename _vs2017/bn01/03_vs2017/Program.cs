using System;
using static System.Console;

namespace _03_vs2017
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                checked {
                    int num = int.MaxValue-1;
                    WriteLine(num);
                    num++;
                    WriteLine(num);
                    num++;
                    WriteLine(num);
                    num++;
                    WriteLine(num);
                }
            } catch (OverflowException) {
                WriteLine("Could not complete action due to [System.OverflowException]");
            }

            unchecked {
                int val = int.MaxValue+1;
                WriteLine(val);
                val--;
                WriteLine(val);
                val--;
                WriteLine(val);
            }

            int max = 500;
            for (byte i = 0; i < max; i++) { WriteLine(i); }


            ReadKey();
            return;
        }
    }
}