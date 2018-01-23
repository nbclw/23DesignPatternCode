using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 创建型—工厂模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //工厂模式
            //BaseCarFactory carFactory = new SportCarFactory();
            //BaseCar car1 = carFactory.Create();
            //car1.GetCar();

            //carFactory = new JeepCarFactory();
            //BaseCar car2 = carFactory.Create();
            //car2.GetCar();

            //简单工厂模式
            SportCar car1 = CarFactory.CreateSport();
            car1.GetCar();

            JeepCar car2 = CarFactory.CreateJeep();
            car2.GetCar();

            Console.WriteLine("-----------end-----------");
            Console.ReadKey();
        }
    }
}
