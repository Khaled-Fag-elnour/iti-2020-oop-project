using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_elections
{
    class Candidate
    {
        public int candId;
        public string candName;
        public int noOfVotes;

        public Candidate(int id, string name)
        {
            candId = id;
            candName = name;
        }

        public void setVotes()
        {
            this.noOfVotes++;
        }
        public int getVotes()
        {
            return noOfVotes;
        }
    }
}
