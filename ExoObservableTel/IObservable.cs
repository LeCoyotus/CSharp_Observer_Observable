using System;
using System.Collections.Generic;
using System.Text;

namespace ExoObservableTel
{
    public interface IObservable
    {
        public void AddObserver(IObserver<Telephone> observer) { }
        public void RemoveObserver(IObserver<Telephone> observer) { }

        public void NotifyAll() { }
    }
}