using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 创建型—建造者模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Builder chBuilder = new ChineseBuilder();
            Builder roBuilder = new RomanBuilder();

            director.Building(chBuilder);
            House chHouse = chBuilder.GetHouse();
            Console.WriteLine(chHouse.Door);
            Console.WriteLine(chHouse.Wall);
            Console.WriteLine(chHouse.Windows);

            Console.WriteLine("-------------------------");

            director.Building(roBuilder);
            House roHouse = roBuilder.GetHouse();
            Console.WriteLine(roHouse.Door);
            Console.WriteLine(roHouse.Wall);
            Console.WriteLine(roHouse.Windows);

            Console.WriteLine("-----------end-----------");
            Console.ReadKey();
        }
    }
}
