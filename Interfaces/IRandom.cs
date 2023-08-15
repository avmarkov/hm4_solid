using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm4_solid.Interfaces
{
    //Interface Segregation Principle, т.е разбил на маленькие интерфейсы, которые будут реализовывать классы
    public interface IRandom
    {
        public int Next(int from, int to);

    }
}
