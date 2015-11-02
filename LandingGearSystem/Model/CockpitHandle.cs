using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingGearSystem.Model
{
    class CockpitHandle : IObservable<HandleState>
    {
        private static CockpitHandle instance;
        public static CockpitHandle Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CockpitHandle();
                }
                return instance;
            }
        }

        private HandleState state;
        public HandleState State {
            get
            {
                return state;
            }
            set
            {
                state = value;
                foreach (IObserver<HandleState> observer in observers)
                {
                    observer.OnNext(state);
                }
            }
        }

        private List<IObserver<HandleState>> observers;

        public CockpitHandle()
        {
            observers = new List<IObserver<HandleState>>();
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<HandleState>> _observers;
            private IObserver<HandleState> _observer;

            public Unsubscriber(List<IObserver<HandleState>> observers, IObserver<HandleState> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (!(_observer == null)) _observers.Remove(_observer);
            }
        }

        public IDisposable Subscribe(IObserver<HandleState> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }
    
    }
}
