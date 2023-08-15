using hm4_solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm4_solid
{
    // Single Responsibility Principle, т.е класс Setting отвечает только за настройки и единственная причина его изменений - изменение настроек
    public class Setting : ISetting
    {
        public int MinValue { get; }
        public int MaxValue { get; }
        public int AttemptNumber { get; }

        public Setting(int minValue, int maxValue, int attemptNumber)
        {
            MinValue = minValue;

            MaxValue = maxValue;

            AttemptNumber = attemptNumber;
        }
    }
}
