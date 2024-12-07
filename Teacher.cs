namespace Class;

public class Teacher : User
{
    private string Email{get; set;}
    private string PhoneNumber{get; set;}
    
    public Teacher(string firstname,string lastname,string? middlename,string email,string phoneNumber)
    :base(firstname, lastname, middlename)
    {
        Email = email;
        PhoneNumber = phoneNumber;
    }
        
        public override void PrintUserDetails() //raw string literal
    {
        string initial = GetInitial();
        string details = $"""
        ===TEACHER DETAILS===
        FirstName: {LastName.ToUpper()} {FirstName} {initial}
        Email: {Email}
        PhoneNumber: {PhoneNumber}
        """;
        Console.WriteLine(details);

    }

}
