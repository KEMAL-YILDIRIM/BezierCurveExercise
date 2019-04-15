using Bezier.Logic.Infrastructure;
using NUnit.Framework;

namespace Bezier.Test.Logic.Infrastructure
{
    public class CubicBezierFormulaUnitTest
    {
        private CubicBezierFormula _cubicBezierFormula;
        [SetUp]
        public void Setup()
        {
            _cubicBezierFormula = new CubicBezierFormula();
        }

        //Simple Tests
        //Just to make sure if the formula is correctly working
        [Test]
        public void CubicBezierFormulaForPoint0T2IsValid()
        {
            double[] points = { 0, 0, 0, 0 };
            int interval = 2;
            var result = _cubicBezierFormula.CalculatePointUnit(points, interval);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void CubicBezierFormulaForPoint1T2IsValid()
        {
            double[] points = { 1, 1, 1, 1 };
            int interval = 2;
            var result = _cubicBezierFormula.CalculatePointUnit(points, interval);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void CubicBezierFormulaForPoint1T0IsValid()
        {
            double[] points = { 1, 1, 1, 1 };
            int interval = 0;
            var result = _cubicBezierFormula.CalculatePointUnit(points, interval);
            Assert.AreEqual(result, 1);
        }
    }
}
