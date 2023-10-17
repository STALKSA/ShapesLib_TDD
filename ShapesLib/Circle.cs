namespace ShapesLib
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {

            //throw new ArgumentException("Радиус не может быть бесконечностью.");

            if (double.IsInfinity(radius))
            {
                throw new ArgumentException("Радиус не может быть бесконечностью.");

            }


            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным конечным числом.");
            }

            Radius = radius;


        }

        public double Area => CalculateArea();

        private double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}
