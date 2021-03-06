﻿using Microsoft.Extensions.Configuration;

namespace ConsoleApp1
{
    public class AppConfig
    {
        static AppConfig Instance;

        public ConnectionStringsConfig ConnectionStrings { get; set; }
        public AppSettingsConfig AppSettings { get; set; }

        public AppConfig() { }
        public static AppConfig Get()
        {
            if (Instance != null) return Instance;

            Instance = new ConfigurationBuilder()
                .AddIniFile(".\\config.ini")
                .Build()
                .Get<AppConfig>();

            return Instance;
        }
    }
}
