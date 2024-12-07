using Class;

Student student1 = new("Adebayo", "Khalellulah", "Ologun", 20, "Male");
Student student2 = new("Adeyemi", "Wasilah", "Bolanle", 90, "Female");


student1.PrintUserDetails();
Console.WriteLine();
student2.PrintUserDetails();
Console.WriteLine();

Teacher teacher = new("Adewale", "Arike", "Olabisi", "aribisi@gmail.com", "08121312232");
teacher.PrintUserDetails();