using Tyuiu.SobjaninMI.Sprint2.Task5.V1.Lib;
DataService ds = new DataService(); 

Console.Title = "Спринт #2 | Выполнил: Собянин М. И. | СМАРТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
Console.WriteLine("* требуемое значение и возвращает результат.                              *");
Console.WriteLine("* Условие: По данному номеру месяца, определите количество дней в этом    *");
Console.WriteLine("* месяце.                                                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите номер месяца: ");
int numMonth = Convert.ToInt32(Console.ReadLine());
int res = ds.FindMonthDaysCount(numMonth);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine($"Количество дней в этом месяце - {res}!");

Console.ReadKey();