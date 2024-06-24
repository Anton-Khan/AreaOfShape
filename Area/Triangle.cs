namespace AreaOfShape
{
    public class Triangle : IShapeWithArea
    {
        public Triangle(double a, double b, double c)
        {
            if (a <= 0)
                throw new ArgumentOutOfRangeException(nameof(a), "Sides of triangle must be greater than 0");
            if (b <= 0)
                throw new ArgumentOutOfRangeException(nameof(b), "Sides of triangle must be greater than 0");
            if (c <= 0)
                throw new ArgumentOutOfRangeException(nameof(c), "Sides of triangle must be greater than 0");

            A = a;
            B = b;
            C = c;
        }

        public double A { get; }
        public double B { get; }
        public double C { get; }

        public bool IsEquilateral()
        {
            return A == B && B == C;
        }

        public bool IsIsosceles()
        {
            return A == B || B == C || A == C;
        }

        public bool IsRightAngled()
        {
            var sides = new[] { A, B, C }.OrderBy(x => x).ToArray();
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        public double GetHalfOfPerimeter()
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
