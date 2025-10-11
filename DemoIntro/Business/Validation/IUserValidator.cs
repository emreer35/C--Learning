using System;

namespace Business.Validation;

public interface IUserValidator
{
    (bool Ok, string? error) ValidateRegistration(string name, string email);
}
