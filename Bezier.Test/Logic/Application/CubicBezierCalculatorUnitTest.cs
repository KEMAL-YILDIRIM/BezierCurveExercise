using Bezier.Logic.Application;
using Bezier.Logic.Entities;
using Bezier.Logic.Infrastructure;
using NUnit.Framework;

namespace Bezier.Test.Logic.Application
{
    public class CubicBezierCalculatorUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void CubicBezierCalculatedArraySizeIsValid()
        {
            Point[] points = {
                    new Point(0, 0),
                    new Point(25, 50),
                    new Point(50, 100),
                    new Point(100, 100) };
            int interval = 2;

            ICalculatePointUnit cubicBezierFormula = new CubicBezierFormula();
            IBezierParameters cubicBezierParameters = new CubicBezierParameters(points, interval);

            CubicBezierCalculator cubicBezierCalculator = new CubicBezierCalculator(
               cubicBezierParameters,
               cubicBezierFormula
                );
            var result = cubicBezierCalculator.Calculate();
            Assert.AreEqual(2, result.Length);
        }


        [Test]
        public void CubicBezierCalculatedPoint1IsValid()
        {
            Point[] points = {
                    new Point(0, 0),
                    new Point(25, 50),
                    new Point(50, 100),
                    new Point(100, 100) };
            int interval = 2;

            ICalculatePointUnit cubicBezierFormula = new CubicBezierFormula();
            IBezierParameters cubicBezierParameters = new CubicBezierParameters(points, interval);

            CubicBezierCalculator cubicBezierCalculator = new CubicBezierCalculator(
               cubicBezierParameters,
               cubicBezierFormula
                );
            var result = cubicBezierCalculator.Calculate();
            var firstPoint = new Point(40.625, 68.75);
            Assert.AreEqual(firstPoint.X, result[0].X);
            Assert.AreEqual(firstPoint.Y, result[0].Y);
        }
    }
}
