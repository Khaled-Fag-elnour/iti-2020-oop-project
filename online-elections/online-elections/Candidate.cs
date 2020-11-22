using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_elections
{
    class Candidate
    {
        private int candId;
        private string candName;
        private int noOfVotes=0;

        public Candidate(int id, string name)
        {
            candId = id;
            candName = name;
        }

        public void addVote()
        {
            this.noOfVotes++;
        }
        
        public int getVotes()
        {
            return noOfVotes;
        }
        
        public void displayInfo()
        {
            this.ToString();
        }
        
        public override string ToString()
        {
            return "Candidate name : " + this.candName + " Candidate ID : " + this.candId;
        }
    }
}
