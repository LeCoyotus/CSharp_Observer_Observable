using System;
using System.Collections.Generic;

namespace ExoObservableTel
{
    class Program
    {
        static string[] MonTableauDeNom = { "Patrick", "Francis", "Gerrard", "Jon", "Jean" };
        static List<Personne> LesGens = new List<Personne>();
        static List<Telephone> LesMobiles = new List<Telephone>();
        static void Main(string[] args)
        {

            Init();
            VariationTel();

        }

        public static Telephone CreateTel()
        {
            return new Telephone();
        }

        public static Personne CreatePer()
        {
            return new Personne(MonTableauDeNom[Utils.SelectName()]);
        }

        public static void Init()
        {
            int n = 0;

            for (int i = 0; i < 4; i++)
            {
                LesGens.Add(CreatePer());
                LesMobiles.Add(CreateTel());
            }

            foreach(Telephone elt in LesMobiles)
            {
                foreach(IObserver per in LesGens)
                {
                    elt.AddObserver(per);
                }
            }

            foreach(Personne per in LesGens)
            {
                per.Mobile = LesMobiles[n];
                n++;
            }
        }


        public static void VariationTel()
        {
            for(int i = 0; i < 20; i++)
            {
                foreach(Telephone elt in LesMobiles)
                {
                    elt.Etat = (Utils.Roll() == 1) ? EtatTel.SONNE : EtatTel.ETEINT;
                }
            }
        }
    }
}
