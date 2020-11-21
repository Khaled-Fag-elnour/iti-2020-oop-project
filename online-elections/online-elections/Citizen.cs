using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_elections
{
    class Citizen
    {
        public int nationalId;
        public string name;
        public int age;
        public bool hasCriminalRecord;
        public bool alreadyVoted = false;
        public Queue<Vote> votesList = new Queue<Vote>();

        public Citizen(int id, string name, int age, bool hasCriminalRecord, bool alreadyVoted)
        {
            nationalId = id;
            this.name = name;
            this.age = age;
            this.hasCriminalRecord = hasCriminalRecord;
            this.alreadyVoted = alreadyVoted;
        }

        public void Vote(Candidate c)
        {
            c.setVotes();
            this.alreadyVoted = true;

            Vote newvote = new Vote(this.nationalId, c.candId);
            votesList.Enqueue(newvote);
        }
    }
}
