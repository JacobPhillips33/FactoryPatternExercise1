using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise1
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle()
        {           
            
            Console.Write("Will your vehicle have 2 or 4 tires? ");
            
            bool inputParseable = false;
            int userTiresInput = 0;            
            while (!inputParseable)
            {
                inputParseable = int.TryParse(Console.ReadLine(), out userTiresInput);

                while (userTiresInput != 2 && userTiresInput != 4)
                {                    
                    Console.WriteLine("Invalid entry. Please try again.");
                    Console.Write("How many tires will your vehicle have? ");
                    inputParseable = int.TryParse(Console.ReadLine(), out userTiresInput);
                }
                
            }

            if (userTiresInput == 2)
            {
                return new Motorcycle();
            }
            return new Car();
        }
    }
}
