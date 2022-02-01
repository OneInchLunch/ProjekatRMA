using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatRMA.Models
{
    public class Kandidat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Kandidat(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
    }
}
