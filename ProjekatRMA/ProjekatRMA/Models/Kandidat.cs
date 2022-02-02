using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatRMA.Models
{
    public class Kandidat
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Kandidat(int id, string name)
        {
            Id = id;
            FullName = name;
        }
    }
}
