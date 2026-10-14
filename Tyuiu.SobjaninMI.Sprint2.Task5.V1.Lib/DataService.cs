using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SobjaninMI.Sprint2.Task5.V1.Lib
{
    public class DataService : ISprint2Task5V1
    {
        public int FindMonthDaysCount(int value)
        {
            int res;
            if (value > 12 || value < 1)
            {
                throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}");

            }
            switch (value)
            {
                case 2:
                    // Февраль
                    res = 28;
                    break;

                case 4:
                    // Апрель
                    res = 30;
                    break; 

                case 6:
                    // Июнь
                    res = 30;
                    break; 

                case 9:
                    // Сентябрь
                    res = 30;
                    break; 

                case 11:
                    // Ноябрь
                    res = 30;
                    break; 

                default:
                    res = 31;
                    break;
            }
            return res;
        }
    }
}
