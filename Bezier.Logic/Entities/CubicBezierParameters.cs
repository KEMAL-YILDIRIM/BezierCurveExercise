using System.Collections.Generic;

namespace Bezier.Logic.Entities
{
    public class CubicBezierParameters : IBezierParameters
    {
        public CubicBezierParameters(Point[] points, int interval)
        {
            Points = points;
            Interval = interval;
        }

        public Point[] Points { get; }
        public int Interval { get; }
    }
}
