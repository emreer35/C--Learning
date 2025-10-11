using System;
using Core.Entities;

namespace Core.Entitites.Concrete;

// user i core katmanina su yuzden aldik 
// bir defa olsuturup butun projelerimizde kullanabiliiriz bunu 
public class User : IEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public byte[] PasswordHash { get; set; } // veritabaninda binary verdigimiz icin byte array turunde olacak
    public byte[] PasswordSalt { get; set; }
    public bool Status { get; set; }
}
