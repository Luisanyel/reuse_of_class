using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reuse_of_class
{
    internal class Point
    {
        //prop
		protected int x;
		public int X
		{
			get { return x; }
			set { x = value; }
		}
        //constructor
        public Point()
        {
            x = 0;
        }
        public Point (int x)
	    {
			this .x = x;	
		}
        //methods
        public override string ToString()
        {
            return " X: " + x;
        }
        public int GetDistance(Point p)
        { return Math.Abs (x - p.x); }
    }
}
