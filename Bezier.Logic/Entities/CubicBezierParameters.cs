using System.Collections.Generic;

namespace Bezier.Logic.Entities
{
    public class CubicBezierParameters : BezierParameters
    {
        public override ICollection<Point> Points => new Point[4];

        public CubicBezierParameters(Point[] points, int interval)
        {
            Points = new Point[4];
            Points = points;
            Interval = interval;
        }
    }
}
