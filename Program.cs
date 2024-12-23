﻿using System;
using ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a task to execute (1-5):");

        int taskNumber = int.Parse(Console.ReadLine());
        switch (taskNumber)
        {
            case 1:
                Task1Product.Run();
                break;
            case 2:
                Task2BankAccount.Run();
                break;
            case 3:
                Task3DivisionCalclulator.Run();
                break;
            case 4:
                Task4ValidateAge.Run();
                break;
            case 5:
                Task5FileReader.Run();
                break;
            default:
                Console.WriteLine("Invalid option!");
                break;
        }
    }
}
