using System;

namespace дз1сабина1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите значения трех точек A B и C, точка C мужду точками A и B");
            Console.WriteLine("введите значения точки A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("введите значения точки B");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("введите значения точки C");
            int C = int.Parse(Console.ReadLine());
            if (A > B)
            {
                if (C > A || C < B)
                {
                    Console.WriteLine("Условие не выполнено");
                    Environment.Exit(0);


                }
            }
            if (A < B)
            {
                if (C < A || C > B)
                {
                    Console.WriteLine("Условие не выполнено");
                    Environment.Exit(0);


                }
            }
            int AC = Math.Abs(C - A);
            int BC = Math.Abs(C - B);
            double answer = AC*BC;
            Console.WriteLine($"произведение AC на BC = :{string.Format("{0:0.000}", answer)}");
        }
    }
}
