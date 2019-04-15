using Bezier.Logic.Entities;
using System.Collections.Generic;

namespace Bezier.Logic.Infrastructure
{
    /// <summary>
    /// Bezier Formula parameters definitions
    /// </summary>
    public interface IBezier
    {
        List<Point> GetControlPoints();
        int GetInterval();
        string SetControlPoints(List<Point> controlPoints);
        string SetInterval(int interval);
    }
}
