using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class House
    {
        #region 门、墙、窗户
        private string _door;

        public string Door
        {
            get { return _door; }
            set { _door = value; }
        }

        private string _wall;

        public string Wall
        {
            get { return _wall; }
            set { _wall = value; }
        }

        private string _windows;

        public string Windows
        {
            get { return _windows; }
            set { _windows = value; }
        }
        #endregion
        public abstract void BuildDoor();
        public abstract void BuildWall();
        public abstract void BuildWindows();

        public abstract House GetHouse();
    }
}
