using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternUdlejning
{
    public class DvdHandler : IObservable<Dvd>
    {
        private List<IObserver<Dvd>> observers;
        private List<Dvd> positions;

        public DvdHandler()
        {
            observers = new List<IObserver<Dvd>>();
            positions = new List<Dvd>();
        }

        public IDisposable Subscribe(IObserver<Dvd> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                // Provide observer with existing data.
                foreach (var item in positions)
                observer.OnNext(item);
            }
            return new Unsubscriber<Dvd>(observers, observer);
        }
    }
}
