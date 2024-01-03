// See https://aka.ms/new-console-template for more information
// encapsulation (tính đóng gói) giúp che giấu thông tin với môi trường bên ngoài.
// Việc tác động từ môi trường bện ngoài phụ thuộc và đính dạng mã
// có 5 kiễu encapsulation public, private, protected, internal, protected internal.
using ClassLibrary;
using Encapsulation;

class program
{
    static void Main()
    {
        Animal animal = new Animal();
        // Có thể truy cập Species từ đây vì nó là internal
        animal.Name = "Canine";

        Dog dog = new Dog();
        // Có thể truy cập Species từ đây vì nó là protected internal
        dog.Name = "Labrador";
        dog.DisplaySpecies();
    }
}