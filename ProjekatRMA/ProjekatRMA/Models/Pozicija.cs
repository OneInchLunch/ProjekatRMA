using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatRMA.Models
{
    public class Pozicija
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Stranka> StrankaList { get; set; }

        public Pozicija(int id, string name, List<Stranka> strankaList)
        {
            Id = id;
            Name = name;
            StrankaList = new List<Stranka>(strankaList);
        }
    }
}
