using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BambooCushion : BaseCushion
    {
        public override string GetCushionType()
        {
            return "竹垫";
        }
    }
}
