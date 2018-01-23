using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class JeepCar : BaseCar
    {
        public override string GetCar()
        {
            return "吉普车";
        }
    }
}
