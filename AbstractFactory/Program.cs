using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 创建型—抽象工厂
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new Factory1();
            BaseCar car = factory.CreateCar();
            BaseCushion cushion = factory.CreateCushion();

            Console.WriteLine("坐垫是{0}的{1}！", cushion.GetCushionType(), car.GetCar());

            Console.WriteLine("-----------end-----------");
            Console.ReadKey();
        }
    }
}
