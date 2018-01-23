using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CarFactory
    {
        public static SportCar CreateSport()
        {
            return new SportCar();
        }
        public static JeepCar CreateJeep()
        {
            return new JeepCar();
        }
    }
}
