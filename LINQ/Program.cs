using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PetClass> pets = new List<PetClass>();

            pets.Add(new PetClass { HasFur = false, Legs = 2, Name = "Max", Type = PetType.Duck });
            pets.Add(new PetClass { HasFur = false, Legs = 4, Name = "Pluto", Type = PetType.Dog });

            List<PetClass> results = (from p in pets
                                      where p.Type == PetType.Dog
                                      select p).ToList();
            Console.WriteLine("found" + results.Count + "Dogs");
            Console.ReadLine();

        }

        class PetClass
        {
            public int Legs;
            public PetType Type;
            public string Name;
            public bool HasFur;
        }
        enum PetType
        {
            Dog,
            Duck
        }
    }
}
