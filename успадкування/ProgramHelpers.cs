//ФІГУРА

internal static class ProgramHelpers
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
    private static void Main(string[] args)
    {
        Apple apple = new Apple("Яблуко", "Голден", "Зелений");
        Pear pear = new Pear("Груша", "Жовтий");

        apple.DisplayInfo();
        pear.DisplayInfo();
    }
    static void Main(string[] args)
    {
        Cat cat = new Cat("Black", 4.5f, 30.0f);
        Console.WriteLine(cat.ToString());
        Console.WriteLine("Звук кота: " + cat.MakeSound());

        Dog dog = new Dog("Brown", 10.0f, 40.0f);
        Console.WriteLine(dog.ToString());
        Console.WriteLine("Звук собаки: " + dog.MakeSound());
    }
}