Console.WriteLine("Enter a value");

var name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
    Console.WriteLine("Enter a valid value");


    Console.WriteLine($"Message send to: {name}");
