using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class JeepCarFactory : BaseCarFactory
    {
        public override BaseCar Create()
        {
            return new JeepCar();
        }
    }
}
