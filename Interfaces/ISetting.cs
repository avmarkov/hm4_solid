using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm4_solid.Interfaces
{
    //Interface Segregation Principle, т.е разбил на маленькие интерфейсы, которые будут реализовывать классы
    public interface ISetting
    {
        public int MinValue { get; }
        public int MaxValue { get; }
        public int AttemptNumber { get; }

    }
}
