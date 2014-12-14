using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternUdlejning
{
    internal class Unsubscriber<Dvd> : IDisposable
    {
        private List<IObserver<Dvd>> _observers;
        private IObserver<Dvd> _observer;

        internal Unsubscriber(List<IObserver<Dvd>> observers, IObserver<Dvd> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
