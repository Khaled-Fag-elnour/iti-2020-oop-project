using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace online_elections
{
    class Program
    {
        static void Main(string[] args)
        {
            Data electionsData = new Data();
            List<Candidate> candidates = electionsData.getCandidateList();
            List<Citizen> citizens = electionsData.getCitizenList();
            Judge j = new Judge();
            Boolean wantTocontinue = true;

            while (wantTocontinue)
            {
                Console.WriteLine("Please enter Name");
                String name = Console.ReadLine();
                Console.WriteLine("Please enter id");
                int id = int.Parse(Console.ReadLine());
                Citizen citizen = j.checkDataIsCorrect(id, name, citizens);
                if (citizen != null)
                {
                    if (citizen.Validation())
                    {
                        Console.WriteLine("\nValid to Vote");
                        Console.WriteLine("\nPlease choose between :");
                        foreach (Candidate c in candidates)
                        {
                            Console.WriteLine(" enter " + c.getID() + " For " + c.getName());
                        }
                   
                        int idOfCandidate = int.Parse(Console.ReadLine());
                        foreach (Candidate c in candidates)
                        {
                            if (c.getID() == idOfCandidate)
                                citizen.Vote(c);
                        }
                    }
                }
                else
                    Console.WriteLine("Name or id is not Valid");

                bool valid = false;
                while (valid == false)
                {
                    Console.WriteLine("\nDo you want to submit another vote?\nEnter 'Y' for yes or 'N' for no: ");
                    String proceed = Console.ReadLine();
                    if (proceed.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                    {
                        wantTocontinue = true;
                        valid = true;
                    }
                    else if (proceed.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                    {
                        wantTocontinue = false;
                        valid = true;
                    }
                    else
                        Console.WriteLine("please enter only 'y' or 'n'\n");
                }
            }
           

            List<Candidate> winners = j.whoWins(candidates);
            

            if (winners.Count == 1)
            {
            
                Console.WriteLine("The Winner is " + winners[0]);
               
            }
            else
            {
                if (winners.Count != 0)
                {
                    Console.WriteLine("Rematch required between: ");
                    foreach (Candidate c in winners)
                    {
                        Console.WriteLine(c);
                    }
                } else
                {
                    Console.WriteLine("no votes submitted yet");
                }

               


            }
            Console.ReadKey();

        }
    }
}