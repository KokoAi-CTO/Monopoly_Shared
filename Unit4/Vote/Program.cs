using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace VoteArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = null;
            string OneVote = null;
            string OneVoteC = null;
            {
                StreamWriter sw = new StreamWriter("votes.txt");
                Console.WriteLine("Enter votes:");
                sw.WriteLine(Console.ReadLine());
                sw.Close();
            }
            {
                //_______________________________________
                StreamReader sr = new StreamReader("votes.txt");
                data = (sr.ReadLine());
                sr.Close();
            }

            //______________________________________
            int num = data.Length;
            data = data.ToUpper();
            string[] VoteArray = new string[num];
            //_______________________________________

            for (int i = 0; i < num; i++)
            {
                OneVote = data.Substring(i, 1);
                OneVoteC = data.Substring(data.IndexOf('C'));
                Console.WriteLine(OneVoteC);
                VoteArray[i] = OneVote;
            }
            //________________________________________________________
            int ScoreA = 0;
            int ScoreB = 0;
            int OtherLetters = 0;
            //Check for A and B Score
            
            for (int i = 0; i < VoteArray.Length; i++)
            {
                Console.WriteLine("Vote " + VoteArray[i]);
                if (VoteArray[i] == "A")
                {
                    ScoreA++;

                }
                else if (VoteArray[i] == "B")
                {
                    ScoreB++;
                }
                else if (!(VoteArray[i] == "A" || VoteArray[i] == "B"))
                {
                    OtherLetters++;
                }
            }


           
            //Display the Scores
            if (ScoreA < ScoreB)
            {
                int by = ScoreB - ScoreA;
                Console.WriteLine("Person B Won by " + by);
            }
            else if (ScoreB < ScoreA)
            {
                int by = ScoreA - ScoreB;
                Console.WriteLine("Person A Won by " + by);
            }
            else
            {
                Console.WriteLine("Peason A and B are Tie");
            }

            Console.WriteLine("Person A got " + ScoreA);
            Console.WriteLine("Person B got " + ScoreB);
            Console.WriteLine("OtherLettes " + OtherLetters);
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
