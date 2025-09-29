using System;
namespace Business.CCS;

public class DatabaseLogger : ILogger
{
    public void Log()
    {
        System.Console.WriteLine("Veritabanina basarili bir sekilde loglandi");
    }
}
