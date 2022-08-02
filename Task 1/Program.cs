using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int m = 42;
            int count = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 7 == 0)
                {
                    count++;
                   
                }
            }
            Console.WriteLine(count);

        } 
    }
}
