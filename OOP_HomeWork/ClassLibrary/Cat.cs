
using ClassLibrary;

class Cat :Animal
{
    public void DisplaySpecies()
    {
        // Có thể truy cập Species ở đây vì nó là protected internal
        Console.WriteLine($"Species: {Age}");
    }
    static object Main(string[] args)
    {
        Animal animal = new Animal();
        // Có thể truy cập Species từ đây vì nó là internal
        animal.Color = "Canine";

        Cat dog = new Cat();
        // Có thể truy cập Species từ đây vì nó là protected internal
        dog.Age = 10;
        dog.DisplaySpecies;
    }
}