using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Book
    {
        //fields
        private double _length;
        private double _breadth;
        private double _depth;

        //properties là các fields có get; set
        public double Length
        {
            get { return _length; } //get sẽ trả về giá trị của trường 
            set { _length = value; } // set sẽ gán giá trị cho trường.
        }

        public double Breadth
        {
            get { return _breadth; }
            set { _breadth = value; }
        }

        public double Depth
        {
            get { return _depth; }
            set { _depth = value; }
        }

        // methods
        public void Print()
        {
            Console.WriteLine("Length = {0}, Breadth = {1}, Height = {2}", Length, Breadth, Height);
        }

    }
}
