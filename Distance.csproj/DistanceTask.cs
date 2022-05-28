using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
			double lengthAb = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2));
			double lengthBc = Math.Sqrt(Math.Pow((bx - x), 2) + Math.Pow((by - y), 2));
			double lengthCa = Math.Sqrt(Math.Pow((x - ax), 2) + Math.Pow((y - ay), 2));
			double Square;
			var findCosCa = ((x * ax) + (y * ay)) / (Math.Sqrt(x * x + y * y) * Math.Sqrt(ax * ax + ay * ay));
			var findCosBc = ((x * bx) + (y * by)) / (Math.Sqrt(x * x + y * y) * Math.Sqrt(bx * bx + by * by));
			if (ax == bx && ay == by)
				return lengthBc;
			if (Math.Acos(findCosCa) < 0)
			{
				return Math.Abs(lengthCa);
			}
			else if (Math.Acos(findCosBc) < 0)
			{
				return Math.Abs(lengthBc);
			}
			else if (Math.Acos(findCosBc) == 0)
			{
				return Math.Abs(lengthBc);
			}
			else
			{
				Square = 0.25 * Math.Sqrt((lengthAb + lengthBc + lengthCa) * (lengthBc + lengthCa - lengthAb) * (lengthAb + lengthCa - lengthBc) * (lengthAb + lengthBc - lengthCa));
			}
			var high = 2 * Square / lengthAb;
			if (lengthBc < lengthCa && lengthBc < high)
			{
				return lengthBc;
			}
			else if (lengthCa < lengthBc && lengthCa < high)
			{
				return lengthCa;
			}
			else 
			{
				return high;
			}
		
		}
	}
}