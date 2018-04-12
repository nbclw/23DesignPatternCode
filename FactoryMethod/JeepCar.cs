using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class JeepCar : BaseCar
    {
        public override void GetCar()
        {
            Console.WriteLine("这是一辆吉普车！");
        }
    }
}
