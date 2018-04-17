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
                
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
            
            // Program needs ReadKey() or console will disappear before user can see the output 
            Console.WriteLine("Press any key to exit prgram.");
            Console.ReadKey();
        }
    }
}
