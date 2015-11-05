using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingGearSystem.Model
{
    class GearObserver : IObserver<GearState>
    {
        public GearController Controller;
        private IDisposable unsubscriber;

        public virtual void Subscribe(IObservable<GearState> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public void OnNext(GearState value)
        {
            Controller.ComputeLightStates();
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
