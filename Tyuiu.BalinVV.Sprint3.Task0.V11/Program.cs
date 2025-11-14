using Tyuiu.BalinVV.Sprint3.Task0.V11.Lib;
internal class Program
{
     static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Балин В.В. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Балин В.В. | СМАРТб-25-1                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int value = 5;
        int startValue = 1;
        int stopValue = 10;
        Console.WriteLine("Переменная X  = " + value);
        Console.WriteLine("Старт шага  = " + startValue);
        Console.WriteLine("Конец шага  = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма ряда =" + ds.GetSumSeries(value, startValue, stopValue));

        Console.ReadKey();
    }
}