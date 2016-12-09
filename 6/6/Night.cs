using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Night : Base
    {
        public void night()
        {
            name = "夜";
        }

        public override void Hello()
        {
            Console.WriteLine("こんばんわ\n");
        }

        public override void Out()
        {
            Console.WriteLine("くらい\n");
        }
    }
}
