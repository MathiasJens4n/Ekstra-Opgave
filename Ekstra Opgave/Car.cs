using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstra_Opgave
{
    internal class Car : Vehicle, IGasolineEngine
    {
        string registrationNumber;
        string registrationYear;

        IEngine engine;
        GearBox gearBox = new GearBox();

        Wheel wheel1 = new Wheel();
        Wheel wheel2 = new Wheel();
        Wheel wheel3 = new Wheel();
        Wheel wheel4 = new Wheel();

        public void Start()
        {

        }

        public void Inject()
        {
            
        }

        public void TurnOff()
        {
            
        }

        internal Car()
        {

        }
        public Car(string color)
        {

        }
        public Car(string color, float size)
        {

        }

    }
}
