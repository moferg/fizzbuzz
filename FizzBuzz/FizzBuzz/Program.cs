using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                // Program needs ReadKey() or console will disappear before user can see the output
                else if (i == 100)
                {
                    Console.WriteLine("Buzz");
                    Console.WriteLine("Press any key to exit prgram.");
                    Console.ReadKey();
                }

                // ReadyKey() must go before this condition since 100 is a multiple of 5 
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }

                
            }
            
        }
    }
}
