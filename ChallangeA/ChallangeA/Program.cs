using ChallangeA;

var emp = new Employee("Adam", "Kamizelich");
emp.AddGrade(2);
emp.AddGrade(2);
emp.AddGrade(6);
var stats = emp.GetStatistics();
Console.WriteLine($"Average: {stats.Average:N2}" );
Console.WriteLine($"Min: {stats.Min}" );
Console.WriteLine($"Max: {stats.Max}" );

Console.ReadLine();