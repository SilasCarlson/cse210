class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture(
            "How to make macaroni and cheese", 
            "In this lecture we will learn the science behind macaroni and cheese", 
            "12/15/2025", 
            "10:30a.m.", 
            new Address("1234 Example St.", "Example City", "Idaho", "United States of America"),
            "Phill Smith",
            25
        );

        Console.WriteLine($"Short Description: {lecture.GetShortDescription()}");
        Console.WriteLine($"Standard Details: {lecture.GetStandardDetails()}");
        Console.WriteLine($"Full Details: {lecture.GetFullDetails()}");

        Reception reception = new Reception(
            "Wedding Reception",
            "A wedding reception for John and Jessica",
            "12/30/2025",
            "11:00a.m.",
            new Address("5652 Hamburger St.", "Rigby", "Idaho", "United States of America"),
            "john.jessica.smith@gmail.com"
        );
        
        Console.WriteLine();
        Console.WriteLine($"Short Description: {reception.GetShortDescription()}");
        Console.WriteLine($"Standard Details: {reception.GetStandardDetails()}");
        Console.WriteLine($"Full Details: {reception.GetFullDetails()}");

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Cookout",
            "A barbeque cookout at my house!",
            "8/20/2026",
            "5:00p.m.",
            new Address("3333 Barbeque Ln.", "Merdian", "Idaho", "United States of America"),
            "Clear skies with a temperature of 70 degrees"
        );

        Console.WriteLine();
        Console.WriteLine($"Short Description: {outdoorGathering.GetShortDescription()}");
        Console.WriteLine($"Standard Details: {outdoorGathering.GetStandardDetails()}");
        Console.WriteLine($"Full Details: {outdoorGathering.GetFullDetails()}");
    }
}