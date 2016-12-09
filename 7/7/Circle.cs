using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Circle
    {
        private float Line;

        public float line
        {
            set { Line = value; }
            get { return Line; }
        }

        public float Periphery()        //外周の長さを求める
        {
            float Per = 0;

            Per = 2 * Line * (float)Math.PI;

            return Per;
        }

        public float Area()         //面積
        {
            float area = 0;

            area = (Line * Line) * (float)Math.PI;

            return area;
        }
    }
}
