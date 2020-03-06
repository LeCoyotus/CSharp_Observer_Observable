using System;
using System.Collections.Generic;
using System.Text;

namespace ExoObservableTel
{
    public enum EtatTel
    {
        NONE,
        ETEINT,
        SONNE
    }
    public class Telephone : IObservable
    {
        private EtatTel etat;
        public EtatTel Etat
        {
            get
            {
                return etat;
            }
            set
            {
                etat = value;
                NotifyAll();
            }
        }

        public int Id { get; }

        public List<IObserver> Observer;
        public Telephone()
        {
            etat = EtatTel.ETEINT;
            Id = Utils.Roll(1000);
            Observer = new List<IObserver>();
        }

        public void NotifyAll()
        {
            foreach(IObserver elt in Observer)
            {
                elt.Notify(this);
            }
        }

        public void AddObserver(IObserver personne)
        {
            Observer.Add(personne);
        }
        public void RemoveObserver(IObserver personne)
        {
            Observer.Remove(personne);
        }
    }
}
