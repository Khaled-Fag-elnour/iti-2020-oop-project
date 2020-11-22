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
            setID(id);
            setName(name);
        }

        public void addVote()
        {
            this.noOfVotes++;
        }
        
        public int getVotes()
        {
            return noOfVotes;
        }
        public void setName(string str)
        {
            this.candName = str;
        }
        public void setID(int id)
        {
            this.candId = id;
        }
        public string getName()
        {
            return this.candName;
        }
        public int getID()
        {
            return this.candId;
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
