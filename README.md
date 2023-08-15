### Демонстрация SOLID принципов


На примере реализации игры «Угадай число» продемонстрировать практическое применение SOLID принципов.
Программа рандомно генерирует число, пользователь должен угадать это число. 
При каждом вводе числа программа пишет больше или меньше отгадываемого. Кол-во попыток отгадывания и диапазон чисел должен задаваться из настроек.
В отчёте написать, что именно сделано по каждому принципу.
Приложить ссылку на проект и написать, сколько времени ушло на выполнение задачи.

#### Single Responsibility Principle

Например класс Setting - соответсвует этому принципу. Класс Setting отвечает только за настройки и единственная причина его изменений - изменение настроек

```cs
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
```

#### Open-closed Principle (OCP)
Класс InputOutput соответсвует этому принципу. Если захотим выводить не в консоль, то создадим класс, унаследуем его от IOutput и переопределим функцию Print.
Таким образом класс открыт для модификации

```cs
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
```

#### Liskov Substitution Principle или LSP
Вместо класса RandomChanged мы можем использовать класс RandomNumber, от которого унаследован класс RandomChanged

```cs
public class RandomNumber : IRandom
{

    private readonly RandomChanged _rnd = new();

    public int Next(int from, int to)
    {

        return _rnd.Next(from, to);

    }
}

```


#### Interface Segregation Principle (ISP)
Я создал несколько маленьких интерфейсов, которые будут реализовывать классы
```cs
public interface ISetting
{
    public int MinValue { get; }
    public int MaxValue { get; }
    public int AttemptNumber { get; }
}

public interface IRandom
{
    public int Next(int from, int to);

}

public interface IOutput
{
    public void Print(string str);

}

public interface IInput
{
    public string ReadLine();

}

public interface IGame
{
    public void Start();
}

```

Принципу разделения интерфейсов также соответсвует и класс InputOutput 

```cs
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
```

####  Dependency inversion principle или DIP
Класс Generator соответсвует принципу DIP - он зависит от интерфейсов, а не от конкретных классов
```cs
public class Generator
{
    public int GeneratedNumber { get; }

    public Generator(ISetting setting, IRandom rnd)
    {

        GeneratedNumber = rnd.Next(setting.MinValue, setting.MaxValue + 1);

    }
}
```

Здесь тоже DIP - Принцип инверсии зависимостей:
```cs
public Game(ISetting setting, InputOutput inputOutput)
{
    _setting = setting;

    _inputOutput = inputOutput;
}
```

Результат работы программы:

<image src="images/result.png" alt="result">
