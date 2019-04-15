using System.Collections.Generic;

namespace Bezier.Logic.Entities
{
    public interface IBezierParameters
    {
        int Interval { get; }
        Point[] Points { get; }
    }
}