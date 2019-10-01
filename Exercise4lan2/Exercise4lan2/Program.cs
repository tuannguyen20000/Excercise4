using System;

namespace Exercise4lan2
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
        //input :float x
        //output : int a that is smallest but not smaller than a
        //idea : a = (int) x then a=a+1\
        //if : x negative then a is unchanged
        //if x==a then a is unchanged   
        public static int Ceil(float x)
        {
            int a = (int)x;
            if (x > 0)
                if (x > a)
                    a = a + 1;
            return a;
        }
        //input: float y
        //output : int a that is largest but not smaller than a
        //idea : a = (int) x then a=a-1
        //if : x negative then a is unchanged
        //if x==a then a is unchanged
        public static int Floor(float x)
        {
            int a = (int)x;
            if (x < 0 && x != a)
                a = a - 1;
            return a;
        }
        public static int Rand1(int n)
        {
            Random rand = new Random();
            int rd = rand.Next(0, 2147483647);
            return rd;

        }
        public static float Rand2(float a)
        {
            Random rand2 = new Random();
            int rad = rand2.Next(0, 1);
            return rad;
        }
        public static long Factorial(long n)
        {
            long R = 1;
            for (int i = 1; i <= n; i++)
            {
                R = i * R;
            }
            return R;
        }
    }
}

