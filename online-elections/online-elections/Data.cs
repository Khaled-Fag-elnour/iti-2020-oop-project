using System;
using System.Collections.Generic;
namespace online-elections{

    class Data
    {
        private  List<Candidate> CandidateList = new List<Candidate>(){
            new Candidate(1,"Rami Mohamed"),
            new Candidate(2,"Mona Samy"),
            new Candidate(3,"Hassan Ali"),
            new Candidate(4,"Youssef Ahmed"),
            new Candidate(5,"Hana Elsaied"),
        };
        private  List<Citizen> CitizenList = new List<Citizen>(){
            new Citizen(1,"Mostafa",30,false,false),
            new Citizen(2,"Mohamed",16,false,false),
            new Citizen(3,"Ahmed",18,false,true),
            new Citizen(4,"Omar",20,true,false),
            new Citizen(5,"Lila",42,true,false),
            new Citizen(6,"Esraa",60,false,false),
            new Citizen(7,"Mahmoud",27,false,true),
            new Citizen(8,"Alaa",33,false,true),
            new Citizen(9,"Samar",17,false,false),
            new Citizen(10,"Maged",19,false,false),
        };

        public List<Citizen> getCitizenList(){
            return CitizenList;
        }
        public List<Candidate> getCandidateList(){
            return CandidateList;
        }
    }
}
