using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_elections
{
    class Program
    {

        


        public Citizen CheckId(int enteredId, ref int wrongId)
        {
            for (int i = 0; i < citizenList.Length; i++)
            {
                if (enteredId == citizenList[i].nationalId)
                    return citizenList[i];
            }
            wrongId = 1;
            return null;
        }

        public void Validation(Citizen c)
        {
            if (c.age < 18)
            {

                Console.WriteLine("\nSorry {0}, only people above 18 are allowed to vote.", c.name);
                return;
            }
            else if (c.hasCriminalRecord)
            {
                Console.WriteLine("\nSorry {0}, you cannot vote due to your criminal record.", c.name);
                return;
            }
            else if (c.alreadyVoted)
            {
                Console.WriteLine("Hello {0}, you already voted. \nYou are not allowed to vote again.", c.name);
                return;
            }
            else
            {
                Console.WriteLine("Welcome {0}", c.name);
            }
        }



        static void Main(string[] args)
        {
            Program p = new Program();
            //p.citizenList[0] = p.citizen_1;
            //p.citizenList[1] = p.citizen_2;
            //p.citizenList[2] = p.citizen_3;
            //p.citizenList[3] = p.citizen_4;

            int enteredId = 0;
            int wrongId = 0;

            do
            {
                if (wrongId == 1)
                {
                    Console.WriteLine("Sorry, incorrect ID");
                    Console.WriteLine("Please enter a valid ID: ");
                    enteredId = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Please enter your ID to submit your vote: ");
                    enteredId = int.Parse(Console.ReadLine());

                }

            } while (p.CheckId(enteredId, ref wrongId) == null);

            Citizen currentCitizen = p.CheckId(enteredId, ref wrongId);
            p.Validation(currentCitizen);


            Console.ReadKey();

        }
    }
}
