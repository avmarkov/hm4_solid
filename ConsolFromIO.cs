using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm4_solid
{
    public class ConsolFromIO : InputOutput
    {
        public override void Print(string str)
        {

            Console.WriteLine(str);

        }

        public override string ReadLine()
        {

            return Console.ReadLine();

        }
    }
}
