using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Box
    {
        //fields
        private double _length;
        private double _breadth;
        private double _depth;

        //properties là các fields có get; set
        public double lenghth
        {
            get { return _length; } //get sẽ trả về giá trị của trường 
            set { _length = value; } // set sẽ gán giá trị cho trường.
        }

    }
}
