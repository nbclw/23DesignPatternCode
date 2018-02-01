using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ChineseHouse : House
    {
        public override void BuildDoor()
        {
            base.Door = "中式门";
        }
        public override void BuildWall()
        {
            base.Wall = "中式墙";
        }
        public override void BuildWindows()
        {
            base.Windows = "中式窗户";
        }
    }
}
