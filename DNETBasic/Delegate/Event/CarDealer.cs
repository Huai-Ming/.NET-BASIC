using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Event
{
    public class CarInfoEventArgs: EventArgs
    {
        public string Car { get; set; }
        public CarInfoEventArgs(string car)
        {
            this.Car = car;
        }
    }
    public class CarDealer
    {
        public event EventHandler<CarInfoEventArgs> NewCarInfo;

        public void NewCar(string car)
        {
            Console.WriteLine("CarDealer, new car {0}", car);

            if(NewCarInfo!= null)
            {
                NewCarInfo(this, new CarInfoEventArgs(car));
            }
        }
    }
}
