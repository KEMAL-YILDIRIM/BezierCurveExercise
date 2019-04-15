using Bezier.Logic.Entities;
using Bezier.Logic.Infrastructure;
using System;

namespace Bezier.Logic.Application
{
    public class CubicBezierCalculator : ICalculate, IDisposable
    {
        private ICalculatePointUnit _cubicBezierFormula;
        private IBezierParameters _cubicBezierParameters;
        private Point[] _points;
        private double[] xCoordinates;
        private double[] yCoordinates;

        /// <summary>
        /// Initialize cubic bezier curve points array sizes
        /// </summary>
        /// <param name="cubicBezierParameters"></param>
        /// <param name="cubicBezierFormula"></param>
        public CubicBezierCalculator(IBezierParameters cubicBezierParameters, ICalculatePointUnit cubicBezierFormula)
        {
            _cubicBezierFormula = cubicBezierFormula;
            _cubicBezierParameters = cubicBezierParameters;
            _points = new Point[_cubicBezierParameters.Interval];
            xCoordinates = new double[_cubicBezierParameters.Points.Length];
            yCoordinates = new double[_cubicBezierParameters.Points.Length];
        }

        /// <summary>
        /// Calculate the constructed point array and return the curve points
        /// </summary>
        /// <returns></returns>
        public Point[] Calculate()
        {
            double step = 1.0 / _cubicBezierParameters.Interval;
            double t = 0;

            for (int indexOfCoordinate = 0; indexOfCoordinate < _cubicBezierParameters.Points.Length; indexOfCoordinate++)
            {
                xCoordinates[indexOfCoordinate] = _cubicBezierParameters.Points[indexOfCoordinate].X;
                yCoordinates[indexOfCoordinate] = _cubicBezierParameters.Points[indexOfCoordinate].Y;
            }

            for (int indexOfPoint = 0; indexOfPoint < _cubicBezierParameters.Interval; indexOfPoint++)
            {

                t += step;
                double x = _cubicBezierFormula.CalculatePointUnit(
                    xCoordinates, t);
                double y = _cubicBezierFormula.CalculatePointUnit(
                    yCoordinates, t);

                _points[indexOfPoint] = new Point(x, y);
            }

            return _points;
        }

        // Flag: Has Dispose already been called?
        bool disposed = false;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            disposed = true;
        }
    }
}
