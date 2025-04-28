namespace Day4;
public abstract class Animal {
        public string Name { get; }
        protected Animal(string name) => Name = name;

        public abstract void Speak();
        public virtual void Eat()
            => Console.WriteLine($"{Name} is eating.");
        public virtual void Print()
            => Console.WriteLine($"{Name} can't print money, Silly, it's an animal!");
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
            => Console.WriteLine($"{Name} says Glub Glub!");
    }

    public class Promfrit : Animal {
        public Promfrit(string name) : base(name) { }
        public override void Speak()
            => Console.WriteLine($"{Name} says SKRRRRRRRRT!");
        public override void Print()
            => Console.WriteLine($"{Name} prints a ton of money, DOLLAR DOLLAR!!!");
    }

    public class Stigo : Animal {
        public Stigo(string name) : base(name) { }
        public override void Speak()
            => Console.WriteLine($"{Name} says I LOOOOOOVE, I LOOOOOOVE, I LOOOOOooooOOOOOOVE");
        public override void Print()
            => Console.WriteLine($"{Name} looks tirelessly through excel documents");
    }

    public class Kpzet : Animal {
        public Kpzet(string name) : base(name) { }
        public override void Speak()
            => Console.WriteLine($"{Name} Nej, nej, nej, nej, nej. Skal vi have Kpsex? ;^)");
        public override void Print()
            => Console.WriteLine($"{Name} Headshots you in Marvel Rivels, funny ekks d");
    }