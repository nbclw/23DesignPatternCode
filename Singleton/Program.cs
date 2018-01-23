using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Singleton
{
    /// <summary>
    /// 创建型—单例模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SingleClass.sd();

            Console.WriteLine("-----------end-----------");
            Console.ReadKey();
        }
    }
}
