using System;

namespace GameProject;

public class UserValidationManager : IUserValidationService
{
    public bool Validate(Gamer gamer)
    {
        if (gamer.FirstName == "YUNUS EMRE")
        {
            return true;
        }
        return false;
    }
}
