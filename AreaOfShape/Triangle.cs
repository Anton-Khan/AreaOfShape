namespace AreaOfShape
{
    public class Triangle : IShapeWithArea
    {
        private const string errorMessage = "Sides of triangle must be greater than 0";
        public Triangle(double a, double b, double c)
        {
            ValidateSidesLength(a, b, c);
            ValidateTriangle();

            A = a;
            B = b;
            C = c;
        }

        public double A { get; }
        public double B { get; }
        public double C { get; }

        private void ValidateSidesLength(double a, double b, double c)
        {
            if (a <= 0)
                throw new ArgumentOutOfRangeException(nameof(a), errorMessage);
            if (b <= 0)
                throw new ArgumentOutOfRangeException(nameof(b), errorMessage);
            if (c <= 0)
                throw new ArgumentOutOfRangeException(nameof(c), errorMessage);
        }

        private void ValidateTriangle()
        {
            var sides = new[] { A, B, C }.OrderBy(x => x).ToArray();
            if(sides[0] + sides[1] > sides[2])
                throw new ArgumentException("Triangle with these sides cannot exist.");
        }

        public bool IsRightAngled()
        {
            var sides = new[] { A, B, C }.OrderBy(x => x).ToArray();
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        protected double GetHalfOfPerimeter()
        {
            return (A + B + C) / 2;
        }

        public double CalculateArea()
        {
            double halfOfPerimeter = GetHalfOfPerimeter();
            return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - A) * (halfOfPerimeter - B) * (halfOfPerimeter - C));
        }  
    }
}
