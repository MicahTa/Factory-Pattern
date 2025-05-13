using System.Runtime.Serialization;

namespace FactoryPattern
{
    public class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("How many wheals does your vehicle have?");
            string? input = Console.ReadLine();
            
            IVehicle? vehicle = VehicleFactory.GetVehicle(input);
            if (vehicle == null) {
                Console.WriteLine("No Vehicle Excists ): ");
                return 0;
            }
            
            Console.WriteLine(vehicle.type);
            return 1;

        }
    }
}
