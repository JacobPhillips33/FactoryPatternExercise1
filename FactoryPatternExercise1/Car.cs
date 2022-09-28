using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise1
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new car!");
        }
    }
}
