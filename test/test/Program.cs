using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while(num < 10)
            {
                num = num += 2;
                Console.WriteLine(num);
            }
            Console.ReadKey();

        }
    }
}
