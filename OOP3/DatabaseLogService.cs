using System;

namespace OOP3;

public class DatabaseLogService : ILoggerService
{
    public void Log()
    {
        System.Console.WriteLine("Database Log Yazildi");
    }

}
