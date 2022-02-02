using ProjekatRMA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjekatRMA.Views
{
    public static class LeftToVote
    {
        public static ObservableCollection<string> Rezultati = new ObservableCollection<string>();
        public static List<Pozicija> PozicijaList = new List<Pozicija>();
        public static List<Stranka> NewStrankaList = new List<Stranka>();
        public static List<Kandidat> NewKandidatList = new List<Kandidat>();
        public static bool voted = false;
        static LeftToVote()
        {
            NewKandidatList.Add(new Kandidat(1, "Bakir Izetbegović"));
            NewStrankaList.Add(new Stranka(1, "SDA", NewKandidatList));
            NewKandidatList.Clear();
            NewKandidatList.Add(new Kandidat(1, "Milorad Dodik"));
            NewStrankaList.Add(new Stranka(2, "SNSD", NewKandidatList));
            NewKandidatList.Clear();
            NewKandidatList.Add(new Kandidat(1, "Dragan Čović"));
            NewStrankaList.Add(new Stranka(3, "HDZ", NewKandidatList));
            NewKandidatList.Clear();

            PozicijaList.Add(new Pozicija(1, "Predsjedništvo", NewStrankaList));
            NewStrankaList.Clear();

            NewKandidatList.Add(new Kandidat(1, "Amir Mrkonjić"));
            NewKandidatList.Add(new Kandidat(2, "Amar Lagumdžija"));
            NewKandidatList.Add(new Kandidat(3, "Mirza Babić"));
            NewStrankaList.Add(new Stranka(1, "SDA", NewKandidatList));
            NewKandidatList.Clear();
            NewKandidatList.Add(new Kandidat(1, "Lejla Vardo"));
            NewKandidatList.Add(new Kandidat(2, "Džana Spahović"));
            NewKandidatList.Add(new Kandidat(3, "Dženan Beganović"));
            NewStrankaList.Add(new Stranka(2, "SNSD", NewKandidatList));
            NewKandidatList.Clear();
            NewKandidatList.Add(new Kandidat(1, "Imran Džanović"));
            NewKandidatList.Add(new Kandidat(2, "Alem Duraković"));
            NewKandidatList.Add(new Kandidat(3, "Tarik Valjevac"));
            NewStrankaList.Add(new Stranka(3, "HDZ", NewKandidatList));
            NewKandidatList.Clear();

            PozicijaList.Add(new Pozicija(2, "Parlament", NewStrankaList));
            NewStrankaList.Clear();
        }


    }
}
