﻿using System;

namespace GenericsExercise
{
    public class Shop<T> where T : TheVehicle
    {
        public void isFilledUp(T TheVehicle)
        {
            TheVehicle.IsFilledUp = false;
            Console.WriteLine($"The {TheVehicle} had its {TheVehicle.TypeOfGas} filled up");
        }

        public void IsNewOil(T TheVehicle)
        {
            TheVehicle.IsNewOil = false;
            Console.WriteLine($"The {TheVehicle} had its oil changed");
        }
    }

    public static class ShopExtension
    {
        public static void AreTiresChanged<T>(this Shop<T> shop, T TheVehicle) where T : TheVehicle

        {
            TheVehicle.AreTiresChanged = false;
            Console.WriteLine($"The {TheVehicle} had its Tires Serviced")
        }
    }

    
}