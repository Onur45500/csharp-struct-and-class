namespace StructAndClass
{
    public class Program
    {

        struct Person
        {
            public string name;
            public string surname;
            public string identifier;
        }

        static void Main(string[] args)
        {
            Person Onur;
            Onur.name = "Onur";
            Onur.surname = "AKMESE";
            Onur.identifier = "AOFDODODOD";

            Console.WriteLine($"{Onur.name} - {Onur.surname} - {Onur.identifier}");
        }
    }
}