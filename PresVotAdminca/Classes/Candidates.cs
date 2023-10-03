using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresVotAdminca.Classes
{
    //Кандидаты на голосование 
    class Candidates
    {
        private int id;
        private string name;
        private int age;
        private int group;
        private string remarck;
        private string electionProgramm; 
        private string pictureName;

        public Candidates(int id, string name, int age, int group, string remarck, string electionProgramm, string pictureName)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.group = group;
            this.remarck = remarck;
            this.electionProgramm = electionProgramm;
            this.pictureName = pictureName;
        }

        public string PictureName { get => pictureName; set => pictureName = value; }
        public string ElectionProgramm { get => electionProgramm; set => electionProgramm = value; }
        public string Remarck { get => remarck; set => remarck = value; }
        public int Group { get => group; set => group = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return "Candidat: " + id 
                + " Name:" + name
                + " Age:" + age
                + " Group:" + group
                + " Remarck:" + remarck
                + " ElectionProgramm:" + electionProgramm
                + " PictureName:" + pictureName;
        }
    }
}
