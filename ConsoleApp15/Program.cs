using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Team Barcelona = new Team()
            {
                Name = "Barcelona",
                City = "Barcelona",
                Country = "Spain"
            };
            Team RealMadrid = new Team()
            {
                Name = "Real Madrid",
                City = "Madrid",
                Country = "Spain"
            };
            Player messi = new Player()
            {
                Name = "Leonel",
                Surname = "Messi",
                Birthdate = Convert.ToDateTime("01-01-1987"),
                Number = 10,
                Position = "forward",
                Team = Barcelona
            };
            Player benzema = new Player()
            {
                Name = "Karim",
                Surname = "Benzema",
                Birthdate = Convert.ToDateTime("01-01-1986"),
                Number = 9,
                Position = "forward",
                Team = RealMadrid
            };

            messi.Info();
            Console.WriteLine("------------");
            benzema.Info();
            Console.ReadLine();
        }
    }
}
