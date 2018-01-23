using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class SingleClass
    {
        private static readonly SingleClass _single = null;
        static SingleClass()
        {
            _single = new SingleClass();
            Console.WriteLine("Create");
        }
        public static void sd(){}
    }
}
