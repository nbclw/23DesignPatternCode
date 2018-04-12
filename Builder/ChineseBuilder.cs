using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ChineseBuilder : Builder
    {
        House house = new ChineseHouse();
        public override void BuildDoor()
        {
            house.Door = "中式门";
        }
        public override void BuildWall()
        {
            house.Wall = "中式墙";
        }
        public override void BuildWindows()
        {
            house.Windows = "中式窗户";
        }

        public override House GetHouse()
        {
            return house;
        }
    }
}
