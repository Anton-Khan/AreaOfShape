using AreaOfShape;

var shapes = new List<IShapeWithArea>();

shapes.Add(new Triangle(3, 5, 4));
shapes.Add(new Circle(10));

foreach(var shape in shapes)
    Console.WriteLine(shape.CalculateArea());