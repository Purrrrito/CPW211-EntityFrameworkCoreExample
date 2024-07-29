using EntityFrameworkCoreExample;

StudentContext dbContext = new();

// Add with EF Core
Student s = new()
{
	FullName = "Wyatt Smith",
	EmailAddress = "Wyattjorgen@gmail.com",
	DateOfBirth = new DateTime(2006, 10, 11)
};

Student s2 = new()
{
	FullName = "Joe Ortiz",
	EmailAddress = "Joeortiz@gmail.com",
	DateOfBirth = new DateTime(2000, 1, 1)
};

dbContext.Add(s); // Prepares the Student insert statement
dbContext.SaveChanges(); // Executes pending insert. (In Actuality: Execute any pending insert)

dbContext.Add(s2); 
dbContext.SaveChanges();

// Retrieve Students from DB
List<Student> allStudents = dbContext.Students.ToList(); // Method syntax
//allStudents = (from stu in dbContext.Students
//			   select stu).ToList(); // Querey syntax
foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
    Console.WriteLine();
}