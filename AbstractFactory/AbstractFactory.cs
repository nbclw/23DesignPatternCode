using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract BaseCar CreateCar();
        public abstract BaseCushion CreateCushion();
    }

    public class Factory1 : AbstractFactory
    {
        public override BaseCar CreateCar()
        {
            return new JeepCar();
        }
        public override BaseCushion CreateCushion()
        {
            return new LeatherCushion();
        }
    }
}
