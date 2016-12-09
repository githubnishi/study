using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Morning : Base
    {
        public void morning()
        {
            name = "朝";
        }

        public override void Hello()
        {
            Console.WriteLine("おはよう\n");
        }

        public override void Out()
        {
            Console.WriteLine("あかるい\n");
        }
    }
}
