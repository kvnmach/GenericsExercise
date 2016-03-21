using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var OneStop = new Shop<Sedan>();
            var TwoStop = new Shop<RaceCar>();
            var ThreeStop = new Shop<Truck>();
            var truck = new Truck();
            var raceCar = new RaceCar();
            var sedan = new Sedan();
            List<TheVehicle> ThreeVehicles = new List<TheVehicle> {truck, raceCar, sedan};

            ThreeStop.IsNewOil(truck);
            ThreeStop.isFilledUp(truck);
            ThreeStop.AreTiresChanged(truck);
            Console.WriteLine();

            TwoStop.IsNewOil(RaceCar);
            TwoStop.isFilledUp(RaceCar);

        }
    }
}
