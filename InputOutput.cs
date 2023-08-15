using hm4_solid.Interfaces;

namespace hm4_solid
{
    // OCP - принцип открытости/закрытости
    // Если захотим выводить не в консоль, то создадим класс, унаследуем его от IOutput и переопределим функцию Print
    // Таким образом класс открыт для модификации

    // Здесь же и принцип разделения интерфейсов
    public class InputOutput : IOutput, IInput
    {
        public virtual void Print(string str)
        {
            Console.WriteLine(str);
        }

        public virtual string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
