using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Base
    {
        protected string name = "";

        public virtual void Hello()
        {
            Console.WriteLine("あいさつ");
        }

        public virtual void Out()
        {
            Console.WriteLine("あかるさ");
        }
    }
}
