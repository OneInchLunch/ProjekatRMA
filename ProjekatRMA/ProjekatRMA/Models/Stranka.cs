using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatRMA.Models
{
    public class Stranka
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Kandidat> KandidatList { get; set; }

        public Stranka(int id, string name, List<Kandidat> kandidatList)
        {
            Id = id;
            Name = name;
            KandidatList = new List<Kandidat>(kandidatList);
        }
    }
}
