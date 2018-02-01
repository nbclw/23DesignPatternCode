using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class RomanHouse : House
    {
        public override void BuildDoor()
        {
            base.Door = "罗式门";
        }
        public override void BuildWall()
        {
            base.Wall = "罗式墙";
        }
        public override void BuildWindows()
        {
            base.Windows = "罗式窗户";
        }
    }
}
