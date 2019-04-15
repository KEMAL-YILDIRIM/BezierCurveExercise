using Bezier.Logic.Entities;
using Bezier.Logic.Infrastructure;
using System;
using System.Collections.Generic;

namespace Bezier.Logic.Application
{
    public class CubicBezierCalculator : ICalculate, IDisposable
    {
        private ICalculatePointUnit _cubicBezierFormula;
        private IBezierParameters _cubicBezierParameters;
        private Point[] _points;

        public CubicBezierCalculator(IBezierParameters cubicBezierParameters, ICalculatePointUnit cubicBezierFormula)
        {
            _cubicBezierFormula = cubicBezierFormula;
            _cubicBezierParameters = cubicBezierParameters;
            _points = new Point[_cubicBezierParameters.Interval];
        }

        public Point[] Calculate()
        {
            double step = 1.0 / _cubicBezierParameters.Interval;
            double t = 0;

            for (int i = 0; i < _cubicBezierParameters.Interval; i++)
            {
                t += step;
                double x = CubicBezierFormula(pointStart.X, point1.X, point2.X, pointEnd.X, t);
                double y = CubicBezierFormula(pointStart.Y, point1.Y, point2.Y, pointEnd.Y, t);
                _points[i] = new Point(x,y);
            }

            return _cubicBezierParameters.Points;
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
