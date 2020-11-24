using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_elections
{
    class Judge
    {
         String name;
        public Judge() {
           
        
        }

        public List<Candidate> whoWins( List<Candidate> candidteList)
        {
           int max = 0;
            Candidate z =new Candidate();
            List<Candidate> winners=new List<Candidate>();

            foreach (Candidate c in candidteList)
            {

                if (c.getVotes() > max)
                {
                    max = c.getVotes();
                    z = c;
                }
            }
            foreach (Candidate c in candidteList)
            {
                if (z.getVotes() != 0 && z.getVotes() == c.getVotes())
                {
                    winners.Add(c);
                }
            }
            return winners;
        }
        public Citizen checkDataIsCorrect(int id , String name ,List<Citizen> citizens)
        {
           
            foreach(Citizen c in citizens)
            {

                if (c.Name.Equals( name, StringComparison.InvariantCultureIgnoreCase) && c.NationalId == id)
                   
                return c;
                    
            }
            return null;
        }
      

       
        





    }
}
