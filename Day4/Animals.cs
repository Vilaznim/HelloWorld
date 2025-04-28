namespace Day4;
public abstract class Animal {
        public string Name { get; }
        protected Animal(string name) => Name = name;

        public abstract void Speak();
        public virtual void Eat()
            => Console.WriteLine($"{Name} is eating.");
    }

    // Mammal subclass
    public class Mammal : Animal {
        public Mammal(string name) : base(name) { }

        public override void Speak()
            => Console.WriteLine($"{Name} makes a mammal sound");

        public sealed override void Eat()
            => Console.WriteLine($"{Name} munches (Mammal style)");
    }

    // dog subclass inheriting from Mammal
    public class Dog : Mammal {
        public Dog(string name) : base(name) { }
        public override void Speak()
            => Console.WriteLine($"{Name} says Woof!");
    }

    // cat subclass inheriting from Mammal
    public class Cat : Mammal {
        public Cat(string name) : base(name) { }
        public override void Speak()
            => Console.WriteLine($"{Name} says Meow!");
    }

    // Bird subclass inheriting from Animal
    public class Bird : Animal {
        public Bird(string name) : base(name) { }
        public override void Speak()
            => Console.WriteLine($"{Name} Chirps!");
        public override void Eat()
            => Console.WriteLine($"{Name} pecks at seeds");
    }

    // Fish subclass inheriting from Animal
    public class Fish : Animal {
        public Fish(string name) : base(name) { }
        public override void Speak()
            => Console.WriteLine($"{Name} says Glup Glup!");
    }