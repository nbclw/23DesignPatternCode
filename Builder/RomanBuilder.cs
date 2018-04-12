using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class RomanBuilder : Builder
    {
        House house = new RomanHouse();
        public override void BuildDoor()
        {
            house.Door = "罗式门";
        }
        public override void BuildWall()
        {
            house.Wall = "罗式墙";
        }
        public override void BuildWindows()
        {
            house.Windows = "罗式窗户";
        }

        public override House GetHouse()
        {
            return house;
        }
    }
}
