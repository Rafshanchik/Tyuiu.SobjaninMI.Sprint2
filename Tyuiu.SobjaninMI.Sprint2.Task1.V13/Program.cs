using Tyuiu.SobjaninMI.Sprint2.Task1.V13.Lib;
DataService ds = new DataService();
int a = 145;
int b = 916;
int c = 164;
int d = 137;
bool[] res = ds.GetLogicOperations(a, b, c, d);
Console.Title = "Спринт #2 | Выполнил: Собянин М. И. | СМАРТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^, последовательность*");
Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,       *");
Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
Console.WriteLine("* (True, True, True, True, True, False), при a = 145, b = 916, c = 164,   *");
Console.WriteLine("* d = 137                                                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("* a = 145, b = 916, c = 164, d = 137                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
for  (int i = 0; i < res.Length; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();