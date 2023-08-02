using ChallangeA;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
//Console.WriteLine("Podaj ocenę pracownika: ");

//var employee = new Employee("Adam", "Kamizelich");
var employee = new Supervisor("Adam", "Kamizelich");

Console.WriteLine($"Podaj ocenę przełożonego: {employee.Name} {employee.Surname}");
//Console.WriteLine($"Podaj ocenę pracownika: {employee.Name} {employee.Surname}");

string? input;
while ((input = Console.ReadLine()) != "q")
{
    try
    {
        if(input != null)   
            employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine("Exception catched!");
        Console.WriteLine($"{e.Message}");
    }

    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
}


var stats = employee.GetStatistics(); 
Console.WriteLine($"Grades Count: {employee.Grades.Count:N0}");
Console.WriteLine($"Average: {stats.Average:N2}");
Console.WriteLine($"AverageLetter: {stats.AverageLetter}");
Console.WriteLine($"Min: {stats.Min}");
Console.WriteLine($"Max: {stats.Max}");