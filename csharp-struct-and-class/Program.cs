namespace StructAndClass
{
    public class Program
    {
        //struct Person
        //{
        //    public string name;
        //    public string surname;
        //    public string identifier;

        //    public Person(string name, string surname, string identifier)
        //    {
        //        this.name = name;
        //        this.surname = surname;
        //        this.identifier = identifier;
        //    }
        //}

        class Person
        {
            public string name;
            public string surname;
            public string identifier;

            public Person(string name, string surname, string identifier)
            {
                this.name = name;
                this.surname = surname;
                this.identifier = identifier;
            }
        }

        static void Main(string[] args)
        {
            //Person person;
            //person.name = "Onur";
            //person.surname = "AKMESE";
            //person.identifier = "AOFDODODOD";
            //Console.WriteLine($"{person.name} - {person.surname} - {person.identifier}");

            //Person person2 = new Person("Onur", "AKMESE", "AOFDODODOD");
            //Console.WriteLine($"{person2.name} - {person2.surname} - {person2.identifier}");

            Person person = new Person("Onur", "AKMESE", "AOFDODODOD");

        }
    }
}