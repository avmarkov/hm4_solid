using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm4_solid
{
    public class RandomChanged : Random
    {
        public override int Next(int minValue, int maxValue)
        {

            return base.Next(minValue + 1 - 1, maxValue + 1 - 1);

        }
    }
}
