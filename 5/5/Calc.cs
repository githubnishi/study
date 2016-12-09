using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Calc
    {
        private float x;
        private float y;

        public float X
        {
            set { x = value; }
            get { return x; }
        }

        public float Y
        {
            set { y = value; }
            get { return y; }
        }

        public float add()
        {
            return x + y;
        }

        public float Pull()
        {
            return x - y;
        }

        public float Mult()
        {
            return x * y;
        }

        public float Div()
        {
            return x / y;
        }
    }
}
