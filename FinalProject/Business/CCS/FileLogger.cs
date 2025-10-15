using System;
using Core.Utilities.Security.JWT;

namespace Business.CCS;

public class FileLogger : ILogger
{
    public void Log()
    {
        System.Console.WriteLine("Dosyaya basarili bir sekilde loglandi");
    }

}

