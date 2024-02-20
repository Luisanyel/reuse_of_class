using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reuse_of_class
{
    internal class Point2D : Point
    {
		protected int y;

		public int Y
		{
			get { return y; }
			set { y = value; }
		}
		public Point2D ():base()
		{
			Y = 0;
		}
		public Point2D(int x, int y):base(x)
		{
			this.y = y;
		}
        public override string ToString()
        {
            return base.ToString() + ", Y: " + y;
        }
        public double GetDistance(Point2D p)
        {
            return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
        }
    }
}
