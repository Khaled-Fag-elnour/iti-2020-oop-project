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
        public static Judge instance = null;
        public Judge() {
           
        
        }

        public List<Candidate> whoWins( List<Candidate> candidteList)
        {
           int max = 0;
            Candidate z =new Candidate();
            List
                
                <Candidate> winners=new List<Candidate>();

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

                if (z.getVotes() == c.getVotes())
                {
                    winners.Add(c);
                    
                }


            }

            return winners;
        }
        public Boolean checkDataIsCorrect(int id , String name,int Age ,List<Citizen> citizens)
        {
            Boolean allowedToVote = false;
            foreach(Citizen c in citizens)
            {

                if (c.Name == name && c.NationalId == id && c.Age == Age && Age > 18&&c.AlreadyVoted==false)
                    allowedToVote = true;
                    
            }
            return allowedToVote;


        }
      

       
        





    }
}
