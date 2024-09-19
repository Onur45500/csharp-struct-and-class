namespace StructAndClass
{
    public class Program
    {
        // The constructor of a struct can't be empty.
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

        // The difference with struct is the fact that the constructor can be empty and we can have multiple constructor
        class Person
        {
            private string name;
            private string surname;
            private string identifier;
            private int age;

            // The number of arguments and their types allow us to differentiat between the constructor, the name here don't matter
            public Person(string name, string surname, string identifier)
            {
                this.name = name;
                this.surname = surname;
                this.identifier = identifier;
            }

            public Person(string name, string surname)
            {
                this.name = name;
                this.surname = surname;
            }

            public Person(string name)
            {
                this.name = name;
                this.surname = "O";
            }

            public Person(int age)
            {
                this.age = age;
                this.surname = "O";
            }

            public void SetName(string name)
            {
                if(!string.IsNullOrEmpty(name))
                {
                    this.name = name;
                }
                else
                {
                    this.name = "Invalid name";
                }
            }

            public string GetName()
            {
                return name;
            }

            public void ReturnsDetails(Person person)
            {
                Console.WriteLine($"{person.name} - {person.surname} - {person.identifier}");
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
            person.ReturnsDetails(person);

            person.SetName("Romain");
            person.ReturnsDetails(person);

            Console.WriteLine($"{person.GetName()}");

        }
    }
}