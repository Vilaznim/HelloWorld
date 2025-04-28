namespace Day4;
    // Shape exercise
    public abstract class Shape {
        public string Name { get; }
        protected Shape(string name) => Name = name;
        public abstract double Area();
    }

    // 2) Circle subclass
    public class Circle : Shape {
        public double Radius { get; }
        public Circle(double radius) : base("Circle") {
            if (radius <= 0) throw new ArgumentException("Radius must be > 0");
            Radius = radius;
        }
        public override double Area() => Math.PI * Radius * Radius;
    }

    // 3) Rectangle subclass
    public class Rectangle : Shape {
        public double Width  { get; }
        public double Height { get; }
        public Rectangle(double width, double height) : base("Rectangle") {
            if (width  <= 0 || height <= 0) 
                throw new ArgumentException("Dimensions must be > 0");
            Width  = width;
            Height = height;
        }
        public override double Area() => Width * Height;
    }

    public class Triangle : Shape {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        private readonly double _semiperimiter;
        public Triangle(double a, double b, double c) : base ("Triangle") {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Dimensions must be > 0");
            SideA = a;
            SideB = b;
            SideC = c;

            _semiperimiter = (a + b + c) / 2.0;
        }
        public override double Area() => Math.Sqrt(_semiperimiter * (_semiperimiter - SideA) * (_semiperimiter - SideB) * (_semiperimiter - SideC));
    }

    public class Pentagon : Shape {
        public double Side { get; }
        public double Apothem { get; }
        public Pentagon(double s, double a) : base ("Pentagon") {
            if (s <= 0 || a <= 0)
                throw new ArgumentException("Dimensions must be > 0");
            Side = s;
            Apothem = a;
        }
        public override double Area() => (5 * Side * Apothem) / 2;
    }
