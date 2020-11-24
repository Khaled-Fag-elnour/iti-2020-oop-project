using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_elections
{
    class Program
    {

        static void Main(string[] args)
        {
            Data electionsData = new Data();
            List<Candidate> candidates = electionsData.getCandidateList();
            List<Citizen> citizens = electionsData.getCitizenList();
            Citizen citizen_1 = new Citizen(1, "Mohamed", 19, false);
            Citizen citizen_2 = new Citizen(2, "Ahmed", 20, false);
            Citizen citizen_3 = new Citizen(3, "Khaled", 23, true);
            Citizen citizen_4 = new Citizen(4, "Omar", 37, false);
            Candidate c1 = new Candidate(1, "Trump");
            Candidate c2 = new Candidate(2, "Biden");
            Judge j = new Judge();
            Boolean wantTocontinue = true;

            while (wantTocontinue)
            {
                Console.WriteLine("Please enter Name");
                String name = Console.ReadLine();
                Console.WriteLine("Please enter id");
                int id = int.Parse(Console.ReadLine());
                if (j.checkDataIsCorrect(id, name, citizens) != null)
                {
                    Console.WriteLine("Valid to Vote");
                    Console.WriteLine("Please choose between :");
                    foreach (Candidate c in candidates)
                    {
                        Console.WriteLine(" enter " + c.getID() + " For " + c.getName());

                    }
                    Citizen citizen = j.checkDataIsCorrect(id, name, citizens);
                    int idOfCandidate = int.Parse(Console.ReadLine());
                    foreach (Candidate c in candidates)
                    {
                        if (c.getID() == idOfCandidate)
                            citizen.Vote(c);

                    }


                }
                else
                    Console.WriteLine("Name or id is not Valid");

                Console.WriteLine(" please if you want to continue to add votes enter y for yes and N for no ");
                String proceed = Console.ReadLine();
                if (proceed.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                    wantTocontinue = true;
                else
                    wantTocontinue = false;


                }
           

            List<Candidate> winners = j.whoWins(candidates);
            

            if (winners.Count == 1)
            {
            
                Console.WriteLine(" the Winner is " + winners[0]);
               
            }
            else
            {
                Console.WriteLine(" Rematch required between ");
                foreach (Candidate c in candidates)
                {
                    Console.WriteLine(c);

                }

               


            }
            Console.ReadKey();

        }
}
