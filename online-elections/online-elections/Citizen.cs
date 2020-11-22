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
        public bool HasCriminalRecord { get; set; }
        public bool AlreadyVoted { get; set; }

        public Queue<Vote> votesList = new Queue<Vote>();


        public Citizen(int id, string name, int age, bool hasCriminalRecord, bool alreadyVoted)
        {
            NationalId = id;
            Name = name;
            Age = age;
            HasCriminalRecord = hasCriminalRecord;
            AlreadyVoted = alreadyVoted;
        }

        public void Vote(Candidate c)
        {
            c.addVote();
            this.AlreadyVoted = true;

            Vote newvote = new Vote(this.NationalId, c.CandId);
            votesList.Enqueue(newvote);
        }
    }
}
