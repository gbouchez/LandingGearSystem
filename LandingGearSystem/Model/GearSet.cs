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

        public List<Gear> Gears { get; set; }

        public GearSet()
        {
            Gears = new List<Gear>();
            byte i;
            for (i = 3; i > 0; i--)
            {
                Gear gear = new Gear();
                Door door = new Door();
                gear.Door = door;
                door.Gear = gear;
                Gears.Add(gear);
            }
        }


        private IDisposable unsubscriber;

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
