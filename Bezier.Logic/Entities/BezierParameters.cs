using System.Collections.Generic;

namespace Bezier.Logic.Entities
{
    public abstract class BezierParameters
    {
        public BezierParameters(List<Point> points, int interval)
        {
            Points = points;
            Interval = interval;
        }

        public List<Point> Points { get; }
        public int Interval { get; }
    }
}
