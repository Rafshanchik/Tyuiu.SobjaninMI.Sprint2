using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SobjaninMI.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            int monthNum = (n % 12 == 0) ? 0 : n % 12;
            string monthName = monthNum switch
            {
                0 => "Январь",
                1 => "Февраль",
                2 => "Март",
                3 => "Апрель",
                4 => "Май",
                5 => "Июнь",
                6 => "Июль",
                7 => "Август",
                8 => "Сентябрь",
                9 => "Октябрь",
                10 => "Ноябрь",
                11 => "Декабрь",
                _ => "Некоректный месяц"
            };
            return monthName;
        }
    }
}
