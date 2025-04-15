using System;

class Program
{
    static void Main(string[] args)
    {
         Activity running = new Running(5.0, 20);
        Activity cycling = new Cycling(15.0, 30);
        Activity swimming = new Swimming(20, 15);

        Console.WriteLine(running.GetSummary());
        Console.WriteLine(cycling.GetSummary());
        Console.WriteLine(swimming.GetSummary());
    }
}