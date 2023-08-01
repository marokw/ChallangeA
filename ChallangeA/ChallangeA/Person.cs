namespace ChallangeA
{
    public abstract class Person
    {
        public Person(string Name = "-", string Surname = "-", uint age = 0)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = age;
        }

        public string Name { get; }

        public string Surname { get; }

        public uint Age { get; }
    }
}
