using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SobjaninMI.Sprint2.Task1.V13.Lib
{
    public class DataService : ISprint2Task1V13
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = (a < b) && (b > c);
            result[1] = (d < a) || (a == b);
            result[2] = !(b < a) && (b > d);
            result[3] = !(c < a) ^ (b == c);
            result[4] = !(c != b) ^ !(b == c);
            result[5] = (d != a) ^ (c != b);
            return result;
        }
    }
}
