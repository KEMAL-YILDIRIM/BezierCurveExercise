using Bezier.Logic.Application;
using Bezier.Logic.Entities;
using Bezier.Logic.Infrastructure;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bezier.WinForm.Forms
{
    public partial class BezierIO : Form
    {
        public BezierIO()
        {
            InitializeComponent();
        }

        private void pictureBoxDisplayBezier_Paint(object sender, PaintEventArgs e)
        {
            Logic.Entities.Point[] points = {
                    new Logic.Entities.Point(
                        Convert.ToDouble(numericStartPointX.Value),
                        Convert.ToDouble(numericStartPointY.Value)),
                    new Logic.Entities.Point(
                        Convert.ToDouble(numericControlPoint1X.Value),
                        Convert.ToDouble(numericControlPoint1Y.Value)),
                    new Logic.Entities.Point(
                        Convert.ToDouble(numericControlPoint2X.Value),
                        Convert.ToDouble(numericControlPoint2Y.Value)),
                    new Logic.Entities.Point(
                        Convert.ToDouble(numericEndPointX.Value),
                        Convert.ToDouble(numericEndPointY.Value)) };
            int interval = Convert.ToInt32(numericInterval.Value);


            //Using IoC can decouple the dependency here
            ICalculatePointUnit cubicBezierFormula = new CubicBezierFormula();
            IBezierParameters cubicBezierParameters = new CubicBezierParameters(points, interval);
            ICalculate cubicBezierCalculator = new CubicBezierCalculator(
               cubicBezierParameters,
               cubicBezierFormula
                );

            var generatedPoints = cubicBezierCalculator.Calculate();

            //Execute the required conversion for draw class can be done with different ways
            var FloatPoints = generatedPoints.Select(point => new PointF
            {
                X = Convert.ToSingle(point.X),
                Y = Convert.ToSingle(point.Y)
            })
            .ToArray();
            Graphics g = e.Graphics;
            e.Graphics.DrawLines(SystemPens.Highlight, FloatPoints);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            pictureBoxDisplayBezier.Refresh();
        }

        private void BezierIO_Load(object sender, EventArgs e)
        {
            //Didn't do any validation for inputs but it needs to be done
            numericStartPointX.Value = 0;
            numericStartPointY.Value = 0;
            numericControlPoint1X.Value = 50;
            numericControlPoint1Y.Value = 0;
            numericControlPoint2X.Value = 50;
            numericControlPoint2Y.Value = 100;
            numericEndPointX.Value = 100;
            numericEndPointY.Value = 100;
            numericInterval.Value = 100;
        }
    }
}
