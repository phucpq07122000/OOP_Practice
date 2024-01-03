using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    // 5 phương thức encapsulation(tính đóng gói)
    public class Animal
    {
        //public
        //mức truy cập ai cũng vào dc
        public string Name = string.Empty;

        // Mức truy cập protected
        //chỉ có thể truy cập từ trong lớp và lớp kế thừa
        protected int Age;

        //mức truy cập private
        // chỉ có thể truy cập từ trong cùng 1 lớp 
        private int Money;

        // Mức truy cập internal
        // chỉ có thể truy cập trong cùng một assembly
        internal string? Color;

        // Mức truy cập protected internal
        protected internal void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Money: {Money},Age: {Age}, Color: {Color}");
        }

    }
}
