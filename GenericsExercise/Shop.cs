using System;

namespace GenericsExercise
{
    public class Shop<T> where T : TheVehicle
    {
        public void isFilledUp(T TheVehicle)
        {
            TheVehicle.IsFilledUp = false;
            Console.WriteLine($"The {TheVehicle} had its gas filled up");
        }

        public void AreOilChanged(T TheVehicle)
        {
            TheVehicle.AreTiresChanged = false;
            Console.WriteLine($"The {TheVehicle} had its oil changed");
        }
    }


}