using Bezier.Logic.Entities;
using Bezier.Logic.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bezier.Logic.Application
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class CubicBezierFormula,ICalculate
    {
        public CubicBezierFormula(double pointUnit,int interval)
        {
        }

        public double Calculate()
        {
            foreach (var point in Points)
            {
                double part1 = Math.Pow((1 - Interval), 3) * Points[0];
                double part2 = 3 * Math.Pow((1 - Interval), 2) * t * Points[1];
                double part3 = 3 * (1 - Interval) * Math.Pow(Interval, 2) * Points[2];
                double part4 = Math.Pow(Interval, 3) * Points[0];
                double result = part1 + part2 + part3 + part4;
            }

            return result;
        }
    }
}
