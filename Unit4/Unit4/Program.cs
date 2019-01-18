using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Name: Khalid
//Decrptions: 
namespace Unit4
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                

                //ReadFile-Input________________________________________________________________________________________________________________________________
                StreamReader sr = new StreamReader(@"Data.txt");//Here Read The Text File

                int length = int.Parse(sr.ReadLine()); // we Read the Size of the Array 

                string[] Numbers = new string[length]; // Decaring a new Array using the Length of array 

                for (int i = 0; i < length; i++) // Here we are storing are Numbers from are Text File into the Array We Made 
                {
                    Numbers[i] = sr.ReadLine(); //Here we read Line by Line 
                    Console.WriteLine("This is are Score#" + i + ":" + Numbers[i]); //Display the score 

                }
                sr.Close(); //here we close the StreamReader

                //____________________________________________________________________________________________________________________________________________

                //Check For a Number in the Array____________________________________________________________________________________________________________
                int Counter = 0; //Here declaer a Counter  
                for(int i = 0; i < length; i++)
                {
                    if(Numbers[i] == "3")
                    {
                        Counter++;
                    }
                }
                Console.WriteLine("There are "+ Counter +":Three's");
                //___________________________________________________________________________________________________________________________________________

                //Adding-Process______________________________________________________________________________________________________________________________
                int Total = 0; // Make a Total Var
                for(int i =0; i < length; i++) // 
                {
                    Total += int.Parse(Numbers[i]); //Adding Array

                }
                Console.WriteLine("Total" + Total); //Display the Total sum of the array
                //____________________________________________________________________________________________________________________________________________

                //Check to close App__________________________________________________________________________________________________________________________
                Console.WriteLine("Do you want to end");
                string Close = Console.ReadLine();
                Close = Close.ToUpper();
                
                if (Close == "CLOSE" || Close =="YES")
                {
                    break;
                }
                //____________________________________________________________________________________________________________________________________________
                
                Console.ReadKey();
            }
            
        }
    }
}
