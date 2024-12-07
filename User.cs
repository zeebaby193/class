using System;

namespace Class;

public abstract class User

{
    protected string FirstName{get; set;}
    protected string LastName{get; set;}
    protected string? MiddleName{get; set;}

    public User(string firstname, string lastname, string? middlename)
    {
        FirstName = firstname;
        LastName = lastname;
        MiddleName = middlename;
    }

    protected string GetInitial()
    {
        if (string.IsNullOrWhiteSpace(MiddleName))
        {
            return string.Empty;
        }
        return $"{MiddleName.Trim().Substring(0, 1).ToUpper()}.";
    }

    public abstract void PrintUserDetails();
}