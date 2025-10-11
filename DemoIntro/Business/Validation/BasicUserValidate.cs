using System;

namespace Business.Validation;

public class BasicUserValidate : IUserValidator
{
    public (bool Ok, string? error) ValidateRegistration(string name, string email)
    {
        if (string.IsNullOrWhiteSpace(name)) return (false, "Isim bos olamaz");
        if (string.IsNullOrWhiteSpace(email)) return (false, "Email alani bos olamaz");
        return (true, null);
    }
}
