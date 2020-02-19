using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Player
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }
        public Team Team { get; set; }
        public void Info()
        {
            Console.WriteLine
                (
                $"Name: {Name}\n" +
                $"Surname: {Surname}\n"+
                $"Birthdate: {Birthdate.ToString()}\n"+
                $"Number: {Number}\n"+
                $"Position: {Position}\n"+
                $"Team: {Team.Name}."
                );
        }
    }
}
