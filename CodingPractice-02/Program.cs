using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("'''");
{
    Animal animal = Animal.Dragon;
    Console.WriteLine($"Animal.Dragon: {(int)animal}{animal.ToString()}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Array priority = Enum.GetValues(typeof(Priority));
    foreach(Priority p in priority)
    {
        Console.WriteLine($"{p} = {priority}");
    }
}
Console.WriteLine("'''\n");

enum Animal
{
    Rabbit, 
    Dragon, 
    Snake
}
enum Priority
{
    High = 1, 
    Normal = 5, 
    Low = 10
}
