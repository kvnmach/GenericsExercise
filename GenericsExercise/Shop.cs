using System;

namespace GenericsExercise
{
    public class Shop<T> where T : TheVehicle
    {
        public void isFilledUp(T TheVehicle)
        {
            TheVehicle.isFilledUp = true;
            Console.WriteLine($" The{TheVehicle} had its gas tank filled ");
        }
        public void isNewOil 
    }
}