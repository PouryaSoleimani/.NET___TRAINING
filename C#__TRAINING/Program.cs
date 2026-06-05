//Console.WriteLine("HELLO WORLD FORM C# !!!!!!!!!!!!!!!!!!");
//Console.WriteLine("MY NAME IS POURYA , I AM A FULLSTACK DEVELOPER");
//Console.WriteLine("FIRST GIT INIT");

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("I WANT TO BE A (( ANGULAR + .NET FULL-STACK DEVELOPER ))");

        // VARIABLES -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // 1 - STRING
        string name = "POURYA";
        Console.WriteLine(name);

        // 2 - INT
        int age = 24;
        Console.WriteLine(age);

        name = "POURYA SOLEIMANI";
        Console.WriteLine(name);

        // 3 - LONG
        long longNumber = 1231232132132132312;
        Console.WriteLine(longNumber)
        Console.WriteLine("INT MAX VALUE => " + int.MaxValue);
        Console.WriteLine(format: "LONG MAX VALUE => " + long.MaxValue);

        // GET DATA FROM USER -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Console.WriteLine("Enter your first name :");
        string userFirstName = Console.ReadLine();

        Console.WriteLine("Enter your last name :");
        string userLastName = Console.ReadLine();

        Console.WriteLine("Enter Your Age : ");
        short age = 0;
        string userAge = Console.ReadLine();
        age = short.Parse(userAge)
        Console.WriteLine("HELLO " + userFirstName + " " + userLastName + " " + age + "" + "Years Old");
    }
}