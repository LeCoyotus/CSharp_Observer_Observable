using System;
using System.Collections.Generic;
using System.Text;

namespace ExoObservableTel
{
    public class Personne : IObserver
    {
        public string Nom { get; }

        public Telephone Mobile { get; set; }

        public Personne(string nom)
        {
            Nom = nom;
            Mobile = null;
        }

        public void Content()
        {
            Console.WriteLine(Nom + " : c'est mon tel id " + Mobile.Id + ". Sah quel plaisir !");
        }

        public void Enerve()
        {
            Console.WriteLine(Nom + " : Le telephone avec l'id : " + Mobile.Id + " n'est pas mon tel, je vais te hagar !");
        }
        public void Notify(IObservable telephone)
        {
            if(Check((Telephone)telephone))
            {
                Content();
            }
            else
            {
                Enerve();
            }
        }

        public bool Check(Telephone telephone)
        {
            return (telephone.Id == this.Mobile.Id) ? true : false;
        }
    }
}
