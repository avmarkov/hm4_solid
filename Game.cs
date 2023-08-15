using hm4_solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm4_solid
{
    public class Game : IGame
    {
        private readonly ISetting _setting;

        private readonly InputOutput _inputOutput;

        private int _generatedNumber;

        private int _attemptNumber = 0;

        // Здесь тоже DIP - Принцип инверсии зависимостей
        public Game(ISetting setting, InputOutput inputOutput)
        {
            _setting = setting;

            _inputOutput = inputOutput;
        }
        public void Start()
        {
            _generatedNumber = new Generator(_setting, new RandomNumber()).GeneratedNumber;

            _inputOutput.Print($"Загаданное число: {_generatedNumber}");

            _inputOutput.Print($"Угадайте число от {_setting.MinValue} до {_setting.MaxValue}. Число попыток {_setting.AttemptNumber}");

            while (_attemptNumber++ < _setting.AttemptNumber)
            {
                var input = _inputOutput.ReadLine();

                var result = int.TryParse(input, out var number);

                if (result)
                {
                    if (ProcessNumber(number))
                        break;
                }
                else
                {
                    _inputOutput.Print($"Попробуйте еще раз, Вы ввели неправильное значение, осталось {_setting.AttemptNumber - _attemptNumber} попыток");
                }
            }
        }

        private bool ProcessNumber(int number)
        {
            if (number == _generatedNumber)
            {
                _inputOutput.Print($"Вы угадали число с {_attemptNumber} попытки");
                return true;
            }

            if (number > _setting.MaxValue || number < _setting.MinValue)
            {
                _inputOutput.Print($"Ваше число вне диапазона, попробуйте еще раз, осталось {_setting.AttemptNumber - _attemptNumber} попыток");
                return false;
            }

            _inputOutput.Print($"Ваше число {(number > _generatedNumber ? "больше" : "меньше")} загаданного, попробуйте еще раз, осталось {_setting.AttemptNumber - _attemptNumber} попыток");

            return false;
        }
    }
}
