using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LandingGearSystem.Model
{
    /// <summary>
    /// The gear extends IObservable, that way we have an <see cref="GearObserver"/> to watch it
    /// </summary>
    class Gear : IObservable<GearState>
    {
        public Door Door { get; set; }

        public GearController Controller { get; set; }

        private GearState state = GearState.LOCKUP;
        public GearState GearState
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                foreach (IObserver<GearState> observer in observers)
                {
                    observer.OnNext(state);
                }
            }
        }

        #region Observer
        private List<IObserver<GearState>> observers = new List<IObserver<GearState>>();
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<GearState>> _observers;
            private IObserver<GearState> _observer;

            public Unsubscriber(List<IObserver<GearState>> observers, IObserver<GearState> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (!(_observer == null)) _observers.Remove(_observer);
            }
        }

        public IDisposable Subscribe(IObserver<GearState> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }
        #endregion

        public Gear(GearController controller)
        {
            Controller = controller;
            Door = new Door(this);
        }
        /// <summary>
        /// Deploy the gear. If the precontitions are met
        /// </summary>
        public void Deploy()
        {
            if (GearState == GearState.LOCKDOWN)
            {
                return;
            }
            if (!Controller.ShouldDeploy)
            {
                return;
            }
            if (Door.DoorState != DoorState.DOWN)
            {
                Door.Open();
            }
            if (!Controller.ShouldDeploy)
            {
                return;
            }
            GearState = GearState.MOVING;
            Thread.Sleep(1000);
            GearState = GearState.LOCKDOWN;
            if (!Controller.ShouldDeploy)
            {
                return;
            }
            if (Door.DoorState != DoorState.LOCKUP)
            {
                Door.Close();
            }
            Controller.ShouldDeploy = false;
            return;
        }
        /// <summary>
        /// Retracts the gear, if the conditions are met.
        /// </summary>
        public void Retract()
        {
            if (GearState == GearState.LOCKUP)
            {
                return;
            }
            if (!Controller.ShouldRetract)
            {
                return;
            }
            if (Door.DoorState != DoorState.DOWN)
            {
                Door.Open();
            }
            if (!Controller.ShouldRetract)
            {
                return;
            }
            GearState = GearState.MOVING;
            Thread.Sleep(1000);
            GearState = GearState.LOCKUP;
            if (!Controller.ShouldRetract)
            {
                return;
            }
            if (Door.DoorState != DoorState.LOCKUP)
            {
                Door.Close();
            }
            Controller.ShouldRetract = false;
            return;
        }
    }
}
