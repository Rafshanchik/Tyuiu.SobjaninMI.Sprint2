using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SobjaninMI.Sprint2.Task0.V17.Lib
{
    public class DataService : ISprint2Task0V17
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];
            result[0] = x > y;
            result[1] = y > x;
            result[2] = x - y > x;
            result[3] = x == y;
            result[4] = x - y == 0;
            result[5] = x + y == 0;
            return result; 
        }
    }
}
