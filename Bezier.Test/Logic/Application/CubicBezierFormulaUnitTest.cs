using Bezier.Logic.Application;
using Bezier.Logic.Entities;
using Bezier.Logic.Infrastructure;
using NUnit.Framework;

namespace Bezier.Test.Logic.Application
{
    public class CubicBezierFormulaUnitTest
    {
        private CubicBezierCalculator cubicBezierCalculator;

        [SetUp]
        public void Setup()
        {
        }

        //Simple Tests
        //Just to make sure if the formula is correctly working
        [Test]
        public void CubicBezierTestPoint0()
        {
            Point[] points = {
                new Point(0,0),
                new Point(0, 0),
                new Point(0, 0),
                new Point(0, 0) };
            ICalculatePointUnit cubicBezierFormula = new CubicBezierFormula();
            IBezierParameters cubicBezierParameters = new CubicBezierParameters(points,2);

            using (cubicBezierCalculator = new CubicBezierCalculator(
               cubicBezierParameters, cubicBezierFormula
                ))
            {

            }
            var result = .CubicBezierFormula();
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void CubicBezierTestPoint1()
        {

            var result = cubicBezierCalculator.CubicBezierFormula(1, 1, 1, 1, 2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void CubicBezierTestPoint1T0()
        {
            var result = cubicBezierCalculator.CubicBezierFormula(1, 1, 1, 1, 0);
            Assert.AreEqual(result, 1);
        }


        //[Test]
        //public void CubicBezierTestPoint1T0()
        //{
        //    //ilk nokta t0 00 noktasi olcak son nokta 100 100 olcak
        //    //point array burdan kontrol edilecek
        //    var result = bezierProcessor.CubicBezier(1, 1, 1, 1, 0);
        //    result[0] = Point(0, 0);
        //    result[n] = Point(n, n);
        //    Assert.AreEqual(result, 1);
        //}
    }
}
