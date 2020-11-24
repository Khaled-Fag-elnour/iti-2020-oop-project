using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_elections
{
    class Citizen
    {
        public int NationalId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool AlreadyVoted { get; set; }

        public Queue<VoteInfo> votesList = new Queue<VoteInfo>();


        public Citizen(int id, string name, int age)
        {
            NationalId = id;
            Name = name;
            Age = age;
        }
        public Citizen()
        {
           

        }

        public void Vote(Candidate c)
        {
            c.addVote();
            this.AlreadyVoted = true;

            VoteInfo newvote = new VoteInfo(this.NationalId, c.getID());
            votesList.Enqueue(newvote);
            VoteInfo.StoreInformation(newvote);
        }

        public bool Validation()
        {
            if (this.Age < 18)
            {

                Console.WriteLine("\nSorry {0}, only people above 18 are allowed to vote.\n", this.Name);
                return false;
            }
            else if (this.AlreadyVoted)
            {
                Console.WriteLine("\nSorry {0}, You are not allowed to vote again.\n", this.Name);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
