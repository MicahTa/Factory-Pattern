﻿namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheals does your vehicle have?");
            string? input = Console.ReadLine();
            
            IVehicle? vehicle = VehicleFactory.GetVehicle(input);
            if (vehicle == null)
            {
                Console.WriteLine("No Vehicle Exists ): ");
            } else
            {
               Console.WriteLine(vehicle.type); 
            }
        }
    }
}
