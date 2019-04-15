using Bezier.Logic.Entities;
using Bezier.Logic.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bezier.Logic.Application
{
    /// <summary>
    /// Cubic Bezier Formulation
    /// </summary>
    public sealed class CubicBezierFormula : ICalculatePointUnit
    {
        public double CalculatePointUnit(double[] pointUnits, int interval)
        {
                double part1 = Math.Pow((1 - interval), 3) * pointUnits[0];
                double part2 = 3 * Math.Pow((1 - interval), 2) * interval * pointUnits[1];
                double part3 = 3 * (1 - interval) * Math.Pow(interval, 2) * pointUnits[2];
                double part4 = Math.Pow(interval, 3) * pointUnits[3];
                double result = part1 + part2 + part3 + part4;
                return result;
        }
    }
}
