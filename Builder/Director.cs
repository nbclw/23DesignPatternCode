using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public void Building(Builder builder)
        {
            builder.BuildWall();
            builder.BuildDoor();
            builder.BuildWindows();
        }
    }
}
