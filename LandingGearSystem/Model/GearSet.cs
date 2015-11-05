﻿using System;
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
        public Gear LeftGear;
        public Gear RightGear;
        public Gear FrontGear;

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
                gear.Position = i;
                Gears.Add(gear);
                switch (i)
                {
                    case 3:
                        FrontGear = gear;
                        break;
                    case 2:
                        LeftGear = gear;
                        break;
                    case 1:
                        RightGear = gear;
                        break;
                }
                gear.Init();
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
            foreach (Gear gear in Gears)
            {
                if (HandleState.UP == value)
                {
                    gear.Deploy();
                }
                else
                {
                    gear.Retract();
                }
            }
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