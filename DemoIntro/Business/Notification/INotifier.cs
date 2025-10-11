using System;

namespace Business.Notification;

public interface INotifier
{
    void SendWelcome(string name, string email);
}
