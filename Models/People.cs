using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_projeto_hospedagem.Models
{
    public class People
    {
        internal static int guests;

        public People() {}

        public People(string name)
        {
            Name = name;
        }

        public People(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string CompleteName => $"{Name} {LastName}".ToUpper();
    }
}