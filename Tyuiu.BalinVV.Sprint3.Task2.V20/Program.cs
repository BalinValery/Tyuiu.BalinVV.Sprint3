using Tyuiu.BalinVV.Sprint3.Task2.V20.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int value = 1;
        int startValue = 1;
        int stopValue = 6;

        Console.WriteLine("Введите  значение X:" + value);
        Console.WriteLine("Старт шага:" + startValue);
        Console.WriteLine("Конец шага:" + stopValue);


        Console.WriteLine("********************************************************************************");
        Console.WriteLine("* Результат:                                                                   *");
        Console.WriteLine("********************************************************************************");

        Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));



        Console.ReadKey();
    }
}