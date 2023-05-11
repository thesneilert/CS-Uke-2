using Ukesoppgave_Uke_2;

Console.WriteLine("Trykk 1 for å legge til bruker");
Console.WriteLine("Trykk 2 for å filtrere kurs for brukere");
Console.WriteLine("Trykk 3 for å se alle brukere");
var menyvalg = Console.ReadLine();


var persons = new List<Student>
{
    new("Ola", "20", "Fotball"),
    new("Nora", "30", "Håndball"),
    new("Espen", "20", "Tennis"),
    new("Tore", "26", "Tennis"),
    new("Geir", "42", "Fotball"),
    new("Thomas", "34", "Håndball"),
    new("Kamilla", "21", "Tennis"),
    new("Tiril", "22", "Fotball")
};


if (menyvalg == "1")
{
    Console.WriteLine("Hva er ditt navn?");
    var navn = Console.ReadLine();
    Console.WriteLine("Hvor gammel er du?");
    var age = Console.ReadLine();
    Console.WriteLine("Hvilket kurs går du på?");
    var course = Console.ReadLine();

    persons.Add(new Student(navn, age, course));
    foreach (var x in persons) Console.WriteLine(x.Name);
}


else if (menyvalg == "2")
{
    Console.WriteLine("Skriv Fotball, Håndball eller Tennis for å vise påmeldte:");

    var flag = true;
    while (flag)
    {
        var valg = Console.ReadLine();
        Console.WriteLine($"\nDette er de påmeldte for {valg} kurset:");
        foreach (var x in persons)
            if (x.Course == valg)
                Console.WriteLine("- " + x.Name);

        Console.WriteLine("\n\nSkriv Fotball, Håndball eller Tennis for å vise påmeldte,\n" +
                          "eller trykk ENTER for å starte på nytt:");

        if (valg == "")
        {
            Console.Clear();
            Console.WriteLine("Skriv Fotball, Håndball eller Tennis for å vise påmeldte:");
        }
    }
}


else if (menyvalg == "3")
{
    var groupedPersons = persons.GroupBy(x => x.Course);

    foreach (var x in groupedPersons)
    {
        Console.WriteLine($"Kurs: {x.Key}");
        foreach (var person in x)
        {
            Console.WriteLine($"Navn: {person.Name}, Alder: {person.Age}");
        }
        Console.WriteLine();
    }
}