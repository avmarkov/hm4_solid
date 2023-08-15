using hm4_solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm4_solid
{
    //DIP - Принцип инверсии зависимостей, класс Generator зависит от интерфейсов, а не от конкретных классов
    public class Generator
    {
        public int GeneratedNumber { get; }

        public Generator(ISetting setting, IRandom rnd)
        {

            GeneratedNumber = rnd.Next(setting.MinValue, setting.MaxValue + 1);

        }
    }
}
