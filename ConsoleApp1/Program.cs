﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static readonly AppConfig Config = AppConfig.Get();

        static void Main(string[] args)
        {
            Console.WriteLine(Config.ConnectionStrings.Database);
            Console.WriteLine(Config.AppSettings.UserName);
            Console.WriteLine(Config.AppSettings.RetryCount);
            Console.Read();
        }
    }
}
