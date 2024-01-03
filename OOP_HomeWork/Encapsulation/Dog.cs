using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Dog: Animal
    {
        public void DisplaySpecies()
        {
            // ko truy cập name ở đây vì nó là protected internal
            Console.WriteLine($"Species: {Name}");
        }
    }
}
