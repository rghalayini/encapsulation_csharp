using Lab_Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teams
{
    class Program
    {
        public static void Main()
        {            
            var lines = 5;
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);
            }

            Team team = new Team("Lexicon");
            foreach (Person p in persons)
            {
                team.AddPlayer(p);
            }

            Console.ReadLine();
        }
    }
}
