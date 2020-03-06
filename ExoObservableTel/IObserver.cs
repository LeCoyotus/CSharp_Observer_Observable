using System;
using System.Collections.Generic;
using System.Text;

namespace ExoObservableTel
{
    public interface IObserver
    {
        public void Notify(IObservable observable) { }
    }
}
