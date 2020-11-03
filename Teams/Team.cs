using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Encapsulation
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        //constructor
        public Team(string name)
        {
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
            this.name = name;
        }
                         
        public List<Person> FirstTeam
        {
            get { return this.firstTeam; }
        }
        public List<Person> ReserveTeam
        {
            get { return this.reserveTeam; }
        }

        //method to add players
        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }
    }
}
