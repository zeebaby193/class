namespace Class;

public class Student : User
{
    private int Age { get; set; }
    private string Gender { get; set; }

    public Student(string firstname, string lastname, string? middlename, int age, string gender)


    : base(firstname, lastname, middlename)
    {
        Age = age;
        Gender = gender;
    }

    public override void PrintUserDetails() //raw string literal
    {
        string initial = GetInitial();
        string details = $"""
        ===STUDENT DETAILS===
        FirstName: {LastName.ToUpper()} {FirstName} {initial}
        Age: {Age}
        Gender: {Gender}
        """;
        Console.WriteLine(details);

    }

}