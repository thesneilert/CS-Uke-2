using Ukesoppgave_Uke_2;

internal class Program
{
    private static readonly List<Student> persons = new()
    {
        new Student("Ola", "20", "Fotball"),
        new Student("Nora", "30", "Håndball"),
        new Student("Espen", "20", "Tennis"),
        new Student("Tore", "26", "Tennis"),
        new Student("Geir", "42", "Fotball"),
        new Student("Thomas", "34", "Håndball"),
        new Student("Kamilla", "21", "Tennis"),
        new Student("Tiril", "22", "Fotball")
    };

    public static void Main(string[] args)
    {
        while (true)
        {
            MainMenu();
        }
    }

    public static void MainMenu()
    {
        Console.WriteLine("Trykk 1 for å legge til bruker");
        Console.WriteLine("Trykk 2 for å filtrere kurs for brukere");
        Console.WriteLine("Trykk 3 for å se alle brukere");
        var menyvalg = Console.ReadLine();

        if (menyvalg == "1")
        {
            AddUser();
        }
        else if (menyvalg == "2")
        {
            FilterCourses();
        }
        else if (menyvalg == "3")
        {
            DisplayUsers();
        }
        else
        {
            Console.WriteLine("Ugyldig valg. Prøv igjen.");
            Console.Clear();
        }
    }

    public static void AddUser()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Hva er ditt navn?");
        Console.ResetColor();
        var navn = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Hvor gammel er du?");
        Console.ResetColor();
        var age = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Hvilket kurs går du på?");
        Console.ResetColor();
        var course = Console.ReadLine();

        persons.Add(new Student(navn, age, course));

        Console.WriteLine("Du er nå registrert! Trykk Enter for å gå tilbake til hovedmenyen.");
        Console.ReadLine();
        Console.Clear();
    }

    public static void FilterCourses()
    {
        Console.WriteLine("Skriv Fotball, Håndball eller Tennis for å vise påmeldte:");
        var valg = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(valg))
        {
            Console.WriteLine("Ugyldig valg. Prøv igjen.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nDette er de påmeldte for {valg} kurset:");
            Console.ResetColor();
            foreach (var person in persons)
                if (person.Course == valg)
                    Console.WriteLine("- " + person.Name);
        }

        Console.WriteLine("\nTrykk Enter for å gå tilbake til hovedmenyen.");
        var input = Console.ReadLine();

        Console.Clear();
    }

    public static void DisplayUsers()
    {
        var groupedPersons = persons.GroupBy(x => x.Course);

        foreach (var group in groupedPersons)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nKurs: {group.Key}");
            Console.ResetColor();

            foreach (var person in group) Console.WriteLine($"Navn: {person.Name}, Alder: {person.Age}");
        }

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\nTrykk Enter for å gå tilbake til hovedmenyen.");
        Console.ResetColor();
        Console.ReadLine();
        Console.Clear();
    }
}