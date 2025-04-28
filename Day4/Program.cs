namespace Day4 {
    
    // Animal exercise
    // Animal parent class
    
    // Program entry point
    class Program {
        static void Main(string[] args) {
            var shapes = new List<Shape> {
                new Circle(3),
                new Rectangle(4, 5),
                new Triangle(3, 4, 5),
                new Pentagon(4, 5)
            };
            Console.WriteLine("Shape Calculations");
            foreach (var s in shapes) {
                Console.WriteLine($"{s.Name} area = {s.Area():F2}");
            }

            var zoo = new List<Animal> {
                new Dog("Rexy"),
                new Cat("Dodo"),
                new Bird("Jack"),
                new Fish("Nemo")
            };
            Console.WriteLine("\nAnimal behaviour");
            foreach (var a in zoo) {
                a.Speak();
                a.Eat();
                Console.WriteLine();
            }
        }
    }
}
