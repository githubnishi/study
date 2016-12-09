using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Morning asa = new Morning();
            Night yoru = new Night();

            asa.Hello();
            asa.Out();

            yoru.Hello();
            yoru.Out();

            for (; ; ) ;
        }
    }
}
