using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SportCar : BaseCar
    {
        public override string GetCar()
        {
            return "跑车";
        }
    }
}
