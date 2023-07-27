//var myAge = 35;

var name = "Ewa";
char sex = 'k';
int age = 20;



if( sex == 'k' )
{
    if (age < 30)
    {
        Console.Write("Kobieta ponizej 30 lat. ");
    }
    else
    {
        Console.Write("Kobieta powyzej 30 lat. ");
    }

    if (name == "Ewa")
    {
        Console.WriteLine("O imieniu Ewa, lat " + age);
    }
    else
    {
        Console.WriteLine("");
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("Niepelnoletni Mezczyzna ");
    }
    else
    {
        Console.WriteLine("Pelnoletni Meszczyzna");
    }

}