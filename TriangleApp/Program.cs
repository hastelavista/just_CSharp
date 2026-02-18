using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //Console.WriteLine();

        for (int i = 2; i < 9; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
