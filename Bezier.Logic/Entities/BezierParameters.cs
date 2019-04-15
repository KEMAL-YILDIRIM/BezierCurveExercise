using System.Collections.Generic;

namespace Bezier.Logic.Entities
{
    public abstract class BezierParameters : IBezierParameters
    {
        public virtual ICollection<Point> Points { get; set; }
        public int Interval { get; set; }
    }
}
