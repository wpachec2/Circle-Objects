using System;
namespace CircleObjects
{
	public class Circle
	{
		public double radius { get; set; }

        public Circle(double _radius)
		{
			radius = _radius;
		}

		public double CalculateCircumference()
		{
			return 2 * Math.PI * radius;
		}
		public string CalculateFormattedCircumference()
		{
			return FormattedNumber(CalculateCircumference());
		}


		public double CalculateArea()
		{
			return Math.PI * Math.Pow(radius, 2);
		}
		public string CalculateFormattedArea()
		{
			return FormattedNumber(CalculateArea());
		}


        private string FormattedNumber(double x)
		{
			string FormattedArea = Math.Round(x, 2).ToString();
			return FormattedArea;
		}
    }
}