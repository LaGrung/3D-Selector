using System;
using System.Collections.Generic;
using System.Text;

namespace _3d_Selector
{
    class Params
    {
		public Params(int x, int y, int radius, string systemName, string customName, string image)
        {
			this.x = x;
			this.y = y;
			this.radius = radius;
			this.systemName = systemName;
			this.customName = customName;
			this.image = image;
        }
		public int x { get; set; }
		public int y { get; set; }
		public int radius { get; set; }
		public string systemName { get; set; }
		public string customName { get; set; }
		public string image { get; set; }
	}
}
