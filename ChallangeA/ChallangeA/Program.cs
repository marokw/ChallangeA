using ChallangeA;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Adam", "Kamizelich");
//var employee = new EmployeeInMemory("Adam", "Kamizelich");
//var employee = new Supervisor("Adam", "Kamizelich");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

Console.WriteLine($"Podaj ocenę pracownika: {employee.Name} {employee.Surname}");

string? input;
while ((input = Console.ReadLine()) != "q")
{
    try
    {
        if (input != null)
            employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception catched!");
        Console.WriteLine($"{e.Message}");
    }

    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
}


var stats = employee.GetStatistics(); 
Console.WriteLine($"Grades Count: {employee.GradesCount:N0}");
Console.WriteLine($"Average: {stats.Average:N2}");
Console.WriteLine($"AverageLetter: {stats.AverageLetter}");
Console.WriteLine($"Min: {stats.Min}");
Console.WriteLine($"Max: {stats.Max}");