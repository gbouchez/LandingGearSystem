using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingGearSystem.Model
{
    class GearSet : IObserver<HandleState>
    {
        private static GearSet instance;
        public static GearSet Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GearSet();
                }
                return instance;
            }
        }

        private IDisposable unsubscriber;
        private HandleState last;

        public virtual void Subscribe(IObservable<HandleState> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public void OnNext(HandleState value)
        {
            last = value;
        }

        public void OnError(Exception error)
        {
            // TODO Error management
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            unsubscriber.Dispose();
        }
    }
}
