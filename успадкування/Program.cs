//ФІГУРА

public class Figure
{
    public virtual double CalculateArea()
    {
        return 0;
    }

    public virtual double CalculatePerimeter()
    {
        return 0;
    }
}
public class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

partial class Program
{
    static void Main(string[] args)
    {
       
        Circle circle = new Circle(5);
        Console.WriteLine($"Площа кола: {circle.CalculateArea():F2}");
        Console.WriteLine($"Периметр кола: {circle.CalculatePerimeter():F2}");

       
        Rectangle rectangle = new Rectangle(4, 6);
        Console.WriteLine($"Площа прямокутника: {rectangle.CalculateArea():F2}");
        Console.WriteLine($"Периметр прямокутника: {rectangle.CalculatePerimeter():F2}");
    }
}

//ФРУКТ

public class Fruit
{
    public string Name { get; set; }

    public Fruit(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Фрукт: {Name}");
    }
}

public class Apple : Fruit
{
    public string Variety { get; set; }
    public string Color { get; set; }

    public Apple(string name, string variety, string color) : base(name)
    {
        Variety = variety;
        Color = color;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Фрукт: {Name}, Сорт: {Variety}, Колір: {Color}");
    }
}

public class Pear : Fruit
{
    public string Color { get; set; }

    public Pear(string name, string color) : base(name)
    {
        Color = color;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Фрукт: {Name}, Колір: {Color}");
    }
}

partial class Program
{
    private static void Main_(string[] args)
    {
        Apple apple = new Apple("Яблуко", "Голден", "Зелений");
        Pear pear = new Pear("Груша", "Жовтий");

        apple.DisplayInfo();
        pear.DisplayInfo();
    }
}


//тварина

public abstract class Animal
{
    public float Weight { get; set; }
    public string Color { get; set; }

    public Animal(string color, float weight)
    {
        Color = color;
        Weight = weight;
    }

    public abstract string MakeSound();
}


public abstract class AnimalWithTail : Animal
{
    public float TailLength { get; set; }

    public AnimalWithTail(string color, float weight, float tailLength) : base(color, weight)
    {
        TailLength = tailLength;
    }
}

public class Cat : AnimalWithTail
{
    public Cat(string color, float weight, float tailLength) : base(color, weight, tailLength) { }

    private string Purr()
    {
        return "purrrrrrrr";
    }

    private string Meow()
    {
        return "Meow";
    }

    public override string MakeSound()
    {
        return Purr() + " " + Meow();
    }

    public override string ToString()
    {
        return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
    }
}

public class Dog : AnimalWithTail
{
    public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength) { }

    public override string MakeSound()
    {
        return "Woof";
    }

    public override string ToString()
    {
        return $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
    }
}

partial class Program
{
    static void Main_1(string[] args)
    {
        Cat cat = new Cat("Black", 4.5f, 30.0f);
        Console.WriteLine(cat.ToString());
        Console.WriteLine("Звук кота: " + cat.MakeSound());

        Dog dog = new Dog("Brown", 10.0f, 40.0f);
        Console.WriteLine(dog.ToString());
        Console.WriteLine("Звук собаки: " + dog.MakeSound());
    }
}
