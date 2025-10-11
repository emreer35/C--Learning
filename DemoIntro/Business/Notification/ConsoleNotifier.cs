using System;

namespace Business.Notification;

public class ConsoleNotifier : INotifier
{
    public void SendWelcome(string name, string email)
    {
        System.Console.WriteLine($"Kayit basarili : {name} | {email}");
    }
}
