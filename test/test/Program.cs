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
            Console.WriteLine("\n----------");
            rectanglePrint(5,7);
           
            Console.ReadKey();
        }

        public static void rectanglePrint(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine("");

                for (int k = 0; k < width; k++)
                {
                    if (i > 0 && k > 0)
                    {
                        if (i < height - 1 && k < width - 1)
                        {
                            Console.Write("       ");
                        }
                        else
                            Console.Write(i + "," + k + "End ");
                    }
                    else
                        Console.Write(i + "," + k + "ENd ");
                }


            }
        }
    }

}
