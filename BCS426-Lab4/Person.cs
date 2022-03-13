namespace Wrox.ProCSharp.Generics
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string f = "none", string l = "none")
        {
            FirstName = f;
            LastName = l;
        }

        public override string ToString() => $"{FirstName} {LastName}";
    }

}