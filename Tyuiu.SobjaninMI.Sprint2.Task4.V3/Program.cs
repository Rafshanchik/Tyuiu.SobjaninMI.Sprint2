using Tyuiu.SobjaninMI.Sprint2.Task4.V3.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Собянин М. И. | СМАРТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
Console.WriteLine("* переменных x,y с клавиатуры, если x < y - 1, то                         *");
Console.WriteLine("* z = y + (x-1)/(x+2) иначе x + 2y(1/(y+3))                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
double y = Convert.ToDouble(Console.ReadLine());

double res = ds.Calculate(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Значение функции" + res);

Console.ReadKey();