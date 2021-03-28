using System;

namespace สอบมิดข้อสอง_ครน
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,x,y;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;
            if (x == y)
                Console.WriteLine(x);
            else
            {
                do
                {
                    if (x < y)
                    {
                        x = x + a;
                    }
                    else
                    {
                        y = y + b;
                    }
                }
                while (x != y);
                Console.WriteLine(x);
            }
            

        }
    }
}
