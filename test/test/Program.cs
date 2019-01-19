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
            int boxIndex = 1;
            string namebox = "box" + boxIndex;
            //bool box1 = true;
            if(namebox =="box1")
            {
                bool box1 = true;
            }
            Console.WriteLine(namebox);
            
            Console.ReadKey();

        }
    }
}
