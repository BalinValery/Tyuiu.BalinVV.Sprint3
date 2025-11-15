using Tyuiu.BalinVV.Sprint3.Task6.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Балин В.В. | СМАРТб-25-1";
       
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнил: Балин В.В.| СМАРТб-25-1                                       *");
        Console.WriteLine("введите начальное значение отрезка: ");
        int startValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("введите конечное значение отрезка: ");
        int stopValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        

        var result = ds.GetSumTheDivisors(startValue, stopValue);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}