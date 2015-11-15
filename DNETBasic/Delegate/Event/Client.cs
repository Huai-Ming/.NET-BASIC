using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Event
{
    public class Client
    {
        public static void Main()
        {
            var dealer = new CarDealer();

            var michael = new Consumer("Michael");
            dealer.NewCarInfo += michael.NewCarIsHere;

            dealer.NewCar("Mercedes");

            var nick = new Consumer("Nick");
            dealer.NewCarInfo += nick.NewCarIsHere;

            dealer.NewCar("Ferrari");

            dealer.NewCarInfo -= michael.NewCarIsHere;

            dealer.NewCar("Toyota");

            Console.ReadKey();
        }
    }
}
