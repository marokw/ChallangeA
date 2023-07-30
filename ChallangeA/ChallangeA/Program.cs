using ChallangeA;

var emp = new Employee("Adam", "Kamizelich");
emp.AddGrade(2);
emp.AddGrade("2");
emp.AddGrade(" 3 ");
emp.AddGrade("Wojtek");
emp.AddGrade(3246);
emp.AddGrade(2.3d);
emp.AddGrade(2);
emp.AddGrade(6);
var stats = emp.GetStatistics();
Console.WriteLine($"Average: {stats.Average:N2}" );
Console.WriteLine($"Min: {stats.Min}" );
Console.WriteLine($"Max: {stats.Max}" );

Console.ReadLine();