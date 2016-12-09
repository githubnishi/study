using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Box
    {
        private float High;
        private float Width;

        public float high
        {
            set { High = value; }
            get { return High; }
        }

        public float width
        {
            set { Width = value; }
            get { return Width; }
        }


        public float Periphery()        //外周の長さを求める
        {
            float Per = 0;

            Per = High * 2;
            Per = Width * 2;

            return Per;
        }

        public float Area()         //面積
        {
            float area = 0;

            area = High * Width;

            return area;
        }
    }
}
