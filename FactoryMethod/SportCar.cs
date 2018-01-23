using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SportCar : BaseCar
    {
        public override void GetCar()
        {
            Console.WriteLine("这是一辆跑车！");
        }
    }
}
