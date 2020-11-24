using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_elections
{
    class Data
    {
        private List<Candidate> CandidateList = new List<Candidate>(){
            new Candidate(1,"Rami Mohamed"),
            new Candidate(2,"Mona Samy"),
            new Candidate(3,"Hassan Ali"),
            new Candidate(4,"Youssef Ahmed"),
            new Candidate(5,"Hana Elsaied"),
        };
        private List<Citizen> CitizenList = new List<Citizen>(){
            new Citizen(1,"Mostafa",16),
            new Citizen(2,"Mohamed",18),
            new Citizen(3,"Salma",18),
            new Citizen(4,"Ahmed",20),
            new Citizen(5,"Khaled",42),
            new Citizen(6,"Esraa",60),
            new Citizen(7,"Mahmoud",27),
            new Citizen(8,"Alaa",33),
            new Citizen(9,"Samar",17),
            new Citizen(10,"Maged",19),
        };

        public List<Citizen> getCitizenList()
        {
            return CitizenList;
        }
        public List<Candidate> getCandidateList()
        {
            return CandidateList;
        }
    }
}
