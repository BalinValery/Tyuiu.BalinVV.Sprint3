using Tyuiu.BalinVV.Sprint3.Task4.V5.Lib;
internal class Program
{
     static void Main(string[] args)
    {
        DataService ds = new DataService();
        int startValue = -5, endValue = 5;
        Console.Title = "Спринт #3 | Выполнил: Балин В.В. | СМАРТб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("*Спринт 3                                                                  *");
        Console.WriteLine("*Тема: Оператор цикла foreach                                              *");
        Console.WriteLine("*Задание #4                                                                *");
        Console.WriteLine("*Вариант #5                                                                *");
        Console.WriteLine("*Выполнил: Балин В.В.| СМАРТб-25-1                                         *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,                         *");
        Console.WriteLine("* вычислить значение функции y=(cos(x)-sin(x))/x                           *");
        Console.WriteLine("* При х = 0 прервать цикл. Полученные значения суммировать.                *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* -5 <= x <= 5                                                             *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Результат:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.Write("Сумма функций равна " + ds.Calculate(startValue, endValue));
        Console.ReadLine();
    }
}