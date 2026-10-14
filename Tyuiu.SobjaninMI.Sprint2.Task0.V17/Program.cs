using Tyuiu.SobjaninMI.Sprint2.Task0.V17.Lib;
DataService ds = new DataService();
int x = 1065;
int y = 755;
bool[] res = ds.GetCompareOperations(x, y);
Console.Title = "Спринт #2 | Выполнил: Собянин М. И. | СМАРТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
Console.WriteLine("* (True, False, False, False, False, False), при x = 1065, y = 755        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("* x = 1065, y = 755                                                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();