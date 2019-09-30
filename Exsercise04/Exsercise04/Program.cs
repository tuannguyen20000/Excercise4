using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
        public static bool IsOdd(int n)
        {
            if (n % 2 == 0)
                return false;
            else
                return true;
        }
        public static bool IsEven(int n)
        {
            if (n % 2 != 0)
                return true;
            else
                return false;

        }
        public static bool IsPrime(int n)
        {
            if ((n & 1) == 0)
            {
                if (n == 2)
                    return true;
                else
                    return false;
            }
            for (int i = 3; (i * i) <= n; i += 2)
            {
                if ((n % i) == 0)
                    return false;
            }
            return n != 1;
        }
        public static int Square(int n)
        {
            return n * n;
        }
        public static int Cube(int n)
        {
            return n * n * n;
        }
        public static int Pow(int x, int y)
        {
            int temp;
            if (y == 0)
                return 1;
            temp = Pow(x, y / 2);

            if (y % 2 == 0)
                return temp * temp;
            else
                if (y > 0)
                return x * temp * temp;
            else
                return (temp * temp) / x;
        }
        public static int Abs(int n)
        {
            if (n > 0)
                n = n;
            else
                n = n * (n - 1);
            return n;
        }
        public static int ceil(float x)
        {
            return (int)x + 1;
        }
    }
}
