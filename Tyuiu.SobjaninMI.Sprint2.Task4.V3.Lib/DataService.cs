using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SobjaninMI.Sprint2.Task4.V3.Lib
{
    public class DataService : ISprint2Task4V3
    {
        public double Calculate(double x, double y)
        {
            double z = x < y ? y + (y - 1) / (x + 2) : x + 2 * y * (1 / (y + 3));
            return Math.Round(z, 3);
        }
    }
}
