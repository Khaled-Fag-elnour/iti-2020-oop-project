using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_elections
{
    class Program
    {

        Citizen[] citizenList = new Citizen[4];
        Citizen citizen_1 = new Citizen(1, "Mohamad", 19, false, true);
        Citizen citizen_2 = new Citizen(2, "Ahmad", 16, false, false);
        Citizen citizen_3 = new Citizen(3, "Khaled", 23, true, false);
        Citizen citizen_4 = new Citizen(4, "Omar", 37, false, false);


        public Citizen CheckId(int enteredId, ref int wrongId)
        {
            for (int i = 0; i < citizenList.Length; i++)
            {
                if (enteredId == citizenList[i].NationalId)
                    return citizenList[i];
            }
            wrongId = 1;
            return null;
        }

        public void Validation(Citizen c)
        {
            if (c.Age < 18)
            {

                Console.WriteLine("\nSorry {0}, only people above 18 are allowed to vote.", c.Name);
                return;
            }
            else if (c.HasCriminalRecord)
            {
                Console.WriteLine("\nSorry {0}, you cannot vote due to your criminal record.", c.Name);
                return;
            }
            else if (c.AlreadyVoted)
            {
                Console.WriteLine("\nHello {0}, you already voted. \nYou are not allowed to vote again.", c.Name);
                return;
            }
            else
            {
                Console.WriteLine("\nWelcome {0}", c.Name);
            }
        }



        static void Main(string[] args)
        {
            Program p = new Program();
            p.citizenList[0] = p.citizen_1;
            p.citizenList[1] = p.citizen_2;
            p.citizenList[2] = p.citizen_3;
            p.citizenList[3] = p.citizen_4;


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
