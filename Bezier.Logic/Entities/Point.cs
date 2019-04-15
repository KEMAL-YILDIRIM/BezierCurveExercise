namespace Bezier.Logic.Entities
{
    //To ensure that control point will not change once created
    public class Point : IPoint
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }

        public double Y { get; }

    }
}
