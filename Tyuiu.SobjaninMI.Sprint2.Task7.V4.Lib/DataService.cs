using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SobjaninMI.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((x > 0 && x < 0.3) && (y > 0 && y < 0.3))
            {
                res = false;
            }
            else if (x > 1 || y > 1)
            {
                res = false;
            }
            else
            {
                res = true;
            }
            return res;
        }
    }
}
