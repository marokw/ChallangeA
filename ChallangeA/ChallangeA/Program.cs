//using ChallangeA;

//var rand = new Random();
//List<Employee> employees = new List<Employee>();

//employees.Add( new Employee("Adam", "Kowalski", 32) );
//employees.Add(new Employee("Monika", "Nowak", 19));
//employees.Add(new Employee("Zuzia", "Bąk", 44));

//foreach( Employee e in employees )
//    for(int i=0; i < 5; i++)
//    {
//        e.AddGrade( rand.Next(1,10+1) );
//    }

//int biggestScore = 0;

//foreach (Employee e in employees)
//    if (e.GradesSum > biggestScore)
//        biggestScore = e.GradesSum;


//foreach (Employee e in employees)
//    if (e.GradesSum == biggestScore)
//    {
//        Console.WriteLine("Pracownik: " + e.Name + " " + e.Surname + " w wieku " + e.Age);
//        Console.WriteLine("Ma najwiekszą liczbę ocen = " + e.GradesSum );
//        e.PrintGrades();
//    }


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