
//dotnet tool install --global dotnet-script
//dotnet script file.cs

using System;

    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }


    Console.WriteLine();


    for (int i = 10; i >= 1; i--)
    {
        string row = "";
        for (int j = 0; j <= i; j++)
        {
            row += "*";
        }
        Console.WriteLine(row);
    }
