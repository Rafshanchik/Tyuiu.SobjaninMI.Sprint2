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
                0 => "январь",
                1 => "февраль",
                2 => "март",
                3 => "апрель",
                4 => "май",
                5 => "июнь",
                6 => "июль",
                7 => "август",
                8 => "сентябрь",
                9 => "октябрь",
                10 => "ноябрь",
                11 => "декабрь",
                _ => "некоректный месяц"
            };
            return monthName;
        }
    }
}
