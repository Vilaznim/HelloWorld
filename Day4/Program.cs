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
            Console.WriteLine("--- Shape Calculations ---");
            foreach (var s in shapes) {
                Console.WriteLine($"{s.Name} area = {s.Area():F2}");
            }

            var zoo = new List<Animal> {
                new Promfrit("Anton"),
                new Stigo("Oliver"),
                new Kpzet("Viggo"),
                new Dog("Rexy"),
                new Cat("Dodo"),
                new Cat("Lau"),
                new Bird("Jack"),
                new Fish("Nemo"),
            };
            Console.WriteLine("\n--- Animal behaviour ---");
            foreach (var a in zoo) {
                a.Speak();
                a.Eat();
                a.Print();
                Console.WriteLine();
            }

            Chorus(zoo);
            FeedAll(zoo);

            static void Chorus(IEnumerable<Animal> animals) {
                Console.WriteLine("\n--- Animal Chorus ---");
                foreach (var animal in animals) {
                    animal.Speak();
                }
            }

            static void FeedAll(IEnumerable<Animal> animals) {
                Console.WriteLine("\n--- Feeding Time ---");
                foreach (var animal in animals) {
                    animal.Eat();
                }
            }
        }
    }
}
